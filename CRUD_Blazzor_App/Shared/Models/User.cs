using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Blazzor_App.Shared.Models
{
    public class User
    {        
        public int Userid { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        public string Cellnumber { get; set; } = null!;
        [Required]
        public string Emailid { get; set; } = null!;
    }
}
