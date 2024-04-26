using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98ACD53757126EE1, NameHash = 0x22FF5652DE949103)]
    public class GcBaseDefenceStatusAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBaseDefenceStatusType TryState;
    }
}
