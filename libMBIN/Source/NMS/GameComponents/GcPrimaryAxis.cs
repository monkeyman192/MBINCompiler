namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73409D6BF75AFA73, NameHash = 0xB8FF33E4)]
    public class GcPrimaryAxis : NMSTemplate
    {
        // size: 0x6
        public enum PrimaryAxisEnum : uint {
            Z,
            ZNeg,
            X,
            XNeg,
            Y,
            YNeg,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PrimaryAxisEnum PrimaryAxis;
    }
}
