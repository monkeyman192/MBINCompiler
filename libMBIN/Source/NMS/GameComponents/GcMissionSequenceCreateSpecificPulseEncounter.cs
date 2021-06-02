using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2A0, GUID = 0xEAA891CD60C683B4, NameHash = 0x245D62E60DEB8B1E)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageNoShip;
        /* 0x100 */ public NMSString0x80 MessageNotPulsing;
        /* 0x180 */ public NMSString0x80 MessageSignalBlocked;
        /* 0x200 */ public float MinTimeInPulse;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x204 */ public byte[] Padding204;
        /* 0x208 */ public NMSString0x10 PulseEncounterID;
        /* 0x218 */ public bool AllowAnyEncounter;
        /* 0x219 */ public bool Silent;
        /* 0x21A */ public NMSString0x80 DebugText;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x29A */ public byte[] EndPadding;
    }
}
