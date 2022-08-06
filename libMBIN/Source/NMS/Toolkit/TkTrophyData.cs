using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x3C2D30DB140CBF81, NameHash = 0x75302EADC2AAED35)]
    public class TkTrophyData : NMSTemplate
    {
        public List<TkTrophyEntry> Trophies;
    }
}