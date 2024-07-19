namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2DCF121DF2441C33, NameHash = 0x8A7C77D6)]
    public class TkMaterialResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 1)]
        /* 0x10 */ public GcResource ResHandle;
    }
}
