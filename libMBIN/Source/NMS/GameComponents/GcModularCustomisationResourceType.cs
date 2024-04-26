namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B670082C175BD7F, NameHash = 0x6D74FB0420E14CEB)]
    public class GcModularCustomisationResourceType : NMSTemplate
    {
        // size: 0x5
        public enum ModularCustomisationResourceTypeEnum : uint {
            MultiToolStaff,
            Fighter,
            Dropship,
            Scientific,
            Shuttle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModularCustomisationResourceTypeEnum ModularCustomisationResourceType;
    }
}
