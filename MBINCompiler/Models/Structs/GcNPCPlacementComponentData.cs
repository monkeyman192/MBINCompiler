using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcNPCPlacementComponentData : NMSTemplate // 0x20 bytes
    {
        public bool SearchPlacementFromMaster;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Padding0x1;
        public List<NMSString0x10> PlacementInfosToApply;
    }
}
