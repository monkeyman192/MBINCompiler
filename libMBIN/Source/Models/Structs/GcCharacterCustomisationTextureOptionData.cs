namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcCharacterCustomisationTextureOptionData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TextureOptionGroupName;
        [NMS(Size = 0x20)]
        public string TextureOptionName;
    }
}
