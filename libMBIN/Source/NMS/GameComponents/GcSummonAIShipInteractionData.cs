using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x584470C9434B457D, NameHash = 0xAE9A56F1)]
    public class GcSummonAIShipInteractionData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 0)]
        /* 0x20 */ public TkModelResource Resource;
        [NMS(Index = 6)]
        /* 0x40 */ public NMSString0x20A Subtitle;
        // size: 0x2
        public enum ShipRoleEnum : uint {
            Standard,
            Biggs,
        }
        [NMS(Index = 1)]
        /* 0x60 */ public ShipRoleEnum ShipRole;
        [NMS(Index = 4)]
        /* 0x64 */ public GcAudioWwiseEvents WarpInAudio;
        [NMS(Index = 2)]
        /* 0x68 */ public NMSString0x20 LandingNode;
        [NMS(Index = 3)]
        /* 0x88 */ public bool Invincible;
    }
}
