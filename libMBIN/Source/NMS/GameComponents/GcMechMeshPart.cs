namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DE40488BE597ACC, NameHash = 0x277EF6C0)]
    public class GcMechMeshPart : NMSTemplate
    {
        // size: 0x5
        public enum MechMeshPartEnum : uint {
            Scanner,
            Body,
            Legs,
            LeftArm,
            RightArm,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MechMeshPartEnum MechMeshPart;
    }
}
