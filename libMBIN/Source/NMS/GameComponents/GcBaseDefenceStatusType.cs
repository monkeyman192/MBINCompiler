namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB0EDF75D5C71764, NameHash = 0x4DAF6D9)]
    public class GcBaseDefenceStatusType : NMSTemplate
    {
        // size: 0x5
        public enum BaseDefenceStatusEnum : uint {
            AttackingTarget,
            Alert,
            SearchingForTarget,
            Disabled,
            Security,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseDefenceStatusEnum BaseDefenceStatus;
    }
}
