using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;
using SlippiStats.Models;
using System;
using System.Collections.Generic;

namespace SlippiStats.Controllers
{
    [AllowAnonymous]
    public class EntryController : ApplicationController
    {
        public EntryController(ApplicationSettings settings, ApplicationDatabase database) : base(settings, database)
        {

        }

        public IActionResult List()
        {
            EntryListViewModel viewModel = new EntryListViewModel();

            viewModel.Entries = Entry.GetList(Database.Connection);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult List(EntryListViewModel viewModel)
        {
            //viewModel.Entries = Game.GetListByFilters(Database.Connection, viewModel.PlayerFilter1, viewModel.PlayerFilter2, viewModel.CharacterFilter1, viewModel.CharacterFilter2, viewModel.StageFilter);
            viewModel.Entries = Entry.GetList(Database.Connection);

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

        public IActionResult Submit()
        {
            EntrySubmitViewModel viewModel = new EntrySubmitViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Submit(EntrySubmitViewModel viewModel)
        {
            Player player1 = Player.GetByPlayerName(Database.Connection, viewModel.Player1.Trim());

            if (player1 == null)
            {
                player1 = new Player();
                player1.Name = viewModel.Player1.Trim();
                player1.Save(Database.Connection);
            }

            Player player2 = null;
            if (viewModel.Player2.Trim().Length > 0)
            {

                player2 = Player.GetByPlayerName(Database.Connection, viewModel.Player2.Trim());

                if (player2 == null)
                {
                    player2 = new Player();
                    player2.Name = viewModel.Player2.Trim();
                    player2.Save(Database.Connection);
                }
            }

            Entry entry = new Entry();
            entry.Character1 = viewModel.Character1;
            entry.Character2 = viewModel.Character2;
            entry.Player1Id = player1.Id;
            entry.Player2Id = player2.Id;
            entry.Stage = viewModel.Stage;
            entry.Frames = viewModel.Frames;
            entry.TargetsRemaining = viewModel.TargetsRemaining;
            entry.DateRun = viewModel.DateRun;
            entry.Platform = viewModel.Platform;
            entry.VideoURL = viewModel.VideoURL;
            entry.Save(Database.Connection);

            return View(viewModel);
        }
    }
}
