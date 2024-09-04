using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF665A1D48202A6B8, NameHash = 0x89F6C9F7)]
    public class GcEggMachineComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 1)]
        /* 0x3F0 */ public int NumInputs;
    }
}
