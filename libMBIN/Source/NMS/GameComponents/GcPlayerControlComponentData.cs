using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x68, GUID = 0x942496B3E9D157AA, NameHash = 0xE15445D2CE8FD16D)]
    public class GcPlayerControlComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InitialState;
        /* 0x10 */ public GcPlayerControlInput BaseInput;
        /* 0x48 */ public NMSString0x10 BaseCamera;
        /* 0x58 */ public List<GcPlayerControlState> States;
    }
}
