namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FA127BEE4B8871A, NameHash = 0xFC3C64D0A5373C54)]
    public class GcCreaturePetTraitRange : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Max;
        [NMS(Index = 0)]
        /* 0x4 */ public float Min;
    }
}
