namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE02DA7E4A80CDBA, NameHash = 0x297A9843)]
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
