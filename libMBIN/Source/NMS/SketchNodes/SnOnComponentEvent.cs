using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x28)]
    public class SnOnComponentEvent : NMSTemplate
    {
        /* 0x00 */ public SnComponentEnum Component;
        [NMS(Size = 0x20)]
        /* 0x08 */ public string Event;  // May be one of ('ArmourDestroyed', 'Shot' or 'Interaction', 'Interaction')
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
