using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD3391D27415E32C, NameHash = 0xCD20631E8DC06987)]
    public class GcMechDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public Vector3f Facing;
        /* 0x20 */ public Vector3f Up;
        /* 0x30 */ public Vector3f Destination;
        /* 0x40 */ public bool Running;
        /* 0x44 */ public float TitanFallDelay;
        /* 0x48 */ public float MoveDelay;
        /* 0x4C */ public bool UseCustomisation;
        /* 0x50 */ public GcCharacterCustomisationSaveData CustomisationData; //CustomisatonData;
    }
}
