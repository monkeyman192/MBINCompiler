using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0x6A79A5924840FD6F, NameHash = 0x62232E26DA2D21F1)]
    public class GcCharacterJetpackEffect : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 NodeName;
        /* 0x100 */ public NMSString0x10 Effect;
    }
}
