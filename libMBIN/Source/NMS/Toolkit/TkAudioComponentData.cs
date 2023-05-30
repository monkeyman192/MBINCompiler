using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAudioComponentData : NMSTemplate
    {
        public NMSString0x80 Ambient;

        public int MaxDistance;

        public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
