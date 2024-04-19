using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58D85EFD3CD1B909, NameHash = 0x6D874860E2F7237A)]
    public class GcAsteroidSystemGenerationData : NMSTemplate
    {
        /* 0x00 */ public GcAsteroidGenerationData CommonAsteroidData;
        /* 0x24 */ public GcAsteroidGenerationData LargeAsteroidData;
        /* 0x48 */ public GcAsteroidGenerationData RareAsteroidData;
        /* 0x6C */ public GcAsteroidGenerationData RingAsteroidData;
    }
}
