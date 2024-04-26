namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1B02DB69EA6A94CE, NameHash = 0x5E56509F076091B0)]
    public class TkNavMeshAreaType : NMSTemplate
    {
        // size: 0x4
        public enum NavMeshAreaTypeEnum : uint {
            Null,
            Obstacle,
            Ground,
            Water,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaTypeEnum NavMeshAreaType;
    }
}
