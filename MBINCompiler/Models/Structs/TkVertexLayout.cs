using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkVertexLayout : NMSTemplate
    {
        public int ElementCount;
        public int Stride;

        [NMS(Size = 8)]
        public string PlatformData;       // this *should* be a long, but nothing seems to use it, so we'll just leave it as a string of length 8...

        public List<TkVertexElement> VertexElements;
    }
}
