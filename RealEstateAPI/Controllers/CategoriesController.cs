﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateAPI.Data;

namespace RealEstateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ApiDbContext _dbContext;
        public CategoriesController(ApiDbContext DbContext)
        {
            _dbContext = DbContext;
        }

        /*ApiDbContext _dbContext = new ApiDbContext();*/
        [HttpGet]
        //[Authorize]
        public IActionResult Get()
        {
            return Ok(_dbContext.Categories);
        }
        
    }
}
