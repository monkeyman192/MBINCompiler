using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x215C28B6182D7736, NameHash = 0xC2E15A4C)]
    public class GcNPCPropInfo : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcScanEffectData ScanEffect;
        [NMS(Index = 10)]
        /* 0x50 */ public Vector3f AttachRotation;
        [NMS(Index = 9)]
        /* 0x60 */ public Vector3f AttachTranslation;
        [NMS(Index = 8)]
        /* 0x70 */ public NMSString0x10 AttachLocator;
        [NMS(Index = 0)]
        /* 0x80 */ public VariableSizeString Model;
        [NMS(Index = 11)]
        /* 0x90 */ public float AttachScale;
        [NMS(Index = 12)]
        /* 0x94 */ public float AttachScaleGek;
        [NMS(Index = 6)]
        /* 0x98 */ public GcHand DominantHand;
        // size: 0x2
        public enum NPCPropAttachLocationEnum : uint {
            Hand,
            Wrist,
        }
        [NMS(Index = 7)]
        /* 0x9C */ public NPCPropAttachLocationEnum NPCPropAttachLocation;
        [NMS(Index = 5)]
        /* 0xA0 */ public GcTechnologyCategory ShopType;
        [NMS(Index = 4)]
        /* 0xA4 */ public float Weight;
        [NMS(Index = 3)]
        /* 0xA8 */ public NMSString0x40 ScanEffectNodeName;
        [NMS(Index = 1)]
        /* 0xE8 */ public bool Hologram;
    }
}
