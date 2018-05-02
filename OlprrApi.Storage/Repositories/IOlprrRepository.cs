using System.Collections.Generic;
using System.Threading.Tasks;
using OlprrApi.Storage.Entities;

namespace OlprrApi.Storage.Repositories
{
    public interface IOlprrRepository
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
        Task<int> InsertOLPRRIncidentRecord(ApOlprrInsertIncident apOLPRRInsertIncident);
        Task<IEnumerable<ApOlprrGetLustLookup>> GetApOLPRRGetLustLookup(LustSiteAddressSearch lustSiteAddressSearch);
        Task<ApOlprrGetIncidentById> ApOlprrGetIncidentById(int olprrId);

    }
}
