namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x23007DD371C4B87D, NameHash = 0xDCBDDB64)]
    public class TkNavMeshAreaType : NMSTemplate
    {
        // size: 0x5
        public enum NavMeshAreaTypeEnum : uint {
            Null,
            Terrain,
            Water,
            Normal,
            Auto,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaTypeEnum NavMeshAreaType;
    }
}
