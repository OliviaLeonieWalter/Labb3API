using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2API.Model
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get; set; }
        [Required]
        public string HobbyTitle { get; set; }
        [Required]
        public string HobbyDescription { get; set; }    

        public virtual ICollection<Link> Links { get; set; }
        public virtual ICollection<JoinTableUserHobby> JoinTableUserHobbies { get; set; }
    }
}
