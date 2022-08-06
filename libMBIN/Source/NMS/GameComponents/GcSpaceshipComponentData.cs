using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FB4468AD1C72854, NameHash = 0x1C94F7F917E32E73)]
    public class GcSpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public GcSpaceshipClasses Class;
        /* 0x04 */ public NMSString0x80 Cockpit;
        /* 0x84 */ public float MaxHeadTurn;
        /* 0x88 */ public float MaxHeadPitchUp;
        /* 0x8C */ public float MaxHeadPitchDown;
        /* 0x90 */ public int DefaultHealth;
        /* 0x94 */ public float FoVFixedDistance;
        /* 0xA0 */ public TkModelRendererData Renderer;
    }
}
