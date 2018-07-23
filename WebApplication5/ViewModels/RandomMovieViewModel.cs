using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;
namespace WebApplication5.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers{ get; set; }
    }
}