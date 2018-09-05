namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcCustomisationTextureGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupID;
        [NMS(Size = 0x20)]
        public string Title;
        [NMS(Size = 0x10)]
        public string TextureOptionsGroup;
    }
}
