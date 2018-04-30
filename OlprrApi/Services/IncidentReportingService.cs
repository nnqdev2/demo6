using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EntityDto = OlprrApi.Storage.Entities;
using OlprrApi.Storage.Repositories;
using AutoMapper;
using OlprrApi.Models.Request;
using OlprrApi.Models.Response;

namespace OlprrApi.Services
{
    public class IncidentReportingService : IIncidentReportingService
    {
        private ILogger<IncidentReportingService> _logger;
        private IOlprrRpository _lustRepository;
        private readonly IMapper _mapper;
        public IncidentReportingService(ILogger<IncidentReportingService> logger, IOlprrRpository lustRepository, IMapper mapper)
        {
            _logger = logger;
            _lustRepository = lustRepository;
            _mapper = mapper;
        }



        //public async Task<int> InsertOLPRRIncidentRecord(ApOLPRRInsertIncident apOLPRRInsertIncident)
        public async Task<int> InsertOLPRRIncidentRecord(ApOLPRRInsertIncident apOLPRRInsertIncident)
        {
            var incident = _mapper.Map<ApOLPRRInsertIncident, EntityDto.ApOLPRRInsertIncident>(apOLPRRInsertIncident);
            var result = await _lustRepository.InsertOLPRRIncidentRecord(incident);
            return result;
        }

        private EntityDto.ApOLPRRInsertIncident BuildApOLPRRInsertIncident()
        {
            return new EntityDto.ApOLPRRInsertIncident
            {
                ErrNum = 99,
                ContractorUid = "DENNIS",
                ContractorPwd = "TERZIAN",
                ReportedBy = "Reported By",
                ReportedByPhone = "9991118888",
                ReportedByEmail = "test@test.com",
                ReleaseType = "H",
                DateReceived = DateTime.Now,
                FacilityId = 0,
                SiteName = "sitename",
                SiteCounty = "Washington",
                StreetNbr = "9999",
                StreetQuad = "Portland",
                StreetName = "Portland",
                StreetType = "Portland",
                SiteAddress = "Portland",
                SiteCity = "Portland",
                SiteZipcode = "11133",
                SitePhone = "1112223333",
                InitialComment = "test comment",
                DiscoveryDate = DateTime.Now,
                ConfirmationCode = "OT",
                DiscoveryCode = "OT",
                CauseCode = "OT",
                SourceId = 6,
                RpFirstName = "PORTLAND",
                RpLastName = "PORTLAND",
                RpOrganization = "PORTLAND",
                RpAddress = "PORTLAND",
                RpAddress2 = "PORTLAND",
                RpCity = "PORTLAND",
                RpState = "OR",
                RpZipcode = "97070",
                RpPhone = "1112223333",
                RpEmail = "test@gmail.com",
                IcFirstName = "11",
                IcLastName = "11",
                IcOrganization = "11",
                IcAddress = "11",
                IcAddress2 = "11",
                IcCity = "11",
                IcState = "or",
                IcZipcode = "97070",
                IcPhone = "1111111111",
                IcEmail = "t@t.com",
                GroundWater = 1,
                SurfaceWater = 1,
                DringkingWater = 1,
                Soil = 1,
                Vapor = 1,
                FreeProduct = 0,
                UnleadedGas = 1,
                LeadedGas = 1,
                MisGas = 1,
                Diesel = 1,
                WasteOil = 1,
                HeatingOil = 1,
                Lubricant = 1,
                Solvent = 1,
                OtherPet = 0,
                Chemical = 0,
                Unknown = 0,
                Mtbe = 0,
                SubmitDateTime = DateTime.Now.ToLocalTime().ToString(),
                DeqOffice = "NWR"
            };
        }

        public async Task<IEnumerable<ConfirmationType>> GetConfirmationTypes()
        {
            var resultList = new List<ConfirmationType>();
            foreach (var result in await _lustRepository.GetConfirmationTypes())
            {
                resultList.Add(_mapper.Map<EntityDto.ConfirmationType, ConfirmationType>(result));
            }
            return resultList;
        }

        public async Task<IEnumerable<County>> GetCounties()
        {
            var resultList = new List<County>();
            foreach (var result in await _lustRepository.GetCounties())
            {
                resultList.Add(_mapper.Map<EntityDto.County, County>(result));
            }
            return resultList;
        }

        public async Task<IEnumerable<DiscoveryType>> GetDiscoveryTypes()
        {
            var resultList = new List<DiscoveryType>();
            foreach (var result in await _lustRepository.GetDiscoveryTypes())
            {
                resultList.Add(_mapper.Map<EntityDto.DiscoveryType, DiscoveryType>(result));
            }
            return resultList;
        }

        public async Task<IEnumerable<QuadrantT>> GetQuadrants()
        {
            var resultList = new List<QuadrantT>();
            foreach (var result in await _lustRepository.GetQuadrants())
            {
                resultList.Add(_mapper.Map<EntityDto.QuadrantT, QuadrantT>(result));
            }
            return resultList;
        }

        public async Task<IEnumerable<ReleaseCauseType>> GetReleaseCauseTypes()
        {
            var resultList = new List<ReleaseCauseType>();
            foreach (var result in await _lustRepository.GetReleaseCauseTypes())
            {
                resultList.Add(_mapper.Map<EntityDto.ReleaseCauseType, ReleaseCauseType>(result));
            }
            return resultList;
        }
        public async Task<IEnumerable<SiteTypeT>> GetSiteTypes()
        {
            var resultList = new List<SiteTypeT>();
            foreach (var result in await _lustRepository.GetSiteTypes())
            {
                resultList.Add(_mapper.Map<EntityDto.SiteTypeT, SiteTypeT>(result));
            }
            return resultList;
        }
        public async Task<IEnumerable<SourceType>> GetSourceTypes()
        {
            var resultList = new List<SourceType>();
            foreach (var result in await _lustRepository.GetSourceTypes())
            {
                resultList.Add(_mapper.Map<EntityDto.SourceType, SourceType>(result));
            }
            return resultList;
        }

        public async Task<IEnumerable<State>> GetStates()
        {
            var resultList = new List<State>();
            foreach (var result in await _lustRepository.GetStates())
            {
                resultList.Add(_mapper.Map<EntityDto.State, State>(result));
            }
            return resultList;
        }

        public async Task<IEnumerable<StreetTypeT>> GetStreetTypes()
        {
            var resultList = new List<StreetTypeT>();
            foreach (var result in await _lustRepository.GetStreetTypes())
            {
                resultList.Add(_mapper.Map<EntityDto.StreetTypeT,StreetTypeT>(result));
            }
            return resultList;
        }

        public void InsertOLPRRLogEntry(OlprrLogEntry olprrLogEntry)
        {
            _logger.LogError(olprrLogEntry.Message);
        }
    }
}

