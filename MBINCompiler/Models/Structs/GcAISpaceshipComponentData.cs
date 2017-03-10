namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAISpaceshipTypes Type;
        /* 0x04 */ public GcSpaceshipClasses Class;
        /* 0x08 */ public GcPrimaryAxis Axis;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Weapon;
        [NMS(Size = 0x80)]
        /* 0x20 */ public string Hangar;

        //[NMS(Size = 4, Ignore = true)]        this was in the wrong place, and dunno if it is needed now??
        //public byte[] Padding1C;
    }
}
