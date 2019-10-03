﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xDA6DE6D9EF7C851E, NameHash = 0xA810D19A70E87E0C)]
    public class GcCharacterAlternateAnimation : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
        [NMS(Size = 0x10)]
        public string Replacement;
    }
}
