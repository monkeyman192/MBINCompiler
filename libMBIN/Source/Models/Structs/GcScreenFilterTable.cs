namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1650)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Size = 0x22, EnumValue = new string[] { "Default","DefaultStorm","Frozen","FrozenStorm","Toxic","ToxicStorm","Radioactive","RadioactiveStorm",
                "Scorched","ScorchedStorm","Barren","BarrenStorm","Weird1","Weird2","Weird3","Weird4","Weird5","Weird6",
                "Weird7","Weird8","Vintage","HyperReal","Desaturated","Amber","GBGreen","Apocalypse","Diffusion","Green",
                "BlackAndWhite","Isolation","Sepia","Filmic","GBGrey","Binoculars"})]
        public GcScreenFilterData[] Filters;
    }
}
