using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SavySodaDemo.Models;
using SavySodaDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SavySodaDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private RazorPagesGameContext gameContext; 
        
        public GameController(RazorPagesGameContext gc)
        {
            gameContext = gc;
        }

        [HttpGet]
        public IList<Game> Get()
        {
            
            var gameSet = gameContext.Game;
            var gameList = new List<Game>();

            foreach (Game g in gameSet)
            {
                gameList.Add(g);
            }

            return gameList;
        }
    }
}