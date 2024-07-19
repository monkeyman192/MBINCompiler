namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x635E111355635441, NameHash = 0x8FCECF92)]
    public class TkAnimBlendType : NMSTemplate
    {
        // size: 0x4
        public enum BlendTypeEnum : uint {
            Normal,
            MatchTimes,
            MatchTimesAndPhase,
            OffsetByBlendTime,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BlendTypeEnum BlendType;
    }
}
