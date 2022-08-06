using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF7DD6630B364951, NameHash = 0xD595098569C459AF)]
    public class GcPersistencyMissionOverride : NMSTemplate
    {
        public NMSString0x10 Mission;
        public GcInteractionBufferType Buffer;
    }
}
