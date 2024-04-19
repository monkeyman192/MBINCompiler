using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2F08B08C266BC74, NameHash = 0x1C94F7F917E32E73)]
    public class GcSpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public TkModelRendererData Renderer;
        /* 0xB0 */ public GcSpaceshipClasses Class;
        /* 0xB4 */ public int DefaultHealth;
        /* 0xB8 */ public float FoVFixedDistance;
        /* 0xBC */ public float MaxHeadPitchDown;
        /* 0xC0 */ public float MaxHeadPitchUp;
        /* 0xC4 */ public float MaxHeadTurn;
        /* 0xC8 */ public NMSString0x80 Cockpit;
    }
}
