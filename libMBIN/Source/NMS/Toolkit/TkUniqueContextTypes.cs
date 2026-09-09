namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3D0B420CE7A3861E, NameHash = 0x24EBA11D)]
    public class TkUniqueContextTypes : NMSTemplate
    {
        // size: 0x9
        public enum UniqueContextTypeEnum : uint {
            Debug,
            Generic,
            Environment,
            Building,
            Event,
            BaseObject,
            Dungeon,
            SpecialNPC,
            POISmartObjectGroup,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public UniqueContextTypeEnum UniqueContextType;
    }
}
