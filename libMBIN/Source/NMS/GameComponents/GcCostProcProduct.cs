using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x1173D724BD8F4D3E, NameHash = 0x2D9EAD5F5CF5EAF6)]
    public class GcCostProcProduct : NMSTemplate
    {
        /* 0x0 */ public GcProceduralProductCategory Type;
        /* 0x4 */ public int FreighterPasswordIndex;
    }
}
