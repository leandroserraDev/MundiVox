using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneiroMataMata.Domain.Entities
{
    public class Grupo
    {
        public Grupo(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
        protected Grupo()
        {

        }
        public int GrupoId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public virtual ICollection<Time> Times { get; private set; }
    }
}
