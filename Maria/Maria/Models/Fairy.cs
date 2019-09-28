using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maria.Models
{
    public enum Lista
    {
        Key,
        Kiwi,
        Koala

    }
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }
        [Required]
        [Range(2,4)]
        public string NickName { get; set; }
        [Required]
        public Lista Wishes { get; set; }
                public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        

    }
}