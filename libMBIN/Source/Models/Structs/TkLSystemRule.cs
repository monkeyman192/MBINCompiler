using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkLSystemRule : NMSTemplate // 0xB8 bytes
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemInnerRule> Rules;

		public enum RuleTypeEnum { Default, BaseRule }
		public RuleTypeEnum RuleType;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
    }
}
