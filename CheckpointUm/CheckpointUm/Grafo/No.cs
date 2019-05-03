using System.Collections.Generic;

namespace CheckpointUm.Grafo
{
    public class No
    {
        public List<Aresta> Arestas = new List<Aresta>();

        public string Nome { get; set; }

        public No CriarAresta(No fim)
        {
            Arestas.Add(new Aresta
            {
                Inicio = this,
                Fim = fim,
            });

            if (!fim.Arestas.Exists(a => a.Inicio == fim && a.Fim == this))
            {
                fim.CriarAresta(this);
            }

            return this;
        }
    }
}