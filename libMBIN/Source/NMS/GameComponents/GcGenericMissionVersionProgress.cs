namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA268E5F835875CA1, NameHash = 0x783396CB)]
    public class GcGenericMissionVersionProgress : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Progress;
        [NMS(Index = 0)]
        /* 0x4 */ public int Version;
    }
}
