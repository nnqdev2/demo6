using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using OlprrApi.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System;
using OlprrApi.Common.Exceptions;
using Newtonsoft.Json;

namespace OlprrApi.Storage.Repositories
{
    public class OlprrRepository : IOlprrRpository
    {
        public const string ExecuteApGetOLPRRLookupTables = "execute dbo.apGetOLPRRLookupTables {0}";
        public const string ConfirmationTypeTable = "ConfirmationType";
        public const string CountiesTable = "Counties";
        public const string DiscoveryTypeTable = "DiscoveryType";
        public const string QuadrantTable = "Quadrant";
        public const string ReleaseCauseTypeTable = "ReleaseCauseType";
        public const string SiteTypeTable = "SiteType";
        public const string SourceTypeTable = "SourceType";
        public const string StatesTable = "States";
        public const string StreetTypeTable = "StreetType";

        private LustDbContext _dbContext;
        private ILogger<OlprrRepository> _logger;
        public OlprrRepository(ILogger<OlprrRepository> logger, LustDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IEnumerable<ConfirmationType>> GetConfirmationTypes()
        {
            return await _dbContext.Set<ConfirmationType>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, ConfirmationTypeTable).ToListAsync();
        }

        public async Task<IEnumerable<County>> GetCounties()
        {
            return await _dbContext.Set<County>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, CountiesTable).ToListAsync();
        }

