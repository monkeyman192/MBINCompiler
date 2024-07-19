namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x932FB3213B02066D, NameHash = 0xFACED760)]
    public class GcNetworkInterpolationComponentData : NMSTemplate
    {
        // size: 0x3
        public enum SynchroniseScaleEnum : uint {
            Never,
            Once,
            Always,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SynchroniseScaleEnum SynchroniseScale;
        [NMS(Index = 1)]
        /* 0x4 */ public bool SupportTeleportation;
    }
}
