using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x150, GUID = 0x8261DB1CA73D8027, NameHash = 0x1C94F7F917E32E73)]
    public class GcSpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public GcSpaceshipClasses ShipClass;
        [NMS(Size = 0x80)]
        /* 0x04 */ public string Cockpit;
        /* 0x84 */ public float MaxHeadTurn;
        /* 0x88 */ public float MaxHeadPitchUp;
        /* 0x8C */ public float MaxHeadPitchDown;
        /* 0x90 */ public int DefaultHealth;
        /* 0x94 */ public float FoVFixedDistance;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x98 */ public byte[] Padding98;
        /* 0xA0 */ public TkModelRendererData Renderer;
    }
}
