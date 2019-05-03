namespace CheckpointUm.Grafo
{
    /// <summary>
    /// Uma aresta é só uma referência entre dois pontos
    /// </summary>
    public struct Aresta
    {
        public No Inicio;
        public No Fim;

        public bool SePresente(No no) => this.Inicio == no || Fim == no;
    }
}