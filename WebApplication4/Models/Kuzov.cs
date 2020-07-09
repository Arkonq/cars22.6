using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public enum Kuzov
    {
        [Display(Name = "Седан")]
        Sedan,

        [Display(Name = "Купе")] 
        Coupe,

        [Display(Name = "Минивэн")] 
        Minivan,

        [Display(Name = "Спейс вагон")] 
        SpaceWagon,

        [Display(Name = "Лимузин")] 
        Limousine
    }
}