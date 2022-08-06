using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC89A2C18B25E7052, NameHash = 0x24AA6BA1FC3287BE)]
    public class GcMissionConsequenceRemoveCommunicatorTakeOffMessage : NMSTemplate
    {
        /* 0x0 */ public NMSString0x20A Comms;
    }
}
