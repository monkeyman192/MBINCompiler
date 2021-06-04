using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xF8, Alignment = 0x8, GUID = 0x241F4D1A3F907DC3, NameHash = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        public NMSString0x20 Title;
        public NMSString0x20 Description;
        public NMSString0x20 Image;
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding64;
        public List<GcMissionSequenceDetailMessagePoint> Points;
        public NMSString0x80 DebugText;
    }
}
