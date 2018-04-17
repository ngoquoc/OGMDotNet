using System;
using System.Collections.Generic;
using System.Text;

namespace OGMDotNet.Internal
{
    public struct Edge
    {
        public Vertex From { get; set; }

        public Vertex To { get; set; }

        public string Label { get; set; }

        public Type ModelType { get; set; }

        public EdgeDirection Direction { get; set; }
    }

    public enum EdgeDirection
    {
        Both,
        In,
        Out
    }
}
