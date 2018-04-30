using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using OlprrApi.Storage.Repositories;
using RequestDto = OlprrApi.Models.Request;
using ResponseDto = OlprrApi.Models.Response;
using EntityDto = OlprrApi.Storage.Entities;

namespace OlprrApi.Services
{
    public class OlprrReviewService : IOlprrReviewService
    {

        private ILogger<OlprrReviewService> _logger;
        private IOlprrRpository _lustRepository;
        private readonly IMapper _mapper;
        public OlprrReviewService(ILogger<OlprrReviewService> logger, IOlprrRpository lustRepository, IMapper mapper)
        {
            _logger = logger;
            _lustRepository = lustRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ResponseDto.LustSiteAddressSearch>> GetLustSearch(RequestDto.LustSiteAddressSearch lustSiteAddressSearch)
        {
            var searchFilters = _mapper.Map<RequestDto.LustSiteAddressSearch, EntityDto.LustSiteAddressSearch>(lustSiteAddressSearch);
            var resultList = new List<ResponseDto.LustSiteAddressSearch>();
            foreach (var result in await _lustRepository.GetLustSearch(searchFilters))
            {
                resultList.Add(_mapper.Map<EntityDto.ApOLPRRGetLustLookup, ResponseDto.LustSiteAddressSearch>(result));
            }
            return resultList;
        }
    }
}
