namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4AB8E1414D82EDB, NameHash = 0x25C87553CE78E1FD)]
    public class GcColourModifier : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour ForceColourTo;
        [NMS(Index = 4)]
        /* 0x10 */ public float MultiplySaturation;
        [NMS(Index = 5)]
        /* 0x14 */ public float MultiplyValue;
        [NMS(Index = 2)]
        /* 0x18 */ public float OffsetSaturation;
        [NMS(Index = 3)]
        /* 0x1C */ public float OffsetValue;
        [NMS(Index = 0)]
        /* 0x20 */ public bool ForceColour;
    }
}
