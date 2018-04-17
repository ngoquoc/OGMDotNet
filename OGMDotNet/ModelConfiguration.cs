using OGMDotNet.Internal;
using System;
using System.Collections.Generic;

namespace OGMDotNet
{
    public class ModelConfiguration : IModelConfiguration
    {
        private HashSet<Vertex> _vertices;
        private HashSet<Edge> _edges;

        public ModelConfiguration()
        {
            _vertices = new HashSet<Vertex>();
            _edges = new HashSet<Edge>();
        }

        IEdgeConfiguration<T> IModelConfiguration.Edge<T>(string label)
        {
            return new EdgeConfiguration()
        }

        IVertexConfiguration<T> IModelConfiguration.Vertex<T>(string label)
        {
            throw new NotImplementedException();
        }
    }
}
