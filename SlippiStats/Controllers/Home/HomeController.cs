using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;
using SlippiStats.Extensions;
using SlippiStats.GameDataEnums;
using SlippiStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SlippiStats.Controllers
{
    public class HomeController : ApplicationController
    {
        static Random rand = new Random();

        public HomeController(ApplicationSettings settings, ApplicationDatabase database)
            : base(settings, database)
        {

        }

        [AllowAnonymous]
        [Route("Random")]
        public IActionResult Random()
        {
            HomeRandomViewModel viewModel = new HomeRandomViewModel();

            List<Character> characterList = Enum.GetValues(typeof(Character)).Cast<Character>().Where(c => c.GetTournamentLegality()
                //&& ((int)c == 4 || (int)c == 20)
            ).ToList();

            List<Stage> stages = Enum.GetValues(typeof(Stage)).Cast<Stage>().Where(s => 
                s.GetStageCharacterAttribute() != Character.SANDBAG &&
                s.GetStageCharacterAttribute() != Character.SHEIK
                //&& (int)s == 42
            ).ToList();

            viewModel.Character1 = characterList[rand.Next(characterList.Count)];
            viewModel.Character2 = characterList[rand.Next(characterList.Count)];
            viewModel.Stage = stages[rand.Next(stages.Count)];

            viewModel.Highscore = Entry.GetHighscore(Database.Connection, viewModel.Character1, viewModel.Character2, viewModel.Stage);

            if (viewModel.Highscore != null)
            {
                viewModel.RecordTime = viewModel.FramesToTime(viewModel.Highscore.Frames);
            }

            return View(viewModel);
        }

        public IActionResult Index()
        {
            return RedirectToAction("Random", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}