using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3D77A40FE5B6E981, NameHash = 0xFC506DC8F06CBE6D)]
    public class TkMaterialShaderMillLink : NMSTemplate
    {
        /* 0x00 */ public int InputNode;
        /* 0x04 */ public NMSString0x20 InputConnect;
        /* 0x28 */ public NMSString0x10 InputShuffle;
        /* 0x38 */ public int OutputNode;
        /* 0x3C */ public NMSString0x20 OutputConnect;
        /* 0x60 */ public NMSString0x10 OutputShuffle;
        /* 0x70 */ public int Count;
    }
}
