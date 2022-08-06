using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15DB46BA1821E7C8, NameHash = 0xB88BA2B1282BE1C1)]
    public class GcNPCWorkerData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ResourceElement;
        /* 0x2A8 */ public GcSeed InteractionSeed;
        /* 0x2B8 */ public bool HiredWorker;
        /* 0x2B9 */ public bool FreighterBase;
        /* 0x2C0 */ public ulong BaseUA;
        /* 0x2D0 */ public Vector4f BaseOffset;
    }
}
