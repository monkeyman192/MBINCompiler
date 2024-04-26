using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E260C12D74D0854, NameHash = 0xE15445D2CE8FD16D)]
    public class GcPlayerControlComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerControlInput BaseInput;
        [NMS(Index = 4)]
        /* 0x38 */ public TkBlackboardKey AimDir;
        [NMS(Index = 6)]
        /* 0x50 */ public TkBlackboardKey CrosshairDir;
        [NMS(Index = 5)]
        /* 0x68 */ public TkBlackboardKey TorchDir;
        [NMS(Index = 2)]
        /* 0x80 */ public NMSString0x10 BaseCamera;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x10 InitialState;
        [NMS(Index = 3)]
        /* 0xA0 */ public List<GcPlayerControlState> States;
    }
}
