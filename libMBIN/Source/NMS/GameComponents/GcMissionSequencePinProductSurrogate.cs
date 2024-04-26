namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFC7BAAF4838E40D, NameHash = 0x9571F8DCE4063860)]
    public class GcMissionSequencePinProductSurrogate : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool TakeProductFromSeasonData;
    }
}
