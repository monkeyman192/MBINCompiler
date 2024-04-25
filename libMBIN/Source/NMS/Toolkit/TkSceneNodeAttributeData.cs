namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3584805A4D182B6F, NameHash = 0x502F1C3425CDC8EC)]
    public class TkSceneNodeAttributeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A AltID;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x100 Value;
    }
}
