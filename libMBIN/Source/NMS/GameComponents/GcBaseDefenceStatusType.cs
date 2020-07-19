using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x6EAB672EC97BB160, NameHash = 0x10D5ED9C9EE19797)]
    public class GcBaseDefenceStatusType : NMSTemplate
    {
        public enum BaseDefenceStatusenum { AttackingTarget, Alert, SearchingForTarget, Disabled, Security };
        /* 0x0 */ public BaseDefenceStatusenum BaseDefenceStatus;
}
}
