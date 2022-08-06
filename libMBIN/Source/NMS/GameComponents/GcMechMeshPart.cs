using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FCD7876667555C2, NameHash = 0x78242DA1B96F48FC)]
    public class GcMechMeshPart : NMSTemplate
    {
        // size: 0x5
        public enum MechMeshPartEnum { Scanner, Body, Legs, LeftArm, RightArm }
        public MechMeshPartEnum MechMeshPart;
    }
}
