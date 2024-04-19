namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D237CCE7DD21A46, NameHash = 0x25C87553CE78E1FD)]
    public class GcColourModifier : NMSTemplate
    {
        /* 0x00 */ public Colour ForceColourTo;
        /* 0x10 */ public float MultiplySaturation;
        /* 0x14 */ public float MultiplyValue;
        /* 0x18 */ public float OffsetSaturation;
        /* 0x1C */ public float OffsetValue;
        /* 0x20 */ public bool ForceColour;
    }
}
