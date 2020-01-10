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
        public string Nome { get;  set; }
        public int Gol { get;  set; }
        public int SaldoGols { get;  set; }

        public int GrupoId { get;  set; }
        public virtual GrupoIndexViewModel Grupo { get;  set; }
    }
}