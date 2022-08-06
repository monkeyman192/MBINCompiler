using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4185DB4ECF22EA33, NameHash = 0xFD3FA61F96564C04)]
    public class GcCustomisationThrusterEffects : NMSTemplate
    {
        /* 0x00 */ public List<GcCustomisationThrusterEffect> JetpackEffects;
        /* 0x10 */ public List<GcCustomisationBackpackData> BackpackData;
        /* 0x20 */ public List<GcCustomisationShipTrails> ShipEffects;
        /* 0x30 */ public List<GcCustomisationFreighterEngineEffect> FreighterEngineEffects;
    }
}
