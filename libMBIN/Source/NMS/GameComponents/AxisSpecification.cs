namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE064B06A0D53FBE6, NameHash = 0xE46A33ECA1AA62F7)]
    public class AxisSpecification : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f CustomAxis;
        // size: 0x7
        public enum AxisEnum : uint {
            X,
            Y,
            Z,
            NegativeX,
            NegativeY,
            NegativeZ,
            CustomAxis,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public AxisEnum Axis;
    }
}
