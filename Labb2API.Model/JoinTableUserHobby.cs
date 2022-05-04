using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Labb2API.Model
{

    public class JoinTableUserHobby
    {

        [Key]
        public int JoinId { get; set; }

        public int UserId { get; set; }
    
        public User user { get; set; }  

        public int HobbyId { get; set; }

        public Hobby Hobby { get; set; }
    }
}
