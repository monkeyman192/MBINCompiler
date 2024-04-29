namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC2EA6CE040E0FF32, NameHash = 0x4CC02B5A253167FD)]
    public class TkAnimationGameData : NMSTemplate
    {
        // size: 0x3
        public enum BlockPlayerWeaponEnum : uint {
            Unblocked,
            Sheathed,
            OutButCannotFire,
        }
        [NMS(Index = 2)]
        /* 0x0 */ public BlockPlayerWeaponEnum BlockPlayerWeapon;
        [NMS(Index = 1)]
        /* 0x4 */ public bool BlockPlayerMovement;
        [NMS(Index = 0)]
        /* 0x5 */ public bool RootMotionEnabled;
    }
}
