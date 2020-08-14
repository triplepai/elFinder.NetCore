﻿using Microsoft.AspNetCore.Mvc;

namespace FileUploader.Controllers
{
    [Route("tiny-mce")]
    public class TinyMCEController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("browse")]
        public IActionResult Browse()
        {
            return View();
        }
    }
}