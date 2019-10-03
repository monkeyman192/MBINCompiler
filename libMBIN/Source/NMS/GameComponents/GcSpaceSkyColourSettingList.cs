using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE8C6C0EE1B649953, NameHash = 0x14C4B281A2FBD940)]
    public class GcSpaceSkyColourSettingList : NMSTemplate      // size: 0x10
    {
	    public List<GcSolarSystemSkyColourData> Settings;
    }
}
