using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8CCEB6CA5D54EF40, NameHash = 0x6B329F862808895A)]
    public class GcCustomisationPreset : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcCharacterCustomisationData Data;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 Name;
    }
}
