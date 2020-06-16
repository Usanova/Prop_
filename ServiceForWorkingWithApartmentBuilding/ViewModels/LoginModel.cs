﻿using System.ComponentModel.DataAnnotations;

namespace ServiceForWorkingWithApartmentBuilding.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указано Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
