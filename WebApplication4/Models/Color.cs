using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public enum Color
    {
        [Display(Name = "Черный")]
        Black,

        [Display(Name = "Серый")] 
        Gray,

        [Display(Name = "Белый")]
        White,

        [Display(Name = "Красный")] 
        Red,

        [Display(Name = "Зеленый")] 
        Green,

        [Display(Name = "Синий")] 
        Blue
    }
}