using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x717FDA53500C424, NameHash = 0x12D00A471DB28074)]
    public class GcWFCModuleSet : NMSTemplate
    {
        /* 0x00 */ public Vector3f BlockSize;
        /* 0x10 */ public List<GcIDPair> CompatibleConnectors;
        /* 0x20 */ public List<NMSString0x20> ConnectorsOnHorizontalBoundary;
        /* 0x30 */ public List<NMSString0x20> ConnectorsOnLowerBoundary;
        /* 0x40 */ public List<NMSString0x20> ConnectorsOnUpperBoundary;
        /* 0x50 */ public List<NMSString0x10> DefaultGroups;
        /* 0x60 */ public List<GcWFCModulePrototype> ModulePrototypes;
        /* 0x70 */ public float VerticalOffset;
        /* 0x74 */ public NMSString0x20 Name;
        /* 0x94 */ public bool ApplyWallThemes;
    }
}
