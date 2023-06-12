using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    internal class Pilha
    {
        private NohPilha topo;
        private int porto;

        public Pilha() {
            Topo = null;     
        }

        public Pilha(NohPilha topo)
        {
            this.Topo = topo;
        }

        public int Porto { get => porto; set => porto = value; }
        internal NohPilha Topo { get => topo; set => topo = value; }

        public bool estarVazia()
        {
            if (Topo == null) return true;
            else return false;
        }

        public void inserir(string codigo)
        {
            if(estarVazia())
            {
                NohPilha novaPilha = new NohPilha(codigo);
                topo = novaPilha;
            }
            else
            {
                NohPilha novaPilha = new NohPilha(codigo,topo);
                topo= novaPilha;
            }

        }
        public bool remover()
        {
            if(estarVazia())
            {
                return false;
            }
            else 
            {
                topo = topo.Anterior;
                return true;
            }
        }

        public int quantPilha()
        {
            int n = 0;
            NohPilha temp = topo;
            while(temp != null)
            {
                temp= temp.Anterior;
                n++;
            }
            return n;

        }

        public bool estaCheia()
        {
            if(quantPilha() >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool codigoExiste(string codigo)
        {
            NohPilha temp = topo;
            while(temp != null )
            {
                if(temp.Codigo.Equals(codigo))
                {
                    return true;
                }
                else { temp = temp.Anterior; }
            }
            return false;
        }

        public void imprime(int i)
        {
            switch (i)
            {
                case 1:
                    for(int j = 0; j < i; j++)
                    {
                        Console.WriteLine("|" + Topo.Codigo + "|");
                    }
                    break;
                case 2:
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("|" + Topo.Codigo + "|" + Topo.Anterior.Codigo + "|");
                        break;
                    }
                    break;
                case 3:
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("|" + Topo.Codigo + "|" + Topo.Anterior.Codigo + "|" + Topo.Anterior.Anterior.Codigo + "|");
                        break;
                    }
                    break;

            }
            try
            {
                string code = Topo.Codigo;
            }
            catch(Exception e) { Console.WriteLine("|      |"); }
        }
    }
}
