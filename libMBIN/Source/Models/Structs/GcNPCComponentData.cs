namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcNPCComponentData : NMSTemplate
    {
        public GcAlienRace AlienRace;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string HologramEffect;
        public bool IsOldStyleNPC;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
