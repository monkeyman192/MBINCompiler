namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB675BAAA4335E43, NameHash = 0x1FB40558)]
    public class GcMissionConditionWristMenuOpen : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public bool GunHandOnly;
        [NMS(Index = 3)]
        /* 0x1 */ public bool InventoryOnly;
        [NMS(Index = 0)]
        /* 0x2 */ public bool LeftHandOnly;
        [NMS(Index = 1)]
        /* 0x3 */ public bool QuickMenuOnly;
    }
}
