using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xo.Core.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string PlayerOne { get; set; }
        public int PlayerOneScore { get; set; }
        public string PlayerTwo { get; set; }
        public int PlayerTwoScore { get; set; }
    }
}
