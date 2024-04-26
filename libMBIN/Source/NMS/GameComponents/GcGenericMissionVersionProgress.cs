namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96700E1F77200278, NameHash = 0x8E2443E0F5BE1DD5)]
    public class GcGenericMissionVersionProgress : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Progress;
        [NMS(Index = 0)]
        /* 0x4 */ public int Version;
    }
}
