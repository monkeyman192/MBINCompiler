using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFE503907772D1DA8, NameHash = 0x338F3FF)]
    public class TkAnimDetailSettingsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x0 */ public TkAnimDetailSettings[] Table;
    }
}
