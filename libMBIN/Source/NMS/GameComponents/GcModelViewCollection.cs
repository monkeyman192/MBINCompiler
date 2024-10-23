using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC72ADB717866BE3, NameHash = 0xA5C6254C)]
    public class GcModelViewCollection : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2D, EnumType = typeof(GcModelViews.ModelViewsEnum))]
        /* 0x0 */ public TkModelRendererData[] ModelViewData;
    }
}
