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
    public class ApointmentController : DefaultController
    {
        [Authorize]
        [Route("/api/apointment/getApointment")]
        [HttpGet]
        public PageResponse<Apointment> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "perPage")] int perPage, [FromQuery(Name = "search")] string search)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    return unitOfWork.Apointment.GetPage(new Pager(page, perPage, search));
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [Route("/api/apointment/add")]
        [HttpPost]
        public async Task<IActionResult> CreateApointment(Apointment input)
        {
            Apointment apointment = null;

            apointment = new Apointment();
            apointment.Date = input.Date;
            User user = GetCurrentUser();
            apointment.Patient = user;
            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    unitOfWork.Apointment.Add(apointment);
                    unitOfWork.Complete();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok(apointment);
        }


    }
}
