namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE65D5CBB36B34770, NameHash = 0xB85DD068)]
    public class TkPhysicsData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float AngularDamping;
        [NMS(Index = 1)]
        /* 0x04 */ public float Friction;
        [NMS(Index = 5)]
        /* 0x08 */ public float Gravity;
        [NMS(Index = 4)]
        /* 0x0C */ public float LinearDamping;
        [NMS(Index = 0)]
        /* 0x10 */ public float Mass;
        [NMS(Index = 2)]
        /* 0x14 */ public float RollingFriction;
    }
}
