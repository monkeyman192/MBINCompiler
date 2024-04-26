using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2639E8BCA820BC3C, NameHash = 0x44CED54C76C8DDA0)]
    public class GcClothAttachmentLine : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public AxisSpecification ClothDirection;
        [NMS(Index = 4)]
        /* 0x20 */ public Vector3f End;
        [NMS(Index = 3)]
        /* 0x30 */ public Vector3f Start;
        [NMS(Index = 9)]
        /* 0x40 */ public float AttractionStartDistance;
        [NMS(Index = 8)]
        /* 0x44 */ public float AttractionStrength;
        [NMS(Index = 11)]
        /* 0x48 */ public float EndIFraction;
        [NMS(Index = 12)]
        /* 0x4C */ public float JStepDistanceOverride;
        [NMS(Index = 6)]
        /* 0x50 */ public int NumRowsOfSameJToFix;
        [NMS(Index = 7)]
        /* 0x54 */ public int RowToFixJ;
        [NMS(Index = 10)]
        /* 0x58 */ public float StartIFraction;
        [NMS(Index = 2)]
        /* 0x5C */ public NMSString0x40 BoneName;
        [NMS(Index = 1)]
        /* 0x9C */ public NMSString0x40 DebugName;
        [NMS(Index = 0)]
        /* 0xDC */ public bool Enabled;
    }
}
