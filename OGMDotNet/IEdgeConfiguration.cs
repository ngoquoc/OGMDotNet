namespace OGMDotNet
{
    public interface IEdgeConfiguration<T> where T : new()
    {
        IDirectedEdgeConfiguration<T> Both();

        IDirectedEdgeConfiguration<T> In();

        IDirectedEdgeConfiguration<T> Out();
    }

    public class EdgeConfiguration<T> : IEdgeConfiguration<T>
        where T : new()
    {
        IDirectedEdgeConfiguration<T> IEdgeConfiguration<T>.Both()
        {
            throw new System.NotImplementedException();
        }

        IDirectedEdgeConfiguration<T> IEdgeConfiguration<T>.In()
        {
            throw new System.NotImplementedException();
        }

        IDirectedEdgeConfiguration<T> IEdgeConfiguration<T>.Out()
        {
            throw new System.NotImplementedException();
        }
    }
}