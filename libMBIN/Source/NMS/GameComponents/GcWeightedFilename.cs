namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5696276A0988F187, NameHash = 0x48EB1056)]
    public class GcWeightedFilename : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public float Weight;
    }
}
