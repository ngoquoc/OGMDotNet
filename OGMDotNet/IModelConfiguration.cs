using System;
using System.Collections.Generic;
using System.Text;

namespace OGMDotNet
{
    public interface IModelConfiguration
    {
        IVertexConfiguration<T> Vertex<T>(string label = null)
            where T : new();

        IEdgeConfiguration<T> Edge<T>(string label = null)
            where T : new();
    }
}
