using DataLayerAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentationLayerAPI.Models;

namespace PresentationLayerAPI.Controllers
{
    [ApiController]
    public class MangaController : ControllerBase
    {
        [HttpPost]
        [Route("api/createRegisterMovil")]
        public ResponseMovil moviltoAPI([FromBody]RequestMovil request)
        {
            ResponseMovil response = new ResponseMovil();
            response.response = mangaRebyuDataManga.createRegisterManga(request.username, request.idManga, request.rating, request.coment);
            return response;
        }

        [HttpGet]
        [Route("api/sendDataMovil")]
        public ResponseSendDataMovil APItoMovil([FromQuery]RequestSendDataMovil request)
        {
            ResponseSendDataMovil response = new ResponseSendDataMovil();
            response.data = mangaRebyuDataManga.sendDataMovil(request.idManga);
            return response;
        }
    }
}
