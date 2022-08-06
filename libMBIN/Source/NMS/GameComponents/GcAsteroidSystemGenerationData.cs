using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA23FF8491990D12A, NameHash = 0x6D874860E2F7237A)]
    public class GcAsteroidSystemGenerationData : NMSTemplate
    {
        /* 0x00 */ public GcAsteroidGenerationData CommonAsteroidData;
        /* 0x24 */ public GcAsteroidGenerationData RingAsteroidData;
        /* 0x48 */ public GcAsteroidGenerationData LargeAsteroidData;
        /* 0x6C */ public GcAsteroidGenerationData RareAsteroidData;
    }
}
