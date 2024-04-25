namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x757B2BAB74F6DCCA, NameHash = 0xFED6D433FF718579)]
    public class GcProtectedLocation : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Location;
        [NMS(Index = 1)]
        /* 0x10 */ public float Radius;
    }
}
