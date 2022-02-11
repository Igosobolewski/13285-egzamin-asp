using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _13285_egzamin_asp.Models
{
    public class Book
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać tytuł książki!")]
        [MinLength(3, ErrorMessage = "Tytuł nie może być krótszy niż 3 znaki")]
        [Display(Name = "Tytuł książki")]
        [MaxLength(200, ErrorMessage = "Tytuł nie może być dłuższa niż 200 znaków")]
        public string Title { get; set; }

        [MinLength(3, ErrorMessage = "Imię nie może być krótsze niż 3 znaków")]
        [MaxLength(200, ErrorMessage = "Imię nie może być dłuższe niż 200 znaków")]
        [Required(ErrorMessage = "Musisz podać autora!")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Musisz podać cene książki!")]
        [Range(minimum: 0, maximum: 9999, ErrorMessage = "Cena nie może być ujemna ani większa niż 9999!")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
    }
}
