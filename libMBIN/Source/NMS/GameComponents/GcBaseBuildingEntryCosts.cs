namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE84845AB3262787, NameHash = 0x2229006A022A6430)]
    public class GcBaseBuildingEntryCosts : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float Active0AverageFrameTimeCost;
        /* 0x14 */ public float Active1AverageFrameTimeCost;
        /* 0x18 */ public int ActivePhysicsComponents;
        /* 0x1C */ public int ActiveTotalNodes;
        /* 0x20 */ public float Inactive0AverageFrameTimeCost;
        /* 0x24 */ public float Inactive1AverageFrameTimeCost;
        /* 0x28 */ public int InactivePhysicsComponents;
        /* 0x2C */ public int InactiveTotalNodes;
    }
}
