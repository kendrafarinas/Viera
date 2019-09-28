
namespace Maria.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name ="Cumpleaños")]
        public DateTime Birthdate { get; set; }
        

    }
}