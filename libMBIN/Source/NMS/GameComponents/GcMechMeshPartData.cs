using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7982667F2F1C627D, NameHash = 0xE780BADC17E2668A)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        public GcMechMeshPartTypeData[] MeshTypes;
    }
}
