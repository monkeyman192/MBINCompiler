using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3992E347EBBCE00, NameHash = 0x66A36B9D)]
    public class GcPersistencyMissionOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x10 */ public GcInteractionBufferType Buffer;
    }
}
