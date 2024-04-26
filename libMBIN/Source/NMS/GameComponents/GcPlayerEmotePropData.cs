using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E4771511FBAD7C7, NameHash = 0x7E08658A660A58D4)]
    public class GcPlayerEmotePropData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public GcScanEffectData ScanEffect;
        [NMS(Index = 6)]
        /* 0x050 */ public float DelayTime;
        [NMS(Index = 2)]
        /* 0x054 */ public GcHand Hand;
        [NMS(Index = 1)]
        /* 0x058 */ public float Scale;
        [NMS(Index = 0)]
        /* 0x05C */ public NMSString0x80 Model;
        [NMS(Index = 4)]
        /* 0x0DC */ public NMSString0x40 ScanEffectNodeName;
        [NMS(Index = 3)]
        /* 0x11C */ public bool IsHologram;
    }
}
