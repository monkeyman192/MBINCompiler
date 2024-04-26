using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7812F4C3114A1C01, NameHash = 0xC1032FBFB34EDA05)]
    public class TkAnimDetailSettingsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x0 */ public TkAnimDetailSettings[] Table;
    }
}
