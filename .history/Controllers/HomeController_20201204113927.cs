﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace passwordRan.Controllers
{
    
    public class passwordRan: Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }

}
//generate random lowercase letters
//generate random uppercase letters
//generate random numbers 0-9