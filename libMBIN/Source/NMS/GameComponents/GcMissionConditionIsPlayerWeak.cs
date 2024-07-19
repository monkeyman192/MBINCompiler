namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67C14B3B9661443F, NameHash = 0x569C60B5)]
    public class GcMissionConditionIsPlayerWeak : NMSTemplate
    {
        // size: 0x3
        public enum ProgressTypeEnum : uint {
            ShipOrWeapon,
            Ship,
            Weapon,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProgressTypeEnum ProgressType;
    }
}
