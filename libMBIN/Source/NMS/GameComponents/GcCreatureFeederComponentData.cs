using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x260, GUID = 0xA434828C37D701EF, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x240 */ public int NumInputs;
        /* 0x244 */ public int NumMealsPerBait;
        /* 0x248 */ public List<NMSString0x100> DispenseNodes;
        /* 0x258 */ public float DispenseVelocity;
        /* 0x25C */ public float DispensePeriod;
    }
}
