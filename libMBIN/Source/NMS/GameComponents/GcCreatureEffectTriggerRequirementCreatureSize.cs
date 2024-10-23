namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BE6ED1768B2EED2, NameHash = 0x8E0BDE4C)]
    public class GcCreatureEffectTriggerRequirementCreatureSize : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float MaxCreatureSize;
        [NMS(Index = 0)]
        /* 0x4 */ public float MinCreatureSize;
    }
}
