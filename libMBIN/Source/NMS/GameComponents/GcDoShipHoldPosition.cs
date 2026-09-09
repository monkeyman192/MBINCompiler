namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91F8897BC29585E8, NameHash = 0x157111C1)]
    public class GcDoShipHoldPosition : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public float Radius;
        [NMS(Index = 2)]
        /* 0x14 */ public float RepositionTime;
    }
}
