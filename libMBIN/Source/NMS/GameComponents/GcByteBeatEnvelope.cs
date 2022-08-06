using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2105B955658DFDC2, NameHash = 0x3D8CDA50E9CD9F10)]
    public class GcByteBeatEnvelope : NMSTemplate
    {
        public enum ByteBeatEnvelopeEnum { Short, Med, Long }
        public ByteBeatEnvelopeEnum ByteBeatEnvelope;
    }
}
