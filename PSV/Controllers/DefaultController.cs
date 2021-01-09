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
    public class DefaultController : ControllerBase
    {

        protected User GetCurrentUser()
        {
            string email = HttpContext.User.Claims.FirstOrDefault(u => u.Type == "Email")?.Value;

            User user = null;

            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    user = unitOfWork.Users.GetUserWithEmail(email);
                }
            }
            catch (Exception e)
            {

            }

            return user;
        }
    }
}
