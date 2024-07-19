namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC82D553728BC3D02, NameHash = 0xA12C289C)]
    public class TkCavesEnum : NMSTemplate
    {
        // size: 0x1
        public enum CaveTypesEnum : uint {
            Underground,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CaveTypesEnum CaveTypes;
    }
}
