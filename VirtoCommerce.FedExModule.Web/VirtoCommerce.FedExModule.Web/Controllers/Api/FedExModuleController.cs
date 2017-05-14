using System.Web.Http;

namespace VirtoCommerce.FedExModule.Web.Controllers.Api
{
    [RoutePrefix("api/fedExModule")]
    public class FedExModuleController : ApiController
    {
        // GET: api/fedExModule
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new { result = "Hello world!" });
        }
    }
}