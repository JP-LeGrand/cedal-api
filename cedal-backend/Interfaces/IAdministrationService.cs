using System.Threading.Tasks;

namespace cedal_backend.Interfaces
{
    public interface IAdministrationService
    {
        Task<int> NumberOfApplicants();
        Task<int> NumberOfOrganisationsAssisted();
    }
}
