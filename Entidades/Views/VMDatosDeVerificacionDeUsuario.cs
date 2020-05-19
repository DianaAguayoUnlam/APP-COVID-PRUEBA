﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Views
{
    public class VMDatosDeVerificacionDeUsuario
    {
        [Required(ErrorMessage ="Debe introducir el codigo recibido en el mensaje via email")]
        [Display(Name = "Codigo de verificacion")]
        public string codigoDeVerificacion { get; set; }

        [Required(ErrorMessage ="Introduzca el email con el que se registro")]
        [EmailAddress]
        [Display(Name = "Email")]

        public string email { get; set; }
    }
}
