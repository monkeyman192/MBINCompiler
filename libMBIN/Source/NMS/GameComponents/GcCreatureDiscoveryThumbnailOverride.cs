namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FE62C4ED5A28A72, NameHash = 0xF81E00514EB73ED9)]
    public class GcCreatureDiscoveryThumbnailOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f DiscoveryUIOffset;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20A ContainsDescriptor;
        [NMS(Index = 1)]
        /* 0x30 */ public float DiscoveryUIScaler;
    }
}
