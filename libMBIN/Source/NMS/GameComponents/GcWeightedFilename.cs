namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE7A412C193FF51D, NameHash = 0x7AC84D51C8490F18)]
    public class GcWeightedFilename : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Weight;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x80 Filename;
    }
}
