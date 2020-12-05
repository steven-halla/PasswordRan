using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace passwordRan.Controllers
{
    
    public class HomeController: Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("")]
        public IActionResult SummonRandomString()
        {
            Random rand = new Random();
            string randomString = "";
            string char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456"
        }
    }

}
//generate random lowercase letters a-z
//generate random uppercase letters A-Z
//generate random numbers 0-9
//create submit form
//create submit button
//have a counter that counts up per button click
//each time button is clicked re rout to main page
//set length to 14 characters
//should I put all characters under one list or create 3 seperate ones?
