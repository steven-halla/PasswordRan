﻿using System;
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
            Random rand = new Random();
            string holdString = "";
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //step 3 repeat step 1 until 14 characters exist in holdString var
            for(int i = 1; i <= 14; i++)
            {   
                //I need to randomly select 14 characters from the string of char and insert each random character into holdString var
                //step 1 randomly land on an nth element in string of char.
                int index = rand.Next(chars.Length);

                string character = chars[index].ToString();

                
                //step 2 insert nth element into holdString var
                holdString += character;
                
            }
            return View();
        }
        //this logic will take care of our click counter
        //we need to first set current click to 0 when the page is first visited
        //each time the button is clicked, add +1 to counter
        //
        [HttpGet]
        [Route("")]
        const string clickCountSessionkey = "clickscounted"
        public IActionResult NumOfClicks()
        {
            var model = new MyModel() {ClickCount = 0 };
            var previousClickCount = Session[clickCountSessionKey];
            if (previousClickCount != null)
            {
                model.ClickCount = (int)previousClickCount;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult ClickCounter(Passcode model)
        {
            model.ClickCount++;
            Session
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
//using System;

/* class Program {
    static void Main(string[] args) {
          Random rand = new Random();
            string holdString = "";
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //step 3 repeat step 1 until 14 characters exist in holdString var
            for(int i = 1; i <= 14; i++)
            {   
                //I need to randomly select 14 characters from the string of char and insert each random character into holdString var
                //step 1 randomly land on an nth element in string of char.
                int index = rand.Next(chars.Length);

                string character = chars[index].ToString();
                
                //step 2 insert nth element into holdString var
                holdString += character;
                
            }
            Console.WriteLine(holdString);
    }
} */