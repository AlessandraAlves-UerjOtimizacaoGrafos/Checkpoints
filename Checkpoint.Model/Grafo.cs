namespace Checkpoint.Model
{
    public struct Grafo
    {
        public string Nome { get; set; }
        public uint[] Arestas { get; set; }
        public uint[][] Vertices { get; set; }

    }
}