using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C26329D3938695C, NameHash = 0x0DF042CD9CF0C561)]
    public class GcFiendCrimeAction : NMSTemplate
    {
        /* 0x0 */ public GcFiendCrime FiendCrimeType;
        /* 0x4 */ public float FiendCrimeModifier;
    }
}
