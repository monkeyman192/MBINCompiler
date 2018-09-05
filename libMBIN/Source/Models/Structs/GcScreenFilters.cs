namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4)]
    public class GcScreenFilters : NMSTemplate
    {
        public int ScreenFilters;
        public string[] ScreenFiltersValues()
        {
            return new[] { "Default","DefaultStorm","Frozen","FrozenStorm","Toxic","ToxicStorm","Radioactive","RadioactiveStorm",
                "Scorched","ScorchedStorm","Barren","BarrenStorm","Weird1","Weird2","Weird3","Weird4","Weird5","Weird6",
                "Weird7","Weird8","Vintage","HyperReal","Desaturated","Amber","GBGreen","Apocalypse","Diffusion","Green",
                "BlackAndWhite","Isolation","Sepia","Filmic","GBGrey","Binoculars"};
        }
    }
}
