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
        private IOlprrRepository _lustRepository;
        private readonly IMapper _mapper;
        public OlprrReviewService(ILogger<OlprrReviewService> logger, IOlprrRepository lustRepository, IMapper mapper)
        {
            _logger = logger;
            _lustRepository = lustRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ResponseDto.LustSiteAddressSearch>> SearchLust(RequestDto.LustSiteAddressSearch lustSiteAddressSearch)
        {
            var searchFilters = _mapper.Map<RequestDto.LustSiteAddressSearch, EntityDto.LustSiteAddressSearch>(lustSiteAddressSearch);
            var resultList = new List<ResponseDto.LustSiteAddressSearch>();
            foreach (var result in await _lustRepository.GetApOLPRRGetLustLookup(searchFilters))
            {
                resultList.Add(_mapper.Map<EntityDto.ApOlprrGetLustLookup, ResponseDto.LustSiteAddressSearch>(result));
            }
            return resultList;
        }

        public async Task<ResponseDto.IncidentById> GetIncidentById(int olprrId)
        {
            var result =  await _lustRepository.ApOlprrGetIncidentById(olprrId);
            return (_mapper.Map<EntityDto.ApOlprrGetIncidentById, ResponseDto.IncidentById>(result));
        }
    }
}
