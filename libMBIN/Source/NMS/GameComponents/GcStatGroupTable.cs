using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB3B6D25E12E7E323, NameHash = 0xE07E83B8A167074C)]
    public class GcStatGroupTable : NMSTemplate
    {
        public List<GcStatGroupData> Table; // called GcStatGroupTable in exe, C# won't let us use same name as class for members though
    }
}
