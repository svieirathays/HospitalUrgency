using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalUrgency
{
    class Profissionais
    {
        //variáveis
        private int id;
        private string nome;
        private string morada;
        private int cp;
        private int telefone;
        private int nif;
        private string cargo;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Morada
        {
            get { return this.morada; }
            set { this.morada = value; }
        }

        public int CP
        {
            get { return this.cp; }
            set { this.cp = value; }
        }

        public int NIF
        {
            get { return this.nif; }
            set { this.nif = value; }
        }

        public int Telefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }

        public string Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public ICollection<Tratamento> Tratamento { get; set; }
        public ICollection<ListaPrioridade> ListaPrioridade { get; set; }
        public ICollection<Pacientes> Pacientes { get; set; }

    }
}
