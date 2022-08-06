using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9CE0E7AF72E4BE63, NameHash = 0x004D8A5C89BC8B3F)]
    public class TkProceduralInstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public TkProceduralInstanceData[] Data;
    }
}
