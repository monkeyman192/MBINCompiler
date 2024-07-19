namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFC7BAAF4838E40D, NameHash = 0x38E736CE)]
    public class GcMissionSequencePinProductSurrogate : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool TakeProductFromSeasonData;
    }
}
