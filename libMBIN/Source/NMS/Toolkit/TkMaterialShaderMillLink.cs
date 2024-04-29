namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD942ACA02AE4846, NameHash = 0xFC506DC8F06CBE6D)]
    public class TkMaterialShaderMillLink : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 InputShuffle;
        [NMS(Index = 5)]
        /* 0x10 */ public NMSString0x10 OutputShuffle;
        [NMS(Index = 6)]
        /* 0x20 */ public int Count;
        [NMS(Index = 0)]
        /* 0x24 */ public int InputNode;
        [NMS(Index = 3)]
        /* 0x28 */ public int OutputNode;
        [NMS(Index = 1)]
        /* 0x2C */ public NMSString0x20 InputConnect;
        [NMS(Index = 4)]
        /* 0x4C */ public NMSString0x20 OutputConnect;
    }
}
