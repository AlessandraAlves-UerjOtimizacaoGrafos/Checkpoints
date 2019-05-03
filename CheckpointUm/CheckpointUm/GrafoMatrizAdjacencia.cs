using System.Collections.Generic;
using System.Text;

namespace Checkpoint
{
    public class GrafoMatrizAdjacencia
    {
        private readonly int _qtdVertices;

        public string Nome { get; set; }

        public IDictionary<int, IList<int>> Vertices;

        /// <summary>
        /// Representação de um Grafo
        /// </summary>
        /// <param name="vertices">Quantidade de vértices desejada</param>
        public GrafoMatrizAdjacencia(int vertices = 3)
        {
            this.Nome = string.Empty;
            this.Vertices = new Dictionary<int, IList<int>>();
            this._qtdVertices = vertices;

            for (int i = 1; i < (this._qtdVertices + 1); i++)
                Vertices.Add(i, new List<int>());
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var v in Vertices)
            {
                result.AppendLine($"Vértice: {v.Key} / Arestas: [{string.Join(", ", v.Value)}]");
            }

            return result.ToString();
        }
    }
}