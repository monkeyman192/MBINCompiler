using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x118, Alignment = 0x8, GUID = 0x9CDBB49E1C4E9525, NameHash = 0x3FACFB36175544A6)]
    public class GcRewardFrigateFlyby : NMSTemplate
    {
        /* 0x000 */ public GcFrigateFlybyType FlybyType;
        /* 0x004 */ public float AppearanceDelay;
        [NMS(Size = 0x20)]  // Aligned
        /* 0x008 */ public string CommunicatorOSDLocId;
        /* 0x028 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        /* 0x078 */ public TkTextureResource MarkerIcon;
        /* 0x0FC */ public GcAudioWwiseEvents PulseAudio;
        /* 0x100 */ public GcAudioWwiseEvents AudioSting;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x104 */ public byte[] Padding104;
        [NMS(Size = 0x10)]
        /* 0x108 */ public string CameraShake;
    }
}
