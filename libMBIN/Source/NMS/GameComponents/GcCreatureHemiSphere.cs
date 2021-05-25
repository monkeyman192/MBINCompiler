using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xA787ADE434116CC9, NameHash = 0x1BE056BC4F556CAA)]
    public class GcCreatureHemiSphere : NMSTemplate
    {
        // size: 0x3
        public enum CreatureHemiSphereEnum { Any, Northern, Southern };
        public CreatureHemiSphereEnum CreatureHemiSphere;
    }
}
