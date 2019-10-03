using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x3A120DFE869BC529, NameHash = 0xC2F4FABD9EDAFE6A)]
    public class GcMissionSequenceDetailMessagePoint : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Text;
        public enum PointStateEnum { Statement, ObjectiveIncomplete, ObjectiveComplete }
        public PointStateEnum PointState;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding24;
        [NMS(Size = 0x10)]
        public string InsertItemName;
    }
}
