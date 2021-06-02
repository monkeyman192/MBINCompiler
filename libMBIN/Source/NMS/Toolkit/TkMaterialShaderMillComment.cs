using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x410, GUID = 0x2B267A7C37F7D898, NameHash = 0x69D7A72052C55F5E)]
    public class TkMaterialShaderMillComment : NMSTemplate
    {
        public NMSString0x400 Text;     // Not 100% sure on the data type. It doesn't look to be an array, and nothing else uses it... So I am assuming it's just a huge wall of text...
        public int PosMinX;
        public int PosMinY;
        public int PosMaxX;
        public int PosMaxY;
    }
}
