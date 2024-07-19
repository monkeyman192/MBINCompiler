using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6EA9CD95F76923F, NameHash = 0x95D309FC)]
    public class GcAsteroidSystemGenerationData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcAsteroidGenerationData CommonAsteroidData;
        [NMS(Index = 2)]
        /* 0x24 */ public GcAsteroidGenerationData LargeAsteroidData;
        [NMS(Index = 3)]
        /* 0x48 */ public GcAsteroidGenerationData RareAsteroidData;
        [NMS(Index = 1)]
        /* 0x6C */ public GcAsteroidGenerationData RingAsteroidData;
    }
}
