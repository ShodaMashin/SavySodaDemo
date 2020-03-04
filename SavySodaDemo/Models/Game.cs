using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavySodaDemo.Models
{
    public class Game
    {
        public int ID { get; set; }

        public String Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public String Genre { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
