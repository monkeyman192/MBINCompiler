namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8, Alignment = 0x4)]
    public class GcGenericMissionVersionProgress : NMSTemplate
    {
        public int Version;
        public int Progress;
    }
}
