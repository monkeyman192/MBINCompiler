namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x111193B7216264B4, NameHash = 0xC2F4FABD9EDAFE6A)]
    public class GcMissionSequenceDetailMessagePoint : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Text;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 InsertItemName;
        // size: 0x3
        public enum PointStateEnum : uint {
            Statement,
            ObjectiveIncomplete,
            ObjectiveComplete,
        }
        [NMS(Index = 1)]
        /* 0x30 */ public PointStateEnum PointState;
    }
}
