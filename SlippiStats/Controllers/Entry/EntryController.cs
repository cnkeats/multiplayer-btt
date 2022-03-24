using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;
using SlippiStats.Models;
using System;
using System.Collections.Generic;

namespace SlippiStats.Controllers
{
    public class EntryController : ApplicationController
    {
        public EntryController(ApplicationSettings settings, ApplicationDatabase database) : base(settings, database)
        {

        }

        public IActionResult List()
        {
            EntryListViewModel viewModel = new EntryListViewModel();

            //viewModel.Entries = Game.GetList(Database.Connection);
            viewModel.Entries = new List<Entry>();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult List(EntryListViewModel viewModel)
        {
            //viewModel.Entries = Game.GetListByFilters(Database.Connection, viewModel.PlayerFilter1, viewModel.PlayerFilter2, viewModel.CharacterFilter1, viewModel.CharacterFilter2, viewModel.StageFilter);
            viewModel.Entries = new List<Entry>();

            return View(viewModel);
        }

        [Route("{controller}/{id}")]
        public IActionResult Index(int id)
        {
            EntryIndexViewModel viewModel = new EntryIndexViewModel();
            viewModel.Entry = Entry.GetById(Database.Connection, id);

            if (viewModel.Entry == null)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View(viewModel);
        }

        [AllowAnonymous]
        public IActionResult Upload()
        {
            EntryUploadViewModel viewModel = new EntryUploadViewModel();

            return View(viewModel);
        }
    }
}
