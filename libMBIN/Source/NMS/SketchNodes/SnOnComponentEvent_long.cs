using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x48)]
    public class SnOnComponentEvent_long : NMSTemplate
    {
        /* 0x00 */ public SnComponentEnum Component;
        /* 0x08 */ public NMSString0x20 Event;  // May be one of ('ArmourDestroyed', 'Shot' or 'Interaction', 'Interaction')
        // No idea what these are and maybe they are not in the exe...
        /* 0x28 */ public int Unknown0x28;
        /* 0x2C */ public int Unknown0x2C;
        /* 0x30 */ public int Unknown0x30;
        /* 0x34 */ public int Unknown0x34;
        /* 0x38 */ public int Unknown0x38;
        /* 0x3C */ public int Unknown0x3C;
        /* 0x40 */ public int Unknown0x40;
        /* 0x44 */ public int Unknown0x44;
        // OutNode: 0: "Event Value"

        // Some data relating to 'Event' and 'Component':
        /*
        Event           | Component value
        ----------------------------------
        Interacted      | EAE36C86E1479AF5
        Interacted      | DAB0554EA36957B5
        ArmourDestroyed | 387AC5FC8E642A15
        Shot            | 387AC5FC8E642A15
        */
    }
}
