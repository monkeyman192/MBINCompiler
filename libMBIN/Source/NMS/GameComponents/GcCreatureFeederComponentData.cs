using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x975C2C96AA4AEB64, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x3E0 */ public List<NMSString0x100> DispenseNodes;
        /* 0x3F0 */ public float DispensePeriod;
        /* 0x3F4 */ public float DispenseVelocity;
        /* 0x3F8 */ public int NumInputs;
        /* 0x3FC */ public int NumMealsPerBait;
    }
}
