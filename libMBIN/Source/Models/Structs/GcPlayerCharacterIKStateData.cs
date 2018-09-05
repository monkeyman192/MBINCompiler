using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        public GcPlayerCharacterStateType State;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        public GcPlayerCharacterIKOverrideData Data;
        public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
    }
}
