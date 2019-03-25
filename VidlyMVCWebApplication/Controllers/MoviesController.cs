using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVCWebApplication.Models;
using VidlyMVCWebApplication.ViewModels;

namespace VidlyMVCWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movies=new Movie();         
            movies.Name="Shrek";
            movies.Id=1;

           List<Customer> Customers=new List<Customer>
           {
               new Customer{name="Customer 1"},
               new Customer{name="Customer 2"}
           };
           RandomMovieViewModel viewModel=new RandomMovieViewModel
           {
               movie=movies,
               customers=Customers
           };
            return View(viewModel);
        }

        public ActionResult Edit(int movieid,string Sample)
        {

            return Content(string.Format("id={0} and Sample={1}",movieid,Sample));
        }

        public ActionResult Index(int pageIndex, string sortBy)
        {

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(string.Format("pageIndex={0} &sortBY={1}", pageIndex, sortBy));
        }

        [Route("Movies/MoviesByReleaseYr/{Year}/{Month:regex(\\d{2}):range(1,12)}")]
        public ActionResult MoviesByReleaseYr(int? Year,int? Month)
        {
            if (!Year.HasValue)
            {
                Year = 0000;
            }

            if (!Month.HasValue)
            {
                Month = 01;
            }

            return Content(string.Format("{0}/{1}",Month,Year));
        }

    }
}