using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5AA714E96862B5F6, NameHash = 0x4600F6B4)]
    public class GcSpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public TkModelRendererData Renderer;
        [NMS(Index = 1)]
        /* 0xB0 */ public VariableSizeString Cockpit;
        [NMS(Index = 0)]
        /* 0xC0 */ public GcSpaceshipClasses Class;
        [NMS(Index = 5)]
        /* 0xC4 */ public int DefaultHealth;
        [NMS(Index = 6)]
        /* 0xC8 */ public float FoVFixedDistance;
        [NMS(Index = 4)]
        /* 0xCC */ public float MaxHeadPitchDown;
        [NMS(Index = 3)]
        /* 0xD0 */ public float MaxHeadPitchUp;
        [NMS(Index = 2)]
        /* 0xD4 */ public float MaxHeadTurn;
    }
}
