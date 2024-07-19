namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x216768598125DA74, NameHash = 0xA85196CE)]
    public class GcMissionGalacticPoint : NMSTemplate
    {
        // size: 0x2
        public enum GalacticPointEnum : uint {
            Atlas,
            BlackHole,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalacticPointEnum GalacticPoint;
    }
}
