namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4B5C37A3762BAC6, NameHash = 0x53D4BE4FC748998A)]
    public class GcSaveContextQuery : NMSTemplate
    {
        // size: 0x5
        public enum SaveContextQueryEnum : uint {
            DontCare,
            Season,
            Main,
            NoSeason,
            NoMain,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SaveContextQueryEnum SaveContextQuery;
    }
}
