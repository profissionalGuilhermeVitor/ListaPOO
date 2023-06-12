using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    internal class NohPilha
    {
        private string codigo;
        private NohPilha anterior;

        public NohPilha()
        {
            this.Anterior = null;
        }

        public NohPilha(string _codigo)
        {
           codigo = _codigo;
            this.Anterior = null;
        }

        public NohPilha(string _codigo, NohPilha _anterior)
        {
            codigo = _codigo;
            anterior = _anterior;
        }


        public string Codigo { get => codigo; set => codigo = value; }
        internal NohPilha Anterior { get => anterior; set => anterior = value; }
    }
}
