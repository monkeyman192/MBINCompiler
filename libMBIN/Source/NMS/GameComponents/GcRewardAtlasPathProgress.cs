namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8C644082DD75439, NameHash = 0xA653F09B)]
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
        // size: 0x3
        public enum AtlasPathProgressTypeEnum : uint {
            IncrementPathProgress,
            FinalStoryAtlas,
            StoreLoopingCompleteStations,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AtlasPathProgressTypeEnum AtlasPathProgressType;
    }
}
