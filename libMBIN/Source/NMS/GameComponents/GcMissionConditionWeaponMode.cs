using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FC067929FE75585, NameHash = 0x9FF55E4C)]
    public class GcMissionConditionWeaponMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerWeapons WeaponMode;
    }
}
