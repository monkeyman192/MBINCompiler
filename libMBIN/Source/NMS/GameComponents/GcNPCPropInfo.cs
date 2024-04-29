using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6339D76AC075320, NameHash = 0x9441C44CA7215426)]
    public class GcNPCPropInfo : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcScanEffectData ScanEffect;
        [NMS(Index = 10)]
        /* 0x050 */ public Vector3f AttachRotation;
        [NMS(Index = 9)]
        /* 0x060 */ public Vector3f AttachTranslation;
        [NMS(Index = 8)]
        /* 0x070 */ public NMSString0x10 AttachLocator;
        [NMS(Index = 11)]
        /* 0x080 */ public float AttachScale;
        [NMS(Index = 12)]
        /* 0x084 */ public float AttachScaleGek;
        [NMS(Index = 6)]
        /* 0x088 */ public GcHand DominantHand;
        // size: 0x2
        public enum NPCPropAttachLocationEnum : uint {
            Hand,
            Wrist,
        }
        [NMS(Index = 7)]
        /* 0x08C */ public NPCPropAttachLocationEnum NPCPropAttachLocation;
        [NMS(Index = 5)]
        /* 0x090 */ public GcTechnologyCategory ShopType;
        [NMS(Index = 4)]
        /* 0x094 */ public float Weight;
        [NMS(Index = 0)]
        /* 0x098 */ public NMSString0x80 Model;
        [NMS(Index = 3)]
        /* 0x118 */ public NMSString0x40 ScanEffectNodeName;
        [NMS(Index = 1)]
        /* 0x158 */ public bool Hologram;
    }
}
