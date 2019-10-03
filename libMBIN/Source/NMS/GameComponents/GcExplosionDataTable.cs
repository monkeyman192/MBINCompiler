using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3BA24F87324BCCC6, NameHash = 0xF9FB8E431EB1179F)]
    public class GcExplosionDataTable : NMSTemplate
    {
        public List<GcExplosionData> Table;
    }
}
