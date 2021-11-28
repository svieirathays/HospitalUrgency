using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalUrgency
{
    class Tratamento
    {
        private int id;
        private string nomemedicamento;
        private string validadereceita;
        private string nomeprofissional;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string NomeMedicamento
        {
            get { return this.nomemedicamento; }
            set { this.nomemedicamento = value; }
        }

        public string ValidadeReceita
        {
            get { return this.validadereceita; }
            set { this.validadereceita = value; }
        }

        public string NomeProfissional
        {
            get { return this.nomeprofissional; }
            set { this.nomeprofissional = value; }
        }
        public ICollection<Pacientes> Pacientes { get; set; }
    }
}
