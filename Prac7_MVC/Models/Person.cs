using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Prac7_MVC.Models
{
    public class Person
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int Id  { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Минимальная длина 3, максимальная 30 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Минимальная длина 3, максимальная 30 символов")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Минимальная длина 3, максимальная 30 символов")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression("^[+][0-9]{11}$", ErrorMessage = "Неверный формат")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression("^[A-Za-z][A-Za-z0-9_]{2,50}[@][A-Za-z]{1,20}[.][A-Za-z]{1,10}$", ErrorMessage = "Неверный формат")]
        public string Email { get; set; }

        public string WillCome { get; set; }
    }
}