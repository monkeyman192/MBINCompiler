namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DD48563EABDB3FD, NameHash = 0x86E6B8042A598341)]
    public class GcMechMeshType : NMSTemplate
    {
        // size: 0x2
        public enum MechMeshTypeEnum : uint {
            Exocraft,
            Sentinel,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MechMeshTypeEnum MechMeshType;
    }
}
