using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x268C07FA59329E8A, NameHash = 0x9441C44CA7215426)]
    public class GcNPCPropInfo : NMSTemplate
    {
        /* 0x000 */ public GcScanEffectData ScanEffect;
        /* 0x050 */ public Vector3f AttachRotation;
        /* 0x060 */ public Vector3f AttachTranslation;
        /* 0x070 */ public NMSString0x10 AttachLocator;
        /* 0x080 */ public float AttachScale;
        /* 0x084 */ public float AttachScaleGek;
        /* 0x088 */ public GcHand DominantHand;
        // size: 0x2
        public enum NPCPropAttachLocationEnum : uint {
            Hand,
            Wrist,
        }
        /* 0x08C */ public NPCPropAttachLocationEnum NPCPropAttachLocation;
        /* 0x090 */ public GcTechnologyCategory ShopType;
        /* 0x094 */ public float Weight;
        /* 0x098 */ public NMSString0x80 Model;
        /* 0x118 */ public NMSString0x40 ScanEffectNodeName;
        /* 0x158 */ public bool Hologram;
    }
}
