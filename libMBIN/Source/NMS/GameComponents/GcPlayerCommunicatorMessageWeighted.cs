using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79C6766D63B86E6, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        [NMS(Index = 1)]
        /* 0x50 */ public int Weight;
    }
}
