namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA29D94AF2FEE9F5E, NameHash = 0x9A2C38CB)]
    public class TkSceneNodeAttributeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString Value;
    }
}
