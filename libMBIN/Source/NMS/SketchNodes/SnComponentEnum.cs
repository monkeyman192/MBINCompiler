using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8, Alignment = 0x4)]
    public class SnComponentEnum : NMSTemplate
    {
        public enum ComponentEnum : ulong {
            GcSimpleInteractionComponentData = 0xEAE36C86E1479AF5,
            GcInteractionComponentData = 0xDAB0554EA36957B5,
            GcShootableComponentData = 0x387AC5FC8E642A15,
            GcPlayerControlComponentData = 0xE15445D2CE8FD16D
        };
        public ComponentEnum Component;
    }
}
