using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x8, GUID = 0xC3435145E07F1AFE, NameHash = 0x4CC02B5A253167FD)]
    public class TkAnimationGameData : NMSTemplate
    {
        public bool RootMotionEnabled;
        public bool BlockPlayerMovement;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding3;
		public enum BlockPlayerWeaponEnum { Unblocked, Sheathed, OutButCannotFire }
		public BlockPlayerWeaponEnum BlockPlayerWeapon;
    }
}
