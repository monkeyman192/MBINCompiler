namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x818F44AD0AE6FABE, NameHash = 0x6F8F11FE)]
    public class GcCreatureAttractorComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float ArriveDist;
        // size: 0x2
        public enum AttractorTypeEnum : uint {
            Food,
            Harvester,
        }
        [NMS(Index = 3)]
        /* 0x4 */ public AttractorTypeEnum AttractorType;
        [NMS(Index = 1)]
        /* 0x8 */ public bool Static;
        [NMS(Index = 0)]
        /* 0x9 */ public bool Universal;
    }
}
