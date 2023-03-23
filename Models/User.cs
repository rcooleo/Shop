using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string UserEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string UserPassword { get; set; }
        public List<Games_Person> OwnedGames { get; set; }

    }
}
