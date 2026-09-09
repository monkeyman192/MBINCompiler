namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97466F75A677A59A, NameHash = 0x9D056F8C)]
    public class GcRecyclableType : NMSTemplate
    {
        // size: 0x7
        public enum RecyclableTypeEnum : uint {
            Scrap,
            Toxic,
            Radioactive,
            Explosive,
            TruckFurnace,
            Dematerializer,
            TractorBeam,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RecyclableTypeEnum RecyclableType;
    }
}
