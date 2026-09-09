namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB59774097D7805A6, NameHash = 0xF6DBD6AA)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
        // size: 0x14
        public enum PersistentBaseTypesEnum : uint {
            HomePlanetBase,
            FreighterBase,
            ExternalPlanetBase,
            CivilianFreighterBase,
            FriendsPlanetBase,
            FriendsFreighterBase,
            PlayerSpaceBase,
            FriendsSpaceBase,
            ExternalSpaceBase,
            CivilianSpaceBase,
            GeneratedPlanetBase,
            GeneratedPlanetBaseEdits,
            PlayerShipBase,
            FriendsShipBase,
            UITempShipBase,
            ShipBaseScratch,
            PlayerSpaceStationBase,
            FriendsSpaceStationBase,
            ExternalSpaceStationBase,
            CivilianSpaceStationBase,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
