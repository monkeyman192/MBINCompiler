namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD80E9187D6043871, NameHash = 0x3D8CDA50E9CD9F10)]
    public class GcByteBeatEnvelope : NMSTemplate
    {
        // size: 0x3
        public enum ByteBeatEnvelopeEnum : uint {
            Short,
            Med,
            Long,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ByteBeatEnvelopeEnum ByteBeatEnvelope;
    }
}
