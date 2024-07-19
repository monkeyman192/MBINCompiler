namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E7DE3984C771F8B, NameHash = 0x59D52FAF)]
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
