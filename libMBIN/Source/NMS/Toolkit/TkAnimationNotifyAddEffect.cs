using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEBE39A84AEBEDEE9, NameHash = 0x3129A5A6)]
    public class TkAnimationNotifyAddEffect : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Effect;
        [NMS(Index = 7)]
        /* 0x10 */ public List<LinkableNMSTemplate> Modules;
        [NMS(Index = 4)]
        /* 0x20 */ public float FacingDirOffset;
        [NMS(Index = 6)]
        /* 0x24 */ public float Scale;
        [NMS(Index = 1)]
        /* 0x28 */ public NMSString0x40 Node;
        [NMS(Index = 5)]
        /* 0x68 */ public bool Attach;
        [NMS(Index = 2)]
        /* 0x69 */ public bool MirrorDuplicate;
        [NMS(Index = 3)]
        /* 0x6A */ public bool UseModelFacingDir;
    }
}
