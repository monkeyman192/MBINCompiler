using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D1FE8065EC09774, NameHash = 0x061E014828AD14CD)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public bool UseCustomMessage;
        /* 0x2B0 */ public NMSString0x20A CustomHailOSD;
        /* 0x2D0 */ public GcPlayerCommunicatorMessage HailingMessage;
    }
}
