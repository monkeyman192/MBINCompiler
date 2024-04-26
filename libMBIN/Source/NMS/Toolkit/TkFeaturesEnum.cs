namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x21B18A160AD77B69, NameHash = 0x34E815E84B84D42B)]
    public class TkFeaturesEnum : NMSTemplate
    {
        // size: 0x7
        public enum FeatureTypesEnum : uint {
            River,
            Crater,
            Arches,
            ArchesSmall,
            Blobs,
            BlobsSmall,
            Substance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FeatureTypesEnum FeatureTypes;
    }
}
