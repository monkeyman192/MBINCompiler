using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x6ADBE382DEC7165A, NameHash = 0x87FB8E825C599E66)]
    public class GcDefaultMissionItemsTable : NMSTemplate
    {
        public List<GcDefaultMissionSubstance> PrimarySubstances;
        public List<GcDefaultMissionSubstance> SecondarySubstances;
        public List<GcDefaultMissionProduct> PrimaryProducts;
        public List<GcDefaultMissionProduct> SecondaryProducts;
    }
}
