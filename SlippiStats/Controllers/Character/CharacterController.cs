using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;
using SlippiStats.Controllers;
using SlippiStats.Extensions;
using SlippiStats.GameDataEnums;
using SlippiStats.Models;

namespace MultiplayerBTT.Controllers
{
    public class CharacterController : ApplicationController
    {
        public CharacterController(ApplicationSettings settings, ApplicationDatabase database)
            : base(settings, database)
        {

        }

        public IActionResult List()
        {
            CharacterListViewModel viewModel = new CharacterListViewModel();

            //viewModel.Entries = Entry.GetList(Database.Connection);

            return View(viewModel);
        }

        [Route("{controller}/{id}")]
        public IActionResult Index(int id)
        {
            CharacterIndexViewModel viewModel = new CharacterIndexViewModel();
            viewModel.Character = (Character)id;
            viewModel.Entries = Entry.GetHighscoresByStage(Database.Connection, viewModel.Character.GetBTTStage());

            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
