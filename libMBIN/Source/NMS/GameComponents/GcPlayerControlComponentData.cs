using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E260C12D74D0854, NameHash = 0xE15445D2CE8FD16D)]
    public class GcPlayerControlComponentData : NMSTemplate
    {
        /* 0x00 */ public GcPlayerControlInput BaseInput;
        /* 0x38 */ public TkBlackboardKey AimDir;
        /* 0x50 */ public TkBlackboardKey CrosshairDir;
        /* 0x68 */ public TkBlackboardKey TorchDir;
        /* 0x80 */ public NMSString0x10 BaseCamera;
        /* 0x90 */ public NMSString0x10 InitialState;
        /* 0xA0 */ public List<GcPlayerControlState> States;
    }
}
