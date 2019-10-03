using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1551D21BA3DAC603, NameHash = 0xE50E9B26CC742B3D)]
    public class GcScreenFilters : NMSTemplate
    {
        // 0x24 entries
		public enum ScreenFiltersEnum { Default, DefaultStorm, Frozen, FrozenStorm, Toxic, ToxicStorm, Radioactive, RadioactiveStorm, Scorched, ScorchedStorm,
            Barren, BarrenStorm, Weird1, Weird2, Weird3, Weird4, Weird5, Weird6, Weird7, Weird8, Vintage, HyperReal, Desaturated, Amber, GBGreen, Apocalypse,
            Diffusion, Green, BlackAndWhite, Isolation, Sepia, Filmic, GBGrey, Binoculars, Surveying, Nexus }
		public ScreenFiltersEnum ScreenFilters;
    }
}
