using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuleFun.Models;

namespace ModuleFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Message  message = new Message()
            {
                Context="Up to this point, when we've wanted to put any information on our html, we've added it to ViewBag. While this approach is okay for a piece of information here or there, a more robust approach is to use a ViewModel. Hopefully you've seen the value of a strictly-typed language, and ViewModels help us maintain that strict typing in our Views ",
            };
            // String message = "This message about my assingment ";
            return View(message);
        }

        [Route("numbers")]
        [HttpGet]
        public IActionResult ShowNumbers()
        {
            IntArr numbers = new IntArr()
            {
                 NumberArr =new int[] {1,2,4,5}
            };
            return View(numbers);
        }

        [Route("users")]
        [HttpGet]
        public IActionResult ShowUsers()
        {
            
            User anna= new User()
            {
                Firstname = "Anna",
                Lastname = "Koh"
            };
            User emma = new User()
            {
                Firstname = "Emma",
                Lastname = "Wood"
            };
            Users users = new Users();
            users.UserList.Add(anna);
            users.UserList.Add(emma);
            return View(users);
        }


    }
}
