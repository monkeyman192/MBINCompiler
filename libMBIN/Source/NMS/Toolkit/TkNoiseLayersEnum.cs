namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x17A8EF62D5BC39D6, NameHash = 0xDF72B6BAF8A085A2)]
    public class TkNoiseLayersEnum : NMSTemplate
    {
        // size: 0x8
        public enum NoiseLayerTypesEnum : uint {
            Base,
            Hill,
            Mountain,
            Rock,
            UnderWater,
            Texture,
            Elevation,
            Continent,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NoiseLayerTypesEnum NoiseLayerTypes;
    }
}
