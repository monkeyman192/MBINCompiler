namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F63C998C5A9B8A5, NameHash = 0xAF70C2375D409B6F)]
    public class GcPlayerEffectsComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float VehicleInOutDissolveDelay;
        [NMS(Index = 1)]
        /* 0x4 */ public float VehicleInOutEffectDelay;
        [NMS(Index = 0)]
        /* 0x8 */ public float VehicleInOutTime;
    }
}
