using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OlprrApi.Services;

namespace OlprrApi.Controllers
{
    //[EnableCors("AllowSpecificOrigin")]
    [EnableCors("AllowAllHeaders")]
    [Produces("application/json")]
    //[Route("api/Review")]
    [Route("review")]
    public class ReviewController : Controller
    {
        private readonly ILogger<ReviewController> _logger;
        private readonly IOlprrReviewService _olprrReviewService;

        public ReviewController(ILogger<ReviewController> logger, IOlprrReviewService olprrReviewService)
        {
            _logger = logger;
            _olprrReviewService = olprrReviewService;
        }

        [Route("lustsearch")]
        [HttpPost]
        public async Task<IActionResult> LustSearch([FromBody] Models.Request.LustSiteAddressSearch lustSiteAddressSearch)
        {
            //https://stackoverflow.com/questions/14202257/design-restful-query-api-with-a-long-list-of-query-parameters
            var x =  await _olprrReviewService.GetLustSearch(lustSiteAddressSearch);
            return Ok( x);
        }

    }
}