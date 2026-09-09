using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31A1B4AEDA7792E, NameHash = 0xCD581595)]
    public class GcSpacePoiGenerationData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xE, EnumType = typeof(GcSpacePoiType.SpacePoiTypeEnum))]
        /* 0x000 */ public GcSpacePoiTypeSpawnData[] SpawnData;
        [NMS(Index = 0)]
        /* 0x2A0 */ public int GenerationVersion;
    }
}
