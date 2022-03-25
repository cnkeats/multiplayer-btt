using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;
using SlippiStats.Controllers;

namespace MultiplayerBTT.Controllers.Character
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
            //viewModel.Entry = Entry.GetById(Database.Connection, id);

            /*if (viewModel.Entry == null)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }*/

            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
