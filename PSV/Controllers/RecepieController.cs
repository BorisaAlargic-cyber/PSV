using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PSV.Model;
using PSV.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class RecepieController : DefaultController
    {
        [Authorize]
        [Route("/api/recepie/get-all")]
        [HttpGet]
        public PageResponse<Recepie> GetAllRecepies([FromQuery(Name = "page")] int page, [FromQuery(Name = "perPage")] int perPage, [FromQuery(Name = "search")] string search)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    return unitOfWork.Recepie.GetPage(new Pager(page, perPage, search));
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [Route("/api/recepie/get/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    Recepie recepie;
                    recepie = unitOfWork.Recepie.GetRecepieById(id);
                    
                }

            }
            catch(Exception e)
            {
                BadRequest();
            }

            return Ok();
        }
    }
}
