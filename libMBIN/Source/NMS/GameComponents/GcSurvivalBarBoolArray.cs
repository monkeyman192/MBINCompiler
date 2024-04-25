using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x421515CBE9E0A82, NameHash = 0xF323538389A223A0)]
    public class GcSurvivalBarBoolArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcPlayerSurvivalBarType.SurvivalBarEnum))]
        /* 0x0 */ public bool[] Values;
    }
}
