using System.Collections.Generic;
using System.Linq;

namespace CheckpointUm.Grafo
{
    /// <summary>
    /// Um grafo parte de um ponto qualquer e mantém uma lista de nós (aninhados)
    /// </summary>
    public class Grafo
    {
        public No Raiz;
        public List<No> Nos = new List<No>();

        public Grafo()
        {

        }


        /// <summary>
        /// Cria um novo nó. Se a raiz estiver não inicializado o novo nó é a raiz
        /// </summary>
        /// <param name="name">O nome do nó</param>
        /// <returns>O nó recém criado</returns>
        public No CriarNo(string name)
        {
            var n = new No { Nome = name };

            if (Raiz == null)
            {
                Raiz = n;
            }

            Nos.Add(n);

            return n;
        }

        /// <summary>
        /// Remove o nome pela referência dele
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public bool RemoverNo(string nome)
        {
            var procurado = this.Nos.SingleOrDefault(n => n.Nome == nome);

            if (procurado == null)
            {
                return false;
            }

            return this.Nos.Remove(procurado);
        }

        public IEnumerable<No> ObterVizinhos(No no)
        {
            var resultado = new List<No>();

            foreach (var aresta in no.Arestas)
            {
                foreach (var No in this.Nos)
                {
                    if (aresta.SePresente(No))
                    {
                        resultado.Add(No);
                    }
                }

            }

            return resultado;
        }
    }
}