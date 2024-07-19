namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x230219B90746BA91, NameHash = 0x53A81775)]
    public class GcNumberedTextList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Format;
        [NMS(Index = 1)]
        /* 0x10 */ public int Count;
    }
}
