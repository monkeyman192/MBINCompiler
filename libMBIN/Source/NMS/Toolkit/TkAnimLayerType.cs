namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2CE445CA3F7A06B0, NameHash = 0xB55DFD7A)]
    public class TkAnimLayerType : NMSTemplate
    {
        // size: 0x2
        public enum AnimLayerTypeEnum : uint {
            SingleSequence,
            AdditiveStack,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AnimLayerTypeEnum AnimLayerType;
    }
}
