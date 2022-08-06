using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B4CEEDD24D455A6, NameHash = 0x86EB95060E94C279)]
    public class GcMechMeshPartTable : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcMechMeshPart.MechMeshPartEnum))]
        public GcMechMeshPartData[] Parts;
    }
}
