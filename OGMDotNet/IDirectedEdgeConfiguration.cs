using System;
using System.Collections.Generic;
using System.Text;

namespace OGMDotNet
{
    public interface IDirectedEdgeConfiguration<TEdge>
        where TEdge : new()
    {
        void To<TVertex>()
            where TVertex : new();
    }

    public class DirectedEdgeConfiguration<TEdge> : IDirectedEdgeConfiguration<TEdge>
        where TEdge : new()
    {
        private IEdgeConfiguration<TEdge> _edge;

        public DirectedEdgeConfiguration(IEdgeConfiguration<TEdge> edge)
        {
            _edge = edge;
        }

        void IDirectedEdgeConfiguration<TEdge>.To<TVertex>()
        {
            throw new NotImplementedException();
        }
    }
}
