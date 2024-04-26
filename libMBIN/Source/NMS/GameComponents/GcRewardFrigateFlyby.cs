using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69E560DA6DA21BA3, NameHash = 0x3FACFB36175544A6)]
    public class GcRewardFrigateFlyby : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        [NMS(Index = 2)]
        /* 0x050 */ public NMSString0x20A CommunicatorOSDLocId;
        [NMS(Index = 7)]
        /* 0x070 */ public NMSString0x10 CameraShake;
        [NMS(Index = 4)]
        /* 0x080 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 1)]
        /* 0x104 */ public float AppearanceDelay;
        [NMS(Index = 6)]
        /* 0x108 */ public GcAudioWwiseEvents AudioSting;
        [NMS(Index = 0)]
        /* 0x10C */ public GcFrigateFlybyType FlybyType;
        [NMS(Index = 5)]
        /* 0x110 */ public GcAudioWwiseEvents PulseAudio;
    }
}
