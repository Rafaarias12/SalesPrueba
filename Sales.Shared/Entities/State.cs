﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado/Departamento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        public string Name { get; set; } = null!;

        public Country? Country { get; set; }

        public ICollection<City>? Cities { get; set; }
    
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
