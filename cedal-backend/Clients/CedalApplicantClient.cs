using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using cedal_backend.ClientInterfaces;
using cedal_backend.Models;
using Newtonsoft.Json;

namespace cedal_backend.Clients
{
    /// <summary>
    /// Client is used to make Http requests to API
    /// </summary>
    public class CedalApplicantClient : IApplicantClient
    {
        private readonly HttpClient _httpClient;

        public CedalApplicantClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Applicant>> GetApplicantListAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{CedalResourceUrls.ApiPrefix}/{CedalResourceUrls.ApplicantUrl}");

            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                return new Applicant[0];
            }
            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IEnumerable<Applicant>>(content);
        }
    }
}
