using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestionDocs.Models;
using GestionDocs.Data.Abstraction;
using GestionDocs.Service.Abstraction.Document;

namespace GestionDocs.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IDocumentService documentService;

        //public HomeController(IDocumentService documentService)
        //{
        //    this.documentService = documentService;
        //}

        public IActionResult Index()
        {
            /*await documentService.GetAllAsync()*/
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
