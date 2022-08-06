using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0B4CFCD8E9DD36F8, NameHash = 0x2F2FAFA4A7023B71)]
    public class GcProjectileImpactData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Effect;
        /* 0x10 */ public GcProjectileImpactType Impact;
        // size: 0x2
        public enum ImpactAlignmentEnum { ImpactNormal, GravityUp }
        /* 0x14 */ public ImpactAlignmentEnum ImpactAlignment;
        // size: 0x2
        public enum ImpactAttachmentEnum { World, HitBody }
        /* 0x18 */ public ImpactAttachmentEnum ImpactAttachment;
    }
}
