namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CEFD7C337BEB1A6, NameHash = 0x8A61B341C43F08CE)]
    public class GcBaseBuildingProperties : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DefaultInBaseObject;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 DefaultInFreighterObject;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 DefaultOnTerrainObject;
    }
}
