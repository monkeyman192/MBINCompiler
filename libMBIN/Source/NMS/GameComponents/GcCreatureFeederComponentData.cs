using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3A381137AAFB8A2, NameHash = 0x32EF8A95)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 3)]
        /* 0x3F0 */ public List<NMSString0x100> DispenseNodes;
        [NMS(Index = 5)]
        /* 0x400 */ public float DispensePeriod;
        [NMS(Index = 4)]
        /* 0x404 */ public float DispenseVelocity;
        [NMS(Index = 1)]
        /* 0x408 */ public int NumInputs;
        [NMS(Index = 2)]
        /* 0x40C */ public int NumMealsPerBait;
    }
}
