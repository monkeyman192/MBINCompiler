namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2B2AAF52924FA65D, NameHash = 0x4CC02B5A253167FD)]
    public class TkAnimationGameData : NMSTemplate
    {
        // size: 0x3
        public enum BlockPlayerWeaponEnum : uint {
            Unblocked,
            Sheathed,
            OutButCannotFire,
        }
        /* 0x0 */ public BlockPlayerWeaponEnum BlockPlayerWeapon;
        /* 0x4 */ public bool BlockPlayerMovement;
        /* 0x5 */ public bool RootMotionEnabled;
    }
}
