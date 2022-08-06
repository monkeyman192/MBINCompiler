using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x777A6CE80F557DD3, NameHash = 0x3748852F6280E90F)]
    public class GcSpecialPetChatType : NMSTemplate
    {
        // size: 0x2
        public enum SpecialPetChatTypeEnum { Monster, Quad }
        /* 0x0 */ public SpecialPetChatTypeEnum SpecialPetChatType;
    }
}
