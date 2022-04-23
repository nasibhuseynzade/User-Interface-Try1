using System.ComponentModel.DataAnnotations;

namespace User_Interface_1.Models
{
    public class User
    {
        [Key]
        public int İD { get; set; }
        [Required]
        public string Username { get; set; }
        public string Displayname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Userroles { get; set; }
        public bool IsEnabled { get; set; }

    }
}
