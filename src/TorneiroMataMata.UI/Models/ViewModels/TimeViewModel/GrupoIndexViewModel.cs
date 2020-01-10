using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TorneiroMataMata.UI.Models.ViewModels.TimeViewModel
{
    public class GrupoIndexViewModel
    {
        [Key]
        public int GrupoId { get;  set; }
        public string Nome { get;  set; }
        public string Descricao { get;  set; }

        public virtual ICollection<TimeIndexViewModel> Times { get;  set; }
    }
}