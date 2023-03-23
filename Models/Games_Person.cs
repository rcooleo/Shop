using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Games_Person
    {
        public Guid GameId { get; set; }
        public Game Games { get; set; }
        public Guid PersonId { get; set; }
        public User Persons { get; set; }
    }
}
