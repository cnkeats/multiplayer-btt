using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlippiStats.Configuration;
using SlippiStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SlippiStats.Controllers
{
    public class APIController : ApplicationController
    {
        public APIController(ApplicationSettings settings, ApplicationDatabase database) : base(settings, database)
        {

        }
    }

    public class GameSubmitResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public int GameId { get; set; }
    }

    public class ReplaySubmitResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}