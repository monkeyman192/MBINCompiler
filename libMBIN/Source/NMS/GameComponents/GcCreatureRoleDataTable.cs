using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x999BF59EC4B1D994, NameHash = 0xF460B1FDC0499CEA)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        public List<GcCreatureRoleData> AvailableRoles;
    }
}