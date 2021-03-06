﻿using Microsoft.AspNetCore.Authorization;
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
    public class FeedbackController : DefaultController
    {
        [Authorize]
        [Route("/api/feedbacks/all")]
        [HttpGet]
        public PageResponse<Feedback> GetAll([FromQuery(Name = "page")] int page, [FromQuery(Name = "perPage")] int perPage, [FromQuery(Name = "search")] string search)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    return unitOfWork.Feedback.GetPage(new Pager(page, perPage, search));
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [Authorize]
        [Route("/api/feedbacks/all-pubished")]
        [HttpGet]
        public PageResponse<Feedback> GetAllPublished([FromQuery(Name = "page")] int page, [FromQuery(Name = "perPage")] int perPage, [FromQuery(Name = "search")] string search)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    return unitOfWork.Feedback.GetPagePublished(new Pager(page, perPage, search));
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [Route("/api/feedbacks/{id}")]
        [HttpPut]
        public async Task<IActionResult> Publish(int id)
        {
            Feedback feedback = null;

            try {

                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    feedback = unitOfWork.Feedback.Get(id);
                    feedback.Published = true;
                    unitOfWork.Complete();
                }

            } catch (Exception e)
            {
                return BadRequest();
            }

            return Ok(feedback);
        }

        [Route("/api/feedbacks/dontPublish/{id}")]
        [HttpPut]

        public async Task<IActionResult> DontPublish(int id)
        {
            Feedback feedback = null;
            try
            {
                using(var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    feedback = unitOfWork.Feedback.Get(id);
                    feedback.Published = false;
                    unitOfWork.Complete();
                }
            }catch(Exception e)
            {
                return BadRequest();
            }

            return Ok(feedback);
        }

        [Route("/api/feedbacks")]
        [HttpPost]
        public async Task<IActionResult>  CreateFeedback (Feedback input)
        {
            Feedback feedback = null;

            if(input.Comment == null)
            {
                return BadRequest();
            }

            feedback = new Feedback();
            feedback.Comment = input.Comment;
            feedback.Published = false;
            feedback.Deleted = false;
            User user = GetCurrentUser();
            feedback.Patient = user;
            try 
            {
                using (var unitOfWork = new UnitOfWork(new ModelContext()))
                {
                    unitOfWork.Feedback.Add(feedback);
                    unitOfWork.Complete();
                }
            }catch(Exception e)
            {
                return BadRequest();
            }
            return Ok(feedback);
        }

        
    }
}
