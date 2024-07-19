using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33047BD3EEE81AFB, NameHash = 0xDC769B4C)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcPlayerEmote> Emotes;
    }
}
