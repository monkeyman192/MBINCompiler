using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xB71A10E23C5105BD, NameHash = 0x8A61B341C43F08CE)]
    public class GcBaseBuildingProperties : NMSTemplate
    {
        public NMSString0x10 DefaultInBaseObject;
        public NMSString0x10 DefaultOnTerrainObject;
        public NMSString0x10 DefaultInFreighterObject;
    }
}