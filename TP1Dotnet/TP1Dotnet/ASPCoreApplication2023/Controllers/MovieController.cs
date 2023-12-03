using ASPCoreApplication2023.Models;
using ASPCoreApplication2023.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreApplication2023.Controllers
{
    public class MovieController : Controller
    {
    
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name =
            "movie 1"
            };
            List<Movie> movies = new List<Movie>()
                {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
                };
            return View(movies);
        }
        public IActionResult Edit(int id)
        {
            return Content("test /movie/edit/id= " + id); 
        }


        public IActionResult ByRelease(int month, int year)
        {
            return Content("Month " + month + " Year " + year);
        }

        public IActionResult Clients(int id)
        {
            var movie = new Movie()
            {
                Name = "Avanger : EndGame"
            };
            var customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Mehdi Fkih"},
                new Customer{ Id=2,Name="Mourad"},
                new Customer{Id=3,Name="Mariem"},
            };
            
            if (id != 0)
            {
                var clientFound = customers.Find(c => c.Id == id);

                if (clientFound ==null)
                {
                    return Content("There is no client with id = " + id);
                }
                var filmClient = new FilmClients()
                {
                    Movie = movie,
                    Customers = new List<Customer> { clientFound }
                };
                return View(filmClient);


            }   

            var filmClients = new FilmClients()
            {
                Movie = movie,
                Customers = customers
            };
            return View(filmClients);
        }
       


    }
}
