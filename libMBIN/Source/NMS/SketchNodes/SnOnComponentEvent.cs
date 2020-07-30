using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x48)]
    public class SnOnComponentEvent : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x00 */ public byte[] Component;  // name probably not right...
        // The value of the above byte array is dependent on the value of `Event`?
        [NMS(Size = 0x20)]
        /* 0x08 */ public string Event;  // May be one of ('ArmourDestroyed', 'Shot' or 'Interaction')
        [NMS(Size = 0x18)]
        /* 0x28 */ public byte[] Unknown28;  // Possibly 4 quaternions??
        /* 0x40 */ public int Unknown40;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] EndPadding;

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
