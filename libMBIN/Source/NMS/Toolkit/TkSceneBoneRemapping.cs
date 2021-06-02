using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x100, GUID = 0x9DF0F7BB841342CD, NameHash = 0x8EBBD5819BF9FEBA)]
    public class TkSceneBoneRemapping : NMSTemplate
    {
        public NMSString0x80 FromBone;
        public NMSString0x80 ToBone;
    }
}
