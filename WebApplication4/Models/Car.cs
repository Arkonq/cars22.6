using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Display(Name = "Брэнд")]
        public string Title { get; set; }

        [Display(Name = "Цвет")]
        public Color Color { get; set; }

        [Display(Name = "Тип кузова")]
        public Kuzov Kuzov { get; set; }

        [Display(Name = "Мощность двигателя")]
        public float Power { get; set; }
    }
}