using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A4180B133DE2091, NameHash = 0x3DB43D88)]
    public class GcSpacePoiFrigateFlyByData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFrigateFlyByData Default;
        [NMS(Index = 1)]
        /* 0x78 */ public GcFrigateFlyByData FirstTime;
    }
}
