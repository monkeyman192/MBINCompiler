using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B42254D3D774349, NameHash = 0xBB170982B7A9B162)]
    public class GcPetCustomisationData : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x0 */ public GcCharacterCustomisationSaveData[] Data;
    }
}
