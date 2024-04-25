using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFC2C403668DBF4E, NameHash = 0xD595098569C459AF)]
    public class GcPersistencyMissionOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x10 */ public GcInteractionBufferType Buffer;
    }
}
