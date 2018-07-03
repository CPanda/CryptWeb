using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoWeb.Models;

namespace CryptoWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult vigenere()
        {
            Vigenere vg = new Vigenere();
            vg.encrypted = "Something is encrypted?";
            vg.decrypted = "Something decrypted "; 
            
            return View("vigenere", vg); 
        }

        [HttpPost]
        //create a new object on post, initialize, then add analysis options.. 
        public IActionResult vigenere(Vigenere vg)
        {
            vg.encrypted = Request.Form["encrypted"];  
            vg.decrypted = "hola";
            return View("vigenere", vg); 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}