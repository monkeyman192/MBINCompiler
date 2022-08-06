using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x027D448CFBAD0D82, NameHash = 0xE57F8ACB51D80972)]
    public class TkInputValidation : NMSTemplate
    {
        // size: 0x4
        public enum InputValidationEnum { Held, Pressed, Released, HeldOver }
        /* 0x0 */ public InputValidationEnum InputValidation;
    }
}
