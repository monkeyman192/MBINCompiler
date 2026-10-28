namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6BFABD6429CDA778, NameHash = 0x30DC7C6F)]
    public class TkIOSDeviceModel : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public float NativeScale;
        [NMS(Index = 3)]
        /* 0x004 */ public int ScreenHeightPoints;
        [NMS(Index = 2)]
        /* 0x008 */ public int ScreenWidthPoints;
        // size: 0x4
        public enum SimulatedMemoryPresetEnum : uint {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 5)]
        /* 0x00C */ public SimulatedMemoryPresetEnum SimulatedMemoryPreset;
        [NMS(Index = 0)]
        /* 0x010 */ public NMSString0x100 ModelIdentifier;
        [NMS(Index = 1)]
        /* 0x110 */ public NMSString0x100 SimulationId;
    }
}
