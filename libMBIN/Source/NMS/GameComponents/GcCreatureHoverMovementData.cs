using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xE99E4FE45AEFCBF3, NameHash = 0xFA76C7A4963051DC)]
    public class GcCreatureHoverMovementData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureHoverMovementDataParams> Params;
    }
}