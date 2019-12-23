using System.Threading.Tasks;
using cedal_backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cedal_backend.Controllers
{
    public class AdministrativeController : ControllerBase
    {
        private readonly IAdministrationService _administrationService;

        public AdministrativeController(IAdministrationService administrationService)
        {
            _administrationService = administrationService;
        }

        [HttpGet("NumberOfApplicants")]
        public async Task<ActionResult<int>> GetNumberOfApplicants()
        {
            return await _administrationService.NumberOfApplicants();
        }

        [HttpGet("NumberOfOrganisations")]
        public async Task<ActionResult<int>> GetNumberOfOrganisations()
        {
            return await _administrationService.NumberOfOrganisationsAssisted();
        }
    }
}
