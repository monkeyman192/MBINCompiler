namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3)]
    public class TkAnimationGameData : NMSTemplate
    {
        public bool RootMotionEnabled;
        public bool BlockPlayerMovement;
        public bool BlockPlayerWeapon;
    }
}
