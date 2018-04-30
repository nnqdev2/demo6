using System.Collections.Generic;
using System.Threading.Tasks;
using OlprrApi.Models.Request;
using OlprrApi.Models.Response;

namespace OlprrApi.Services
{
    public interface IIncidentReportingService
    {
        Task<IEnumerable<ConfirmationType>> GetConfirmationTypes();
        Task<IEnumerable<County>> GetCounties();
        Task<IEnumerable<DiscoveryType>> GetDiscoveryTypes();
        Task<IEnumerable<QuadrantT>> GetQuadrants();
        Task<IEnumerable<ReleaseCauseType>> GetReleaseCauseTypes();
        Task<IEnumerable<SiteTypeT>> GetSiteTypes();
        Task<IEnumerable<SourceType>> GetSourceTypes();
        Task<IEnumerable<State>> GetStates();
        Task<IEnumerable<StreetTypeT>> GetStreetTypes();
        Task<int> InsertOLPRRIncidentRecord(ApOLPRRInsertIncident apOLPRRInsertIncident);
        void InsertOLPRRLogEntry(OlprrLogEntry olprrLogEntry);
    }
}
