namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
        public GcSpaceshipClasses Class;
        public GcAISpaceshipRoles AIRole;
        public GcFrigateClass FrigateClass;
    }
}
