using OGMDotNet.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace OGMDotNet
{
    class Test
    {
        public Test()
        {
            IModelConfiguration x = new ModelConfiguration();
            x.Vertex<Vertex>().HasEdge<Edge>()
                .In()
                .To<Vertex>();
        }
    }
}
