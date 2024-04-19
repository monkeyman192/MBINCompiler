using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2639E8BCA820BC3C, NameHash = 0x44CED54C76C8DDA0)]
    public class GcClothAttachmentLine : NMSTemplate
    {
        /* 0x00 */ public AxisSpecification ClothDirection;
        /* 0x20 */ public Vector3f End;
        /* 0x30 */ public Vector3f Start;
        /* 0x40 */ public float AttractionStartDistance;
        /* 0x44 */ public float AttractionStrength;
        /* 0x48 */ public float EndIFraction;
        /* 0x4C */ public float JStepDistanceOverride;
        /* 0x50 */ public int NumRowsOfSameJToFix;
        /* 0x54 */ public int RowToFixJ;
        /* 0x58 */ public float StartIFraction;
        /* 0x5C */ public NMSString0x40 BoneName;
        /* 0x9C */ public NMSString0x40 DebugName;
        /* 0xDC */ public bool Enabled;
    }
}
