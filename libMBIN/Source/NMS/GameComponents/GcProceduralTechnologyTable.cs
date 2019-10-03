using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7917ED329F0F1E74, NameHash = 0x80ED6EE04AC8D620)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        public List<GcProceduralTechnologyData> Table;
    }
}
