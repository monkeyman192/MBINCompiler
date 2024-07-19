namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFD13BEA7BB1992F, NameHash = 0x921C155)]
    public class GcPhotoCreature : NMSTemplate
    {
        // size: 0x3
        public enum PhotoCreatureTypeEnum : uint {
            Ground,
            Water,
            Air,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PhotoCreatureTypeEnum PhotoCreatureType;
    }
}
