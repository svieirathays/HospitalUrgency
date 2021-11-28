using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalUrgency
{
    public class ListaPrioridade
    {
        private int id;
        private string[] sintomas;
        private string prioridade;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string[] Sintomas
        {
            get { return this.sintomas; }
            set { this.sintomas = value; }
        }

        public string Prioridade
        {
            get { return this.prioridade; }
            set { this.prioridade = value; }
        }

        public ICollection<Pacientes> Pacientes { get; set; }

    }
}
