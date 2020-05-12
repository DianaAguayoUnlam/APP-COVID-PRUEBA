﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCovid19.Models.Views
{
    public class VMLogin
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = " Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de Email erroneo")]
        [StringLength(50, ErrorMessage = "Email demaciado largo")]
        public string Email { get; set; }

        [Display(Name = "Clave")]
        [Required(ErrorMessage = " Contraseña es obligatoria")]
        //Puede comenzar con A-Z, o a-z, o numeros de 0 a 9    |  finaliza con a-z - A-Z -ó- 0-9   {desde, hasta}
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])[a-zA-Z0-9]{1,}$", ErrorMessage = "La contraseña debe contener al menos una letra mayúscula, una letra minúscula y un número")]
        [MinLength(8, ErrorMessage = "Su contraseña debe tener 8 digitos como minimo")]
        public string Password { get; set; }
    }
}