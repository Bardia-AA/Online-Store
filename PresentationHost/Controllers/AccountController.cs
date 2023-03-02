using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationHost.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Validate the form data (e.g. check if the username and password are correct)

            // If the form data is valid, log the user in and redirect to the home page
            // If the form data is invalid, display an error message and stay on the login page
            return View();

        }
        [HttpPost]
        public IActionResult SignUp(string username, string password, string confirmPassword)
        {
            // Validate the form data (e.g. check if the username is available, the password and confirm password match, etc.)

            // If the form data is valid, create a new account for the user and log them in
            // If the form data is invalid, display an error message and stay on the sign up page
            return View();

        }
    }
}