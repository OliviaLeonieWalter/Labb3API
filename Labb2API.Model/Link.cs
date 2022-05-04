using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2API.Model
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; } 
        public string LinkUrl { get; set; }
        public string LinkDescription { get; set; }

        public int HobbyId { get; set; }    
        public Hobby Hobby { get; set; }

        public int UserId { get; set; } 
        public User User { get; set; }

    }
}
