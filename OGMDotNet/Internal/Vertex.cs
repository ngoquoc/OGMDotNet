using System;
using System.Collections.Generic;
using System.Text;

namespace OGMDotNet.Internal
{
    public struct Vertex
    {
        public string Label { get; set; }

        public Type ModelType { get; set; }

        public override bool Equals(object obj)
        {
            return Label == Label;
        }
    }
}
