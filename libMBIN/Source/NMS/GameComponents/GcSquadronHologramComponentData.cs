using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF453CE233B696D61, NameHash = 0x8E4A63D8D3818019)]
    public class GcSquadronHologramComponentData : NMSTemplate
    {
        /* 0x00 */ public float HologramRotationSpeedDegPerSec;
        /* 0x04 */ public float PilotScale;
        /* 0x10 */ public Vector3f SpawnOffset;
        /* 0x20 */ public float SpawnRotation;
    }
}
