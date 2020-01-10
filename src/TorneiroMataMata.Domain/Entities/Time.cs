using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneiroMataMata.Domain.Entities
{
    public class Time
    {
        //Constructors
        public Time(string nome, int grupoId)
        {
            Nome = nome;
            GrupoId = grupoId;
            Gol = 0;
            SaldoGols = 0;
            
        }

        protected Time()
        {

        }

        //Properties
        public int TimeId { get; private set; }
        public string Nome { get; private set; }
        public int Gol { get; private set; }
        public int SaldoGols { get; private set; }

        public int GrupoId { get; private set; }
        public virtual Grupo Grupo { get; private set; }

        //Metods
        public void TrocarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarGrupo(int grupoId)
        {
            GrupoId = grupoId;
        }

        public void AddGol(int gols)
        {
            Gol = gols;
            SaldoGols += gols;

        }

        public void ZerarGols()
        {
            Gol = 0;
        }

        public void ZerarSg()
        {
            SaldoGols = 0;
        }

    }
}
