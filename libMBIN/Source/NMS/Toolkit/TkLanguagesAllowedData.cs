using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x6DAB1474F9B0A50B, NameHash = 0xE421F6E8B9AA4E70)]
    public class TkLanguagesAllowedData : NMSTemplate
    {
        public List<TkLanguages> Allowed;
        public TkLanguages Language;
    }
}