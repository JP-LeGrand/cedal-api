using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using cedal_backend.ClientInterfaces;
using cedal_backend.Models;
using Newtonsoft.Json;

namespace cedal_backend.Clients
{
  public class CedalEventClient : IEventClient
  {
    private readonly HttpClient _httpClient;

    public CedalEventClient(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }
    public async Task<IEnumerable<Event>> GetEventListAsync()
    {
      //var request = new HttpRequestMessage(HttpMethod.Get, $"{CedalResourceUrls.EventUrl}");
      var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/api/Events");
      request.Headers.Add("Mock", "true");
      var response = await _httpClient.SendAsync(request);
      if (!response.IsSuccessStatusCode)
      {
        return new Event[0];
      }
      var content = await response.Content.ReadAsStringAsync();

      return JsonConvert.DeserializeObject<IEnumerable<Event>>(content);
    }
  }
}
