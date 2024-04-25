namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52A5A4E9BF42BBF, NameHash = 0x498BFDCD029948EF)]
    public class GcActionUseType : NMSTemplate
    {
        // size: 0x7
        public enum ActionUseTypeEnum : uint {
            Active,
            ActiveVR,
            ActiveXbox,
            ActivePS4,
            Hidden,
            Debug,
            Obsolete,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ActionUseTypeEnum ActionUseType;
    }
}
