using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Repository.Services.Abstarction;

namespace TOPFY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PostsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


    }
}
