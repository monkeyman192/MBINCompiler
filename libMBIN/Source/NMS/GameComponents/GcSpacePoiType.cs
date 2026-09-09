namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA90F56FBB13253D, NameHash = 0x853D6E0C)]
    public class GcSpacePoiType : NMSTemplate
    {
        // size: 0xE
        public enum SpacePoiTypeEnum : uint {
            AsteroidBelt,
            Hulk,
            Outpost,
            OutpostSlime,
            Star,
            BasePlatform,
            AbandonedFreighter,
            SpaceWhale,
            Flavour,
            Derelict,
            WasteSite,
            IceField,
            BasePlatform_Ice,
            AbandonedBase,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpacePoiTypeEnum SpacePoiType;
    }
}
