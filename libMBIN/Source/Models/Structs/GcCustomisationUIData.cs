namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x770A0)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0x9)]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
