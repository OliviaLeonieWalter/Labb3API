using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb2API.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }   
        [Required]
        public string LastName { get; set; }    
        public string Phone { get; set; }  
        public DateTime Age { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Link> links { get; set; } 
        public virtual ICollection<JoinTableUserHobby> JoinTableUserHobbies { get; set; }
    }
}
