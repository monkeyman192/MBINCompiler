using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x8, GUID = 0xC3435145E07F1AFE)]
    public class TkAnimationGameData : NMSTemplate
    {
        public bool RootMotionEnabled { get; set; }
        public bool BlockPlayerMovement { get; set; }
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding3 { get; set; }
		public enum BlockPlayerWeaponEnum { Unblocked, Sheathed, OutButCannotFire }
		public BlockPlayerWeaponEnum BlockPlayerWeapon { get; set; }
    }
}
