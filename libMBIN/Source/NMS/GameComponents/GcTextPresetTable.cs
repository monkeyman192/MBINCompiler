using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8BBDB1EEE1132923, NameHash = 0x6567927C2DD8F89F)]
    public class GcTextPresetTable : NMSTemplate
    {
        public List<GcTextPreset> Table;
    }
}