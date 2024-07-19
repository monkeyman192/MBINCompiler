namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC40A2A2CA47998D, NameHash = 0xF6DBD6AA)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
        // size: 0x9
        public enum PersistentBaseTypesEnum : uint {
            HomePlanetBase,
            FreighterBase,
            ExternalPlanetBase,
            CivilianFreighterBase,
            FriendsPlanetBase,
            FriendsFreighterBase,
            SpaceBase,
            GeneratedPlanetBase,
            GeneratedPlanetBaseEdits,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
