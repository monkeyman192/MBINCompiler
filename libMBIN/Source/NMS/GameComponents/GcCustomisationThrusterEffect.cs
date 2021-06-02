using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xF0, GUID = 0xF88B362A684E947C, NameHash = 0xE7EC6E83CB496A6C)]
    public class GcCustomisationThrusterEffect : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public NMSString0x10 NodeName;
        /* 0x20 */ public bool SingleJet;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        /* 0x28 */ public NMSString0x10 LinkedSpecialID;
        /* 0x38 */ public NMSString0x20A Tip;
        /* 0x58 */ public TkModelResource Trails;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xDC */ public byte[] PaddingDC;
        /* 0xE0 */ public List<GcCharacterJetpackEffect> Effects;
    }
}
