using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x84, GUID = 0xF005EB359A724BF3, NameHash = 0x6A64F8439AFA975E)]
    public class GcMissionSequenceDisplaySeasonRewardReminder : NMSTemplate
    {
        public float Time;
        public NMSString0x80 DebugText;
    }
}
