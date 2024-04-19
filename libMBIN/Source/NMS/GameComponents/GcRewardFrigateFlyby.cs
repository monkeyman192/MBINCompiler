using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69E560DA6DA21BA3, NameHash = 0x3FACFB36175544A6)]
    public class GcRewardFrigateFlyby : NMSTemplate
    {
        /* 0x000 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        /* 0x050 */ public NMSString0x20A CommunicatorOSDLocId;
        /* 0x070 */ public NMSString0x10 CameraShake;
        /* 0x080 */ public TkTextureResource MarkerIcon;
        /* 0x104 */ public float AppearanceDelay;
        /* 0x108 */ public GcAudioWwiseEvents AudioSting;
        /* 0x10C */ public GcFrigateFlybyType FlybyType;
        /* 0x110 */ public GcAudioWwiseEvents PulseAudio;
    }
}
