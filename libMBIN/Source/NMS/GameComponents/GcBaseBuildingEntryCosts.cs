namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x814877F23524DE30, NameHash = 0x2229006A022A6430)]
    public class GcBaseBuildingEntryCosts : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public float Active0AverageFrameTimeCost;
        [NMS(Index = 2)]
        /* 0x14 */ public float Active1AverageFrameTimeCost;
        [NMS(Index = 4)]
        /* 0x18 */ public int ActivePhysicsComponents;
        [NMS(Index = 3)]
        /* 0x1C */ public int ActiveTotalNodes;
        [NMS(Index = 5)]
        /* 0x20 */ public float Inactive0AverageFrameTimeCost;
        [NMS(Index = 6)]
        /* 0x24 */ public float Inactive1AverageFrameTimeCost;
        [NMS(Index = 8)]
        /* 0x28 */ public int InactivePhysicsComponents;
        [NMS(Index = 7)]
        /* 0x2C */ public int InactiveTotalNodes;
    }
}
