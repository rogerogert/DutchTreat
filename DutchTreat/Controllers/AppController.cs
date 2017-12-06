﻿using DutchTreat.Services;
using DutchTreat.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController: Controller
    {
		private readonly IMailService _mailService;

		public AppController(IMailService mailService)
		{
			_mailService = mailService;
		}
        public IActionResult Index()
		{
			return View();
		}

		[HttpGet("contact")]
		public IActionResult Contact()
		{
			return View();
		}
		[HttpPost("contact")]
		public IActionResult Contact(ContactViewModel model)
		{
			if (ModelState.IsValid)
			{
				_mailService.SendMessage("rogerio@inspira.com.br", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
				ViewBag.UserMessage = "Mail Sent";
				ModelState.Clear();
			}
			
			return View();
		}
		public IActionResult About()
		{
			ViewBag.Title = "About";
			return View();
		}
    }
}
