using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Interfaces.Services.Test;
using PetEShopWebMVC.Models;

using Microsoft.AspNetCore.Identity;



namespace PetEShopWebMVC.Controllers
{



    [Route("test")]
    public class TestController : Controller
    {



        private readonly ILogger<TestController> logger;

        private readonly IUserService userService;

        private readonly IPersonService personService;

        private readonly IAuthService authService;

        private readonly SignInManager<IdentityUser> signInManager;



        public TestController(ILogger<TestController> logger, IUserService userService, IPersonService personService, IAuthService authService, SignInManager<IdentityUser> signInManager)
        {
            this.logger = logger;
            this.userService = userService;
            this.personService = personService;
            this.authService = authService;
            this.signInManager = signInManager;
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}



        //// GET /Test/Cars
        //public IActionResult Cars()
        //{
        //    List<Car> cars = new List<Car>();
        //    cars.Add(new Car("Skoda", "Octavia"));
        //    cars.Add(new Car("Skoda", "Fabia"));
        //    cars.Add(new Car("Mercedes", "S-class"));
        //    return View(new CarModel { Cars = cars });
        //}



        //// GET /Test/Cars
        //public IActionResult Cars()
        //{
        //    List<Car> cars = new List<Car>();
        //    cars.Add(new Car("Skoda", "Octavia"));
        //    cars.Add(new Car("Skoda", "Fabia"));
        //    cars.Add(new Car("Mercedes", "S-class"));
        //    return View(new CarModel { Cars = cars });
        //}


        // GET /Test/Cars
        public IActionResult GetCars()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Skooooooda", "Octavia"));
            cars.Add(new Car("Skoda", "Fabia"));
            cars.Add(new Car("Mercedes", "S-class"));
            return View("Car", new CarModel { Cars = cars });
        }



        //public IActionResult RegisterNewUser([FromForm(Name = "formRegister")] User user)
        [HttpPost("register")]
        public IActionResult RegisterNewUser([FromForm] User user)
        {
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Email);
            return new OkResult();
        }




        // POST /test/login
        [HttpPost("login")]
        public IActionResult LoginUser([FromForm] Login login)
        {
            Console.WriteLine($"Username: {login.Username}    Password: {login.Password}");
            if (login.Username != login.Password)
            {
                return new NotFoundResult();
            }
            return new OkResult();
        }



        // GET /test/edit-user
        [HttpGet("edit-user")] 
        public IActionResult EditUser()
        {
            return View("/Views/Test/EditUser.cshtml", new User());
        }


        // POST /test/edit-user
        [HttpPost("edit-user")]
        public IActionResult SaveUser([FromForm] User user)
        {
            Console.WriteLine($"Username: {user.Username}    Email: {user.Email}");

            this.userService.SaveUser(user);

            //return new OkResult();
            //return this.Response.Redirect("");
            return RedirectToAction("list-users");
        }




        // GET /test/list-users
        [HttpGet("list-users")]
        public IActionResult GetUsers()
        {
            ICollection<User> users = this.userService.GetAllUsers();
            return View("/Views/Test/UserList.cshtml", new UserListModel { Users = users });
        }




        // POST /test/save-person
        [HttpPost("save-person")]
        public IActionResult SavePerson([FromForm] Person person)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            this.personService.SavePerson(person);

            return new OkResult();
        }




        // GET /test/edit-person
        [HttpGet("edit-person")]
        public IActionResult EditPerson()
        {
            return View("/Views/Test/EditPerson.cshtml", new Person());
        }



        // POST /test/edit-person
        [HttpPost("edit-person")]
        public IActionResult ProcessPerson([FromForm] Person person)
        {
            Console.WriteLine($"Name: {person.Name}    Age: {person.Age}");

            this.personService.SavePerson(person);

            return new OkResult();
        }



        // GET /test/identity-users/list
        [HttpGet("identity-users/list")]
        public IActionResult ListIdentityUsers()
        {
            ICollection<IdentityUser> identityUsers = this.authService.GetIdentityUsers();

            return View("IdentityUsersList", new IdentityUsersListModel { IdentityUsers = identityUsers });
        }



        // GET /test/auth/signed
        [HttpGet("auth/signed")]
        public IActionResult GetSignedInUser()
        {
            //SignInManager<IdentityUser> signInManager = new SignInManager<IdentityUser>();
            //this.Si
            if (this.signInManager.IsSignedIn(this.User))
            {
                //return new OkResult();
                return new OkObjectResult(this.User.Identity.Name);
            }

            //return new UnauthorizedResult();
            return new UnauthorizedObjectResult("anonymous");
        }



        // GET /test/auth-users
        [HttpGet("auth-users")]
        public IActionResult ShowIdentityUsers()
        {
            IList<IdentityUser> identityUsers = this.authService.GetIdentityUsers();

            return View("IdentityUsers", new IdentityUsersListModel { IdentityUsers = identityUsers });
        }



        // GET /test/list-person
        [HttpGet("list-person")]
        public IActionResult ListPersons()
        {

            IList<Person> persons = this.personService.GetPersons();

            return View("PersonList", new PersonListModel { Persons = persons });

        }



        // GET /test/load-person/1
        [HttpGet("load-person/{id:int}")]
        public IActionResult LoadPerson([FromRoute] int id)
        {

            Person person = this.personService.GetPerson(id);

            return View("LoadPerson", person);

        }


        // POST /test/load-person/1
        [HttpPost("load-person/{id:int}")]
        //[HttpPost("/Test/LoadPerson")]
        public IActionResult StorePerson([FromRoute] int id, [FromForm] Person person)
        {
            //if ( ! ModelState.IsValid )
            //{
            //    return View("LoadPerson", person);
            //}

            this.personService.SavePerson(person);

            return Redirect("/test/list-person");

        }



        // GET /test/list-user
        [HttpGet("list-user")]
        public IActionResult ListUsers()
        {
            IList<User> users = this.userService.GetAllUsers();

            return View("UsersList", new UsersListModel { Users = users });
        }



        // GET /test/load-user/2
        [HttpGet("load-user/{id:int}")]
        public IActionResult LoadUser([FromRoute] int id)
        {
            User user = this.userService.GetUser(id);

            return View("LoadUser", user);

        }


        // POST /test/load-user/2
        [HttpPost("load-user/{id:int}")]
        public IActionResult StoreUser([FromRoute] int id, [FromForm] User user)
        {
            this.userService.SaveUser(user);

            //return new OkResult;
            return Redirect("/test/list-user");
        }



    }



}
