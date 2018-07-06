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
            return View("vigenere", vg); 
        }

        [HttpPost]
        //create a new object on post, initialize, then add analysis options.. 
        public IActionResult vg_encrypt(Vigenere vg)
        {
            vg.encrypted = "";
            //vg.encrypted = Request.Form["encrypted"];
            vg.decrypted = Request.Form["decrypted"]; 
            vg.key = Request.Form["key"];
            vg.processText();
            return View("vigenere", vg); 
        }

        [HttpPost]
        public IActionResult vg_decrypt(Vigenere vg)
        {
            vg.decrypted = "";
            vg.encrypted = Request.Form["encrypted"];
            vg.key = Request.Form["key"];
            vg.processText();
            return View("vigenere", vg);
        }

        public IActionResult Atbash()
        {
            Atbash at = new Atbash();
            return View("Atbash", at);
        }

        [HttpPost]
        public IActionResult at_encrypt(Atbash at)
        {
            at.encrypt(Request.Form["plaintext"]);
            return View("Atbash", at);
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