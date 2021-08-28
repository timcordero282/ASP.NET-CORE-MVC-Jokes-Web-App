using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokes_Web_App.Models
{
    public class Joke
    {
        public int ID { get; set; }
        public String JokeQuestion { get; set; }
        public String JokeAnswer{ get; set; }

        public Joke()
        {

        }

    }
}
