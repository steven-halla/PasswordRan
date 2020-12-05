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
            string holdString = "";
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //step 3 repeat step 1 until 14 characters exist in holdString var
            for(int i = 1; i <= 14; i++)
            {   
                //I need to randomly select 14 characters from the string of char and insert each random character into holdString var
                //step 1 randomly land on an nth element in string of char.
                int index = rand.Next(char.Length);

                chars[index]
                string char 
                //step 2 insert nth element into holdString var
                holdString += char 
                
            }
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
