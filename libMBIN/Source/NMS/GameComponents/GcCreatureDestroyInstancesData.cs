namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E80F72EEDED813D, NameHash = 0xB4DB6AA2)]
    public class GcCreatureDestroyInstancesData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Offset;
        [NMS(Index = 2)]
        /* 0x10 */ public float MinInstanceRadius;
        [NMS(Index = 0)]
        /* 0x14 */ public float Radius;
        [NMS(Index = 3)]
        /* 0x18 */ public bool DebugDraw;
    }
}
