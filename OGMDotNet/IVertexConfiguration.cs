namespace OGMDotNet
{
    public interface IVertexConfiguration<T> where T : new()
    {
        IEdgeConfiguration<TEdge> HasEdge<TEdge>()
            where TEdge : new();
    }

    internal class VertexConfiguration<T>
        : IVertexConfiguration<T> where T : new()
    {
        public VertexConfiguration()
        {
        }

        IEdgeConfiguration<TEdge> IVertexConfiguration<T>.HasEdge<TEdge>()
        {
            return new EdgeConfiguration<T>();
        }
    }
}