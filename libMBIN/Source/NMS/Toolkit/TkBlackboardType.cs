namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x82614740EF36942A, NameHash = 0x490DAD35C9B137EF)]
    public class TkBlackboardType : NMSTemplate
    {
        // size: 0x7
        public enum BlackboardTypeEnum : uint {
            Invalid,
            Float,
            Integer,
            Bool,
            Id,
            Vector,
            Attachment,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BlackboardTypeEnum BlackboardType;
    }
}
