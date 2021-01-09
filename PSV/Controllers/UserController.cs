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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : DefaultController
    {
        [Authorize]
        [Route("/api/users/get-current")]
        [HttpGet]
        public async Task<IActionResult> GetCurretUser()
        {
            return Ok(GetCurrentUser());
        }

        [Route("/api/users")]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(User inputData) {

            User user = null;

            if(inputData.Email == null || inputData.LastName == null || inputData.FirstName == null || inputData.Password == null)
            {
                return BadRequest();
            }

            user = new User();
            user.Email = inputData.Email;
            user.FirstName = inputData.FirstName;
            user.LastName = inputData.LastName;
            user.Password = inputData.Password;
            user.Role = "PATIENT";
            user.FirstTime = true;
            user.Deleted = false;

            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    unitOfWork.Users.Add(user);
                    unitOfWork.Complete();
                }
            } catch (Exception e)
            {
                return BadRequest();
            }

            return Ok(user);
        }
    }
}
