using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingTable : NMSTemplate
    {
        /* 0x000 */ public TkModelResource LegModel;
        /* 0x084 */ public TkModelResource BaseRadiusModel;
        /* 0x108 */ public TkModelResource SnapPointValid;
        /* 0x18C */ public TkModelResource SnapPointInvalid;
        /* 0x210 */ public TkModelResource SnapPointFar;

        //Greg padding
        //[NMS(Size = 8, Ignore = true)]
        //public byte[] Padding90;
        

        /* 0x298 */ public List<GcBaseBuildingEntry> Objects;
        /* 0x2A8 */ public List<GcBaseBuildingGroup> Groups;
<<<<<<< HEAD
        
        [NMS(Size = 16)]
        public GcBaseBuildingPalette[] Palettes;

=======
        //Commenting Palettes and PRoperties. PRobably exist in the functions
        //THey are definitely missing from the basebuildingtable.mbin
        [NMS(Size = 16)]
        /* 0x2C0 */ public GcBaseBuildingPalette[] Palettes;
>>>>>>> master
        /* 0x4C0 */ public GcBaseBuildingProperties Properties;
    }
}
