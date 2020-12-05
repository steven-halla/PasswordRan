using System;
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
//generate random lowercase letters a-z
//generate random uppercase letters A-Z
//generate random numbers 0-9
//create submit form
//create submit button
//have a counter that counts up per button click