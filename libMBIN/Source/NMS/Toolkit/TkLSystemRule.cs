using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkLSystemRule : NMSTemplate // 0xB8 bytes
    {
        public NMSString0x20 Name;
        public NMSString0x80 Model;

        public List<TkLSystemInnerRule> Rules;

        public int RuleType;
        public string[] RuleTypeValues()
        {
            return new[] { "Default", "BaseRule" };
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
    }
}
