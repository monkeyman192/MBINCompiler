using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2F08B08C266BC74, NameHash = 0x1C94F7F917E32E73)]
    public class GcSpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public TkModelRendererData Renderer;
        [NMS(Index = 0)]
        /* 0xB0 */ public GcSpaceshipClasses Class;
        [NMS(Index = 5)]
        /* 0xB4 */ public int DefaultHealth;
        [NMS(Index = 6)]
        /* 0xB8 */ public float FoVFixedDistance;
        [NMS(Index = 4)]
        /* 0xBC */ public float MaxHeadPitchDown;
        [NMS(Index = 3)]
        /* 0xC0 */ public float MaxHeadPitchUp;
        [NMS(Index = 2)]
        /* 0xC4 */ public float MaxHeadTurn;
        [NMS(Index = 1)]
        /* 0xC8 */ public NMSString0x80 Cockpit;
    }
}
