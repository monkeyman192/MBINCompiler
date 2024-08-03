namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7350418BFD74CCC9, NameHash = 0x4629DE2E)]
    public class GcDiscoveryTrimScoringCategory : NMSTemplate
    {
        // size: 0x8
        public enum DiscoveryTrimScoringCategoryEnum : uint {
            IsNamedSystem,
            RecentlyVisitedSystem,
            RecentDiscoveryInSystem,
            NumDiscoveredPlanetsInSystem,
            IsNamedPlanet,
            NumBasesOnPlanet,
            NumWondersOnPlanet,
            NumNamedDiscoveries,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DiscoveryTrimScoringCategoryEnum DiscoveryTrimScoringCategory;
    }
}
