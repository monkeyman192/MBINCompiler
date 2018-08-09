namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class TkAnimationGameData : NMSTemplate
    {
        public bool RootMotionEnabled;
        public bool BlockPlayerMovement;
        public int BlockPlayerWeapon;
        public string[] BlockPlayerWeaponValues()
        {
            return new[] { "Unblocked", "Sheathed", "OutButCannotFire" };
        }
    }
}
