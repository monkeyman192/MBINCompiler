using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xC3435145E07F1AFE, NameHash = 0x4CC02B5A253167FD)]
    public class TkAnimationGameData : NMSTemplate
    {
        public bool RootMotionEnabled;
        public bool BlockPlayerMovement;
		public enum BlockPlayerWeaponEnum { Unblocked, Sheathed, OutButCannotFire }
		public BlockPlayerWeaponEnum BlockPlayerWeapon;
    }
}
