using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18075B181EC35F1E, NameHash = 0x5BB6B87A77237F5E)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 MissionID;
        /* 0x90 */ public bool MakeCurrent;
        /* 0x91 */ public bool Restart;
        /* 0x92 */ public bool Forced;
        /* 0x93 */ public NMSString0x80 DebugText;
    }
}
