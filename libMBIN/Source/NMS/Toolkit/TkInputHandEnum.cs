namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCB7BDE80465F24BC, NameHash = 0xBB6D663E)]
    public class TkInputHandEnum : NMSTemplate
    {
        // size: 0x3
        public enum InputHandEnum : uint {
            None,
            Left,
            Right,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InputHandEnum InputHand;
    }
}
