﻿using System.Collections.Generic;
using System.Threading.Tasks;
using RequestDto = OlprrApi.Models.Request;
using ResponseDto = OlprrApi.Models.Response;

namespace OlprrApi.Services
{
    public interface IOlprrReviewService
    {
        Task<IEnumerable<ResponseDto.LustSiteAddressSearch>> SearchLust(RequestDto.LustSiteAddressSearch lustSiteAddressSearch);
        Task<ResponseDto.IncidentById> GetIncidentById(int olprrId);
    }
}
