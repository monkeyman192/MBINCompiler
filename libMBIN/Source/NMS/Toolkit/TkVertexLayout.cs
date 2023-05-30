using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkVertexLayout : NMSTemplate
    {
        public int ElementCount;
        public int Stride;

        [NMS(Size = 8)]
        public string PlatformData;

        public List<TkVertexElement> VertexElements;
    }
}
