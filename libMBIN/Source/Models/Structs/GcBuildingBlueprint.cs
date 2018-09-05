namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcBuildingBlueprint : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ProductID;
        public int GroupId;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
