namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x21B18A160AD77B69, NameHash = 0xC1FAA94D)]
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
