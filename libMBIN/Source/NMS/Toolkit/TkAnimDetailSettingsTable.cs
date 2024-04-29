using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8265D6A8C7AD608, NameHash = 0xC1032FBFB34EDA05)]
    public class TkAnimDetailSettingsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x0 */ public TkAnimDetailSettings[] Table;
    }
}
