namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DonacionesInsumos
    {
        [Key]
        public int IdDonacionInsumo { get; set; }

        public int IdNecesidadDonacionInsumo { get; set; }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Debe ingresar al menos una donaci�n de alg�n producto")]
        public int Cantidad { get; set; }

        public virtual NecesidadesDonacionesInsumos NecesidadesDonacionesInsumos { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
