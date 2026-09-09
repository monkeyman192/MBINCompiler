namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DD466BDC4CBCD5D, NameHash = 0x5299235D)]
    public class GcSolarSystemMapObjectType : NMSTemplate
    {
        // size: 0x9
        public enum SolarSystemMapObjectTypeEnum : uint {
            Player,
            RemotePlayer,
            SpaceStation,
            AtlasStation,
            Blackhole,
            Planet,
            GasGiant,
            SpacePoi,
            SpaceBase,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SolarSystemMapObjectTypeEnum SolarSystemMapObjectType;
    }
}
