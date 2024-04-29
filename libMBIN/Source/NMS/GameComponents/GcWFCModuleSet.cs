using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC4165E76484A0A4, NameHash = 0x12D00A471DB28074)]
    public class GcWFCModuleSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f BlockSize;
        [NMS(Index = 8)]
        /* 0x10 */ public List<GcIDPair> CompatibleConnectors;
        [NMS(Index = 6)]
        /* 0x20 */ public List<NMSString0x20> ConnectorsOnHorizontalBoundary;
        [NMS(Index = 5)]
        /* 0x30 */ public List<NMSString0x20> ConnectorsOnLowerBoundary;
        [NMS(Index = 4)]
        /* 0x40 */ public List<NMSString0x20> ConnectorsOnUpperBoundary;
        [NMS(Index = 7)]
        /* 0x50 */ public List<NMSString0x10> DefaultGroups;
        [NMS(Index = 3)]
        /* 0x60 */ public List<GcWFCModulePrototype> ModulePrototypes;
        [NMS(Index = 9)]
        /* 0x70 */ public float VerticalOffset;
        [NMS(Index = 0)]
        /* 0x74 */ public NMSString0x20 Name;
        [NMS(Index = 2)]
        /* 0x94 */ public bool ApplyWallThemes;
    }
}
