using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65D9AB29D95F63F0, NameHash = 0xF460B1FDC0499CEA)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureRoleData> AvailableRoles;
        [NMS(Index = 1)]
        /* 0x10 */ public float MaxProportionFlying;
        [NMS(Index = 3)]
        /* 0x14 */ public float SandWormFrequency;
        [NMS(Index = 2)]
        /* 0x18 */ public bool HasSandWorms;
    }
}
