using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF90D21C07EE51EE8, NameHash = 0x4600F6B4)]
    public class GcSpaceshipComponentData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public TkModelRendererData Renderer;
        [NMS(Index = 1)]
        /* 0xC0 */ public GcFilename Cockpit;
        [NMS(Index = 0)]
        /* 0xD0 */ public GcSpaceshipClasses Class;
        [NMS(Index = 5)]
        /* 0xD4 */ public int DefaultHealth;
        [NMS(Index = 6)]
        /* 0xD8 */ public float FoVFixedDistance;
        [NMS(Index = 4)]
        /* 0xDC */ public float MaxHeadPitchDown;
        [NMS(Index = 3)]
        /* 0xE0 */ public float MaxHeadPitchUp;
        [NMS(Index = 2)]
        /* 0xE4 */ public float MaxHeadTurn;
    }
}
