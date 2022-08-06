using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7180B3602E9E8EA4, NameHash = 0x52A4BE1415A68ECA)]
    public class GcPlayerControlInputAxis : NMSTemplate
    {
        /* 0x00 */ public GcCharacterControlInputValidity Validity;
        /* 0x04 */ public GcInputActions InputX;
        /* 0x08 */ public GcInputActions InputY;
        /* 0x0C */ public GcCharacterControlOutputSpace OutputSpace;
        /* 0x10 */ public NMSString0x10 Output;
        /* 0x20 */ public NMSString0x10 OutputLength;
    }
}
