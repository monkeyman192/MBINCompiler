namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public GcFreighterBaseOptions[] FreighterBaseOptions;
    }
}
