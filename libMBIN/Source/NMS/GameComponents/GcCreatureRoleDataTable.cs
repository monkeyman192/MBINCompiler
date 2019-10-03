using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x80F2CAFEE19EEA2D, NameHash = 0xF460B1FDC0499CEA)]
    public class GcCreatureRoleDataTable : NMSTemplate
    {
        public List<GcCreatureRoleData> AvailableRoles;
    }
}
