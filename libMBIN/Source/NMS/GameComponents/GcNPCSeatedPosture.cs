namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A01B0DDBBB3040D, NameHash = 0xDE7AA917D5163592)]
    public class GcNPCSeatedPosture : NMSTemplate
    {
        // size: 0x2
        public enum NPCSeatedPostureEnum : uint {
            Sofa,
            Sit,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCSeatedPostureEnum NPCSeatedPosture;
    }
}
