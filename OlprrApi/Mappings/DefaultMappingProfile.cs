using AutoMapper;

namespace OlprrApi.Mappings
{
    public class DefaultMappingProfile : Profile
    {
        public DefaultMappingProfile()
        {
            CreateMap<Storage.Entities.ConfirmationType, Models.Response.ConfirmationType>();
            CreateMap<Storage.Entities.County, Models.Response.County>();
            CreateMap<Storage.Entities.DiscoveryType, Models.Response.DiscoveryType>();
            CreateMap<Storage.Entities.QuadrantT, Models.Response.QuadrantT>();
            CreateMap<Storage.Entities.ReleaseCauseType, Models.Response.ReleaseCauseType>();
            CreateMap<Storage.Entities.SiteTypeT, Models.Response.SiteTypeT>();
            CreateMap<Storage.Entities.SourceType, Models.Response.SourceType>();
            CreateMap<Storage.Entities.State, Models.Response.State>();
            CreateMap<Storage.Entities.SiteTypeT, Models.Response.SiteTypeT>();
            CreateMap<Storage.Entities.StreetTypeT, Models.Response.StreetTypeT>();
            CreateMap<Models.Request.ApOLPRRInsertIncident, Storage.Entities.ApOLPRRInsertIncident>();
            CreateMap<Models.Request.LustSiteAddressSearch, Storage.Entities.LustSiteAddressSearch>();
            CreateMap<Storage.Entities.ApOLPRRGetLustLookup, Models.Response.LustSiteAddressSearch>();
        }
    }
}

