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


    }
}
