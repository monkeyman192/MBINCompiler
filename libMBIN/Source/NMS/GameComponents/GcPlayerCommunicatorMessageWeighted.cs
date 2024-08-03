using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C3960041BD121A2, NameHash = 0xA82989A1)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        [NMS(Index = 1)]
        /* 0x50 */ public int Weight;
    }
}
