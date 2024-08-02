using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70470D62093A8EF6, NameHash = 0x7DA2A291)]
    public class GcRewardFrigateFlyby : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcPlayerCommunicatorMessage CommunicatorMessage;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x20A CommunicatorOSDLocId;
        [NMS(Index = 4)]
        /* 0x70 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 7)]
        /* 0x88 */ public NMSString0x10 CameraShake;
        [NMS(Index = 1)]
        /* 0x98 */ public float AppearanceDelay;
        [NMS(Index = 6)]
        /* 0x9C */ public GcAudioWwiseEvents AudioSting;
        [NMS(Index = 0)]
        /* 0xA0 */ public GcFrigateFlybyType FlybyType;
        [NMS(Index = 5)]
        /* 0xA4 */ public GcAudioWwiseEvents PulseAudio;
    }
}
