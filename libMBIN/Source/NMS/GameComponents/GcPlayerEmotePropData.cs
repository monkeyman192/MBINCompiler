using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E4771511FBAD7C7, NameHash = 0x7E08658A660A58D4)]
    public class GcPlayerEmotePropData : NMSTemplate
    {
        /* 0x000 */ public GcScanEffectData ScanEffect;
        /* 0x050 */ public float DelayTime;
        /* 0x054 */ public GcHand Hand;
        /* 0x058 */ public float Scale;
        /* 0x05C */ public NMSString0x80 Model;
        /* 0x0DC */ public NMSString0x40 ScanEffectNodeName;
        /* 0x11C */ public bool IsHologram;
    }
}
