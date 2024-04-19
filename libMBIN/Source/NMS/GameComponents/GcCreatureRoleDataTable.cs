using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F80B843355F7B5E, NameHash = 0xF460B1FDC0499CEA)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureRoleData> AvailableRoles;
        /* 0x10 */ public float MaxProportionFlying;
        /* 0x14 */ public float SandWormFrequency;
        /* 0x18 */ public bool HasSandWorms;
    }
}
