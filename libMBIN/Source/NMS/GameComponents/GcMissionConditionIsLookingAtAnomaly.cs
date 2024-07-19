namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDAF1A6865541C28, NameHash = 0x59139D1E)]
    public class GcMissionConditionIsLookingAtAnomaly : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float FOV;
        [NMS(Index = 1)]
        /* 0x4 */ public float MaxDistance;
    }
}