        public async Task<IEnumerable<DiscoveryType>> GetDiscoveryTypes()
        {
            return await _dbContext.Set<DiscoveryType>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, DiscoveryTypeTable).ToListAsync();
        }
        public async Task<IEnumerable<QuadrantT>> GetQuadrants()
        {
            return await _dbContext.Set<QuadrantT>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, QuadrantTable).ToListAsync();
        }
        public async Task<IEnumerable<ReleaseCauseType>> GetReleaseCauseTypes()
        {
            return await _dbContext.Set<ReleaseCauseType>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, ReleaseCauseTypeTable).ToListAsync();
        }
        public async Task<IEnumerable<SiteTypeT>> GetSiteTypes()
        {
            return await _dbContext.Set<SiteTypeT>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, SiteTypeTable).ToListAsync();
        }
        public async Task<IEnumerable<SourceType>> GetSourceTypes()
        {
            return await _dbContext.Set<SourceType>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, SourceTypeTable).ToListAsync();
        }
        public async Task<IEnumerable<State>> GetStates()
        {
            return await _dbContext.Set<State>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, StatesTable).ToListAsync();
        }
        public async Task<IEnumerable<StreetTypeT>> GetStreetTypes()
        {
            return await _dbContext.Set<StreetTypeT>().AsNoTracking().FromSql(ExecuteApGetOLPRRLookupTables, StreetTypeTable).ToListAsync();
        }
        public async Task<int> InsertOLPRRIncidentRecord(ApOLPRRInsertIncident apOLPRRInsertIncident)
        {
            var result = await _dbContext.Database.ExecuteSqlCommandAsync("execute dbo.apOLPRRInsertIncident " +
            "  @ErrNum ,@CONTRACTOR_UID, @CONTRACTOR_PWD, @REPORTED_BY, @REPORTED_BY_PHONE,  @REPORTED_BY_EMAIL, @RELEASE_TYPE, @DATE_RECEIVED,@FACILITY_ID, @SITE_NAME,@SITE_COUNTY" +
            ", @STREET_NBR, @STREET_QUAD,@STREET_NAME,@STREET_TYPE,@SITE_ADDRESS,@SITE_CITY,@SITE_ZIPCODE,@SITE_PHONE, @INITIAL_COMMENT, @DISCOVERY_DATE, @CONFIRMATION_CODE" +
            ", @DISCOVERY_CODE,@CAUSE_CODE,@SOURCEID,@RP_FIRSTNAME,@RP_LASTNAME,@RP_ORGANIZATION,@RP_ADDRESS,@RP_ADDRESS2,@RP_CITY,@RP_STATE,@RP_ZIPCODE,@RP_PHONE,@RP_EMAIL" +
            ", @IC_FIRSTNAME,@IC_LASTNAME,@IC_ORGANIZATION,@IC_ADDRESS,@IC_ADDRESS2,@IC_CITY,@IC_STATE,@IC_ZIPCODE,@IC_PHONE,@IC_EMAIL" +
            ", @GROUNDWATER,@SURFACEWATER,@DRINKINGWATER,@SOIL,@VAPOR,@FREEPRODUCT,@UNLEADEDGAS,@LEADEDGAS,@MISGAS,@DIESEL,@WASTEOIL,@HEATINGOIL,@LUBRICANT,@SOLVENT" +
            ", @OTHERPET,@CHEMICAL,@UNKNOWN,@MTBE,@SUBMIT_DATETIME,@DEQ_OFFICE", BuildSqlParams(apOLPRRInsertIncident));
            return result;
        }

        private IEnumerable<SqlParameter> BuildSqlParams(ApOLPRRInsertIncident apOLPRRInsertIncident)
        {
            IList<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter { ParameterName = "@ErrNum", SqlDbType = SqlDbType.SmallInt, Direction = ParameterDirection.Output });
            list.Add(new SqlParameter("@CONTRACTOR_UID", apOLPRRInsertIncident.ContractorUid));
            list.Add(new SqlParameter("@CONTRACTOR_PWD", apOLPRRInsertIncident.ContractorPwd));
            list.Add(new SqlParameter("@REPORTED_BY", apOLPRRInsertIncident.ReportedBy));
            list.Add(new SqlParameter("@REPORTED_BY_PHONE", apOLPRRInsertIncident.ReportedByPhone));
            list.Add(new SqlParameter("@REPORTED_BY_EMAIL", apOLPRRInsertIncident.ReportedByEmail));
            list.Add(new SqlParameter("@RELEASE_TYPE", apOLPRRInsertIncident.ReleaseType));
            list.Add(new SqlParameter("@DATE_RECEIVED", apOLPRRInsertIncident.DateReceived));
            list.Add(new SqlParameter("@FACILITY_ID", apOLPRRInsertIncident.FacilityId));
            list.Add(new SqlParameter("@SITE_NAME", apOLPRRInsertIncident.SiteName));
            list.Add(new SqlParameter("@SITE_COUNTY", apOLPRRInsertIncident.SiteCounty));
            list.Add(new SqlParameter("@STREET_NBR", apOLPRRInsertIncident.StreetNbr));
            list.Add(new SqlParameter("@STREET_QUAD", apOLPRRInsertIncident.StreetQuad));
            list.Add(new SqlParameter("@STREET_NAME", apOLPRRInsertIncident.StreetName));
            list.Add(new SqlParameter("@STREET_TYPE", apOLPRRInsertIncident.StreetType));
            list.Add(new SqlParameter("@SITE_ADDRESS", apOLPRRInsertIncident.SiteAddress));
            list.Add(new SqlParameter("@SITE_CITY", apOLPRRInsertIncident.SiteCity));
            list.Add(new SqlParameter("@SITE_ZIPCODE", apOLPRRInsertIncident.SiteZipcode));
            list.Add(new SqlParameter("@SITE_PHONE", apOLPRRInsertIncident.SitePhone));
            list.Add(new SqlParameter("@INITIAL_COMMENT", apOLPRRInsertIncident.InitialComment));
            list.Add(new SqlParameter("@DISCOVERY_DATE", apOLPRRInsertIncident.DiscoveryDate));
            list.Add(new SqlParameter("@CONFIRMATION_CODE", apOLPRRInsertIncident.ConfirmationCode));
            list.Add(new SqlParameter("@DISCOVERY_CODE", apOLPRRInsertIncident.DiscoveryCode));
            list.Add(new SqlParameter("@CAUSE_CODE", apOLPRRInsertIncident.CauseCode));
            list.Add(new SqlParameter("@SOURCEID", apOLPRRInsertIncident.SourceId));
            list.Add(new SqlParameter("@RP_FIRSTNAME", apOLPRRInsertIncident.RpFirstName));
            list.Add(new SqlParameter("@RP_LASTNAME", apOLPRRInsertIncident.RpLastName));
            list.Add(new SqlParameter("@RP_ORGANIZATION", apOLPRRInsertIncident.RpOrganization));
            list.Add(new SqlParameter("@RP_ADDRESS", apOLPRRInsertIncident.RpAddress));
            list.Add(new SqlParameter("@RP_ADDRESS2", apOLPRRInsertIncident.RpAddress2));
            list.Add(new SqlParameter("@RP_CITY", apOLPRRInsertIncident.RpCity));
            list.Add(new SqlParameter("@RP_STATE", apOLPRRInsertIncident.RpState));
            list.Add(new SqlParameter("@RP_ZIPCODE", apOLPRRInsertIncident.RpZipcode));
            list.Add(new SqlParameter("@RP_PHONE", apOLPRRInsertIncident.RpPhone));
            list.Add(new SqlParameter("@RP_EMAIL", apOLPRRInsertIncident.RpEmail));
            list.Add(new SqlParameter("@IC_FIRSTNAME", apOLPRRInsertIncident.IcFirstName));
            list.Add(new SqlParameter("@IC_LASTNAME", apOLPRRInsertIncident.IcLastName));
            list.Add(new SqlParameter("@IC_ORGANIZATION", apOLPRRInsertIncident.IcOrganization));
            list.Add(new SqlParameter("@IC_ADDRESS", apOLPRRInsertIncident.IcAddress));
            list.Add(new SqlParameter("@IC_ADDRESS2", apOLPRRInsertIncident.IcAddress2));
            list.Add(new SqlParameter("@IC_CITY", apOLPRRInsertIncident.IcCity));
            list.Add(new SqlParameter("@IC_STATE", apOLPRRInsertIncident.IcState));
            list.Add(new SqlParameter("@IC_ZIPCODE", apOLPRRInsertIncident.IcZipcode));
            list.Add(new SqlParameter("@IC_PHONE", apOLPRRInsertIncident.IcPhone));
            list.Add(new SqlParameter("@IC_EMAIL", apOLPRRInsertIncident.IcEmail));
            list.Add(new SqlParameter("@GROUNDWATER", apOLPRRInsertIncident.GroundWater));
            list.Add(new SqlParameter("@SURFACEWATER", apOLPRRInsertIncident.SurfaceWater));
            list.Add(new SqlParameter("@DRINKINGWATER", apOLPRRInsertIncident.DringkingWater));
            list.Add(new SqlParameter("@SOIL", apOLPRRInsertIncident.Soil));
            list.Add(new SqlParameter("@VAPOR", apOLPRRInsertIncident.Vapor));
            list.Add(new SqlParameter("@FREEPRODUCT", apOLPRRInsertIncident.FreeProduct));
            list.Add(new SqlParameter("@UNLEADEDGAS", apOLPRRInsertIncident.UnleadedGas));
            list.Add(new SqlParameter("@LEADEDGAS", apOLPRRInsertIncident.LeadedGas));
            list.Add(new SqlParameter("@MISGAS", apOLPRRInsertIncident.MisGas));
            list.Add(new SqlParameter("@DIESEL", apOLPRRInsertIncident.Diesel));
            list.Add(new SqlParameter("@WASTEOIL", apOLPRRInsertIncident.WasteOil));
            list.Add(new SqlParameter("@HEATINGOIL", apOLPRRInsertIncident.HeatingOil));
            list.Add(new SqlParameter("@LUBRICANT", apOLPRRInsertIncident.Lubricant));
            list.Add(new SqlParameter("@SOLVENT", apOLPRRInsertIncident.Solvent));
            list.Add(new SqlParameter("@OTHERPET", apOLPRRInsertIncident.OtherPet));
            list.Add(new SqlParameter("@CHEMICAL", apOLPRRInsertIncident.Chemical));
            list.Add(new SqlParameter("@UNKNOWN", apOLPRRInsertIncident.Unknown));
            list.Add(new SqlParameter("@MTBE", apOLPRRInsertIncident.Mtbe));
            list.Add(new SqlParameter("@SUBMIT_DATETIME", apOLPRRInsertIncident.SubmitDateTime));
            list.Add(new SqlParameter("@DEQ_OFFICE", apOLPRRInsertIncident.DeqOffice));
            IEnumerable<SqlParameter> myParams = list;
            return myParams;
        }

        //public async Task<IEnumerable<ApOLPRRGetLustLookup>> GetApOLPRRGetLustLookups(Dto.LustSiteAddressSearch lustSiteAddressSearch)
        public async Task GetApOLPRRGetLustLookups(LustSiteAddressSearch lustSiteAddressSearch)
        {

            lustSiteAddressSearch.SiteAddress = "";
            lustSiteAddressSearch.SiteName = "";
            lustSiteAddressSearch.SiteZip = "97229";
            int spResult = 9999;
            IList<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@SiteName", lustSiteAddressSearch.SiteName));
            list.Add(new SqlParameter("@SiteAddress", lustSiteAddressSearch.SiteAddress));
            list.Add(new SqlParameter("@SiteCity", lustSiteAddressSearch.SiteCity));
            list.Add(new SqlParameter("@SiteZip", lustSiteAddressSearch.SiteZip));
            list.Add(new SqlParameter("@OrderBy", lustSiteAddressSearch.OrderBy));
            list.Add(new SqlParameter { ParameterName = "@Result", SqlDbType = SqlDbType.SmallInt, Direction = ParameterDirection.Output, Value = spResult });

            IEnumerable<SqlParameter> myParams = list;


            
            var result = await _dbContext.Database.ExecuteSqlCommandAsync("execute dbo.apOLPRRGetLustLookup " +
                "  @SiteName, @SiteAddress, @SiteCity, @SiteZip,  @OrderBy, @Result OUTPUT", myParams);

            var test = spResult;


            //var sql = "exec spTestSp @ParamIn1, @ParamIn2, @ParamOut1 OUT, @ParamOut2 OUT";
            //var result = db.Database.ExecuteSqlCommand(sql, in1, in2, out1, out2);

            //var out1Value = (long)out1.Value;
            //var out2Value = (string)out2.Value;
        }

        public async Task<IEnumerable<ApOLPRRGetLustLookup>> GetLustSearch(LustSiteAddressSearch lustSiteAddressSearch)
        {

            var siteNameParam = new SqlParameter("@SiteName", lustSiteAddressSearch.SiteName);
            var siteAddressParam = new SqlParameter("@SiteAddress", lustSiteAddressSearch.SiteAddress);
            var siteCityParam = new SqlParameter("@SiteCity", lustSiteAddressSearch.SiteCity);
            var siteZipParam= new SqlParameter("@SiteZip", lustSiteAddressSearch.SiteZip);
            var orderByParam = new SqlParameter("@OrderBy", lustSiteAddressSearch.OrderBy);
            var resultOutParam = new SqlParameter { ParameterName = "@Result", SqlDbType = SqlDbType.SmallInt, Direction = ParameterDirection.Output };

            if (siteNameParam.Value == null)
                siteNameParam.Value = DBNull.Value;
            if (siteAddressParam.Value == null)
                siteAddressParam.Value = DBNull.Value;
            if (siteCityParam.Value == null)
                siteCityParam.Value = DBNull.Value;
            if (siteZipParam.Value == null)
                siteZipParam.Value = DBNull.Value;

            const string ExecuteApOLPRRGetLustLookup = "execute dbo.apOLPRRGetLustLookup @SiteName, @SiteAddress, @SiteCity" +
                ", @SiteZip, @OrderBy, @Result OUTPUT";

            var result = await _dbContext.Set<ApOLPRRGetLustLookup>().AsNoTracking().FromSql(ExecuteApOLPRRGetLustLookup
                , siteNameParam, siteAddressParam, siteCityParam, siteZipParam, orderByParam, resultOutParam).ToListAsync();

            var resultCode = (Int16)(resultOutParam.Value);

            if (resultCode == 0)
            {
                var json = JsonConvert.SerializeObject(lustSiteAddressSearch);
                var errorMsg = $"{ExecuteApOLPRRGetLustLookup} returned status code = {resultCode}. Post payload {json}.";
                _logger.LogError(errorMsg);
                throw new StoreProcedureNonZeroOutputParamException(errorMsg);
            } 

            return result;

            //https://stackoverflow.com/questions/18510901/return-multiple-recordsets-from-stored-proc-in-c-sharp
            //https://stackoverflow.com/questions/43688324/why-does-ef-core-always-return-1-with-this-stored-procedure
            //https://stackoverflow.com/questions/45252959/entity-framework-core-using-stored-procedure-with-output-parameters
        }

    }
}
