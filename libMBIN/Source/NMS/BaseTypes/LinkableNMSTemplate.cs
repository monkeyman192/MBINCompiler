namespace libMBIN.NMS {

    [NMS(Size = 0x20)]
    public class LinkableNMSTemplate : NMSTemplate
    {
        // This is an "primitive" type similar to GcSeed etc.
        // Because of this these names aren't really "real"
        // (although there is a mention of `linked` in the exe)
        public NMSTemplate Template;
        public OptionalVariableSizeString Linked;
    }
}
