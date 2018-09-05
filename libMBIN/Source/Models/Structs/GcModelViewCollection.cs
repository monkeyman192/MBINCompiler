namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xDC0)]
    public class GcModelViewCollection : NMSTemplate
    {
        [NMS(Size = 0x14, EnumValue = new string[0x14] {"Exosuit", "Weapon", "Ship", "Exocraft", "Animal", "AnimalThumbnails",
                                                        "Unknown2", "Unknown3","Unknown4","Unknown5","Unknown6","Unknown7",
                                                        "Unknown8","Unknown9", "Freighter", "Unknown10","Unknown11","Unknown12",
                                                        "Unknown13", "Unknown14"})]
        public TkModelRendererData[] ModelViews;
    }
}
