using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TorneiroMataMata.UI.Models.ViewModels.TimeViewModel
{
    public class TimeIndexViewModel
    {
        [Key]
        public int TimeId { get;  set; }

        [Required(ErrorMessage ="Obrigatório")]
        public string Nome { get;  set; }
        [Required(ErrorMessage = "Obrigatório")]
        public int Gol { get;  set; }
        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name ="Saldo de gols")]
        public int SaldoGols { get;  set; }

        public int GrupoId { get;  set; }
        public virtual GrupoIndexViewModel Grupo { get;  set; }
    }
}
