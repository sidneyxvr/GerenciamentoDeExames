﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeExames.ViewModels.Pacient
{
    public class SavePacientViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        public Guid UserId { get; set; }
    }
}
