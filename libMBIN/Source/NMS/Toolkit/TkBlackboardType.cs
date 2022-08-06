using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA04E5BAD7F2D51E0, NameHash = 0x490DAD35C9B137EF)]
    public class TkBlackboardType : NMSTemplate
    {
        // size: 0x7
        public enum BlackboardTypeEnum { Invalid, Float, Integer, Bool, Id, Vector, Attachment }
        public BlackboardTypeEnum BlackboardType;
    }
}
