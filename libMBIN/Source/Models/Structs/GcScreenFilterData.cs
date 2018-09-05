namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA8)]
    public class GcScreenFilterData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string LocText;
        [NMS(Size = 0x80)]
        public string Filename;
        public float FadeDistance;
        public bool SelectableInPhotoMode;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
