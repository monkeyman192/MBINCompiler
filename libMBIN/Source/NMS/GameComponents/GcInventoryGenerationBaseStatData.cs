using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEE43876427F39D95)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate     // size: 0x40
    {
        [NMS( EnumType = typeof( GcInventoryClass.InventoryClassEnum ) )]
        public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;

    }
}
