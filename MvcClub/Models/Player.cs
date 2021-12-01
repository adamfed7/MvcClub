using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClub.Models
{
    public class Player
    {
        public int Id { get; set; }
        public byte Player_number { get; set; }
        public string First_name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public byte Matches { get; set; }
        public byte Yellow_cards { get; set; }
        public byte Red_cards { get; set; }
        public byte Goal { get; set; }
        public byte Assist { get; set; }

    }
}
