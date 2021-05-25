using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x2290E56D747DED58, NameHash = 0xE50E9B26CC742B3D)]
    public class GcScreenFilters : NMSTemplate
    {
        // size: 0x52
		public enum ScreenFilterEnum {
            Default, DefaultStorm, Frozen, FrozenStorm, Toxic, ToxicStorm, Radioactive, RadioactiveStorm, Scorched, ScorchedStorm,
            Barren, BarrenStorm, Weird1, Weird2, Weird3, Weird4, Weird5, Weird6, Weird7, Weird8,
            Vintage, HyperReal, Desaturated, Amber, GBGreen, Apocalypse, Diffusion, Green, BlackAndWhite, Isolation,
            Sepia, Filmic, GBGrey, Binoculars, Surveying, Nexus, SpaceStation, Freighter, FreighterAbandoned, Frigate,
            MissionSurvey, NewVibrant, NewVibrantBright, NewVibrantWarm, NewVintageBright, NewVintageWash, Drama, MemoryBold, Memory, MemoryWash,
            Autumn, AutumnFade, ClassicBright, Classic, ClassicWash, BlackAndWhiteDream, ColourTouchB, ColourTouchC, NegativePrint, SepiaExtreme,
            Solarise, TwoToneStrong, TwoTone, Dramatic, Fuchsia, Violet, Cyan, GreenNew, AmberNew, Red,
            HueShiftA, HueShiftB, HueShiftC, HueShiftD, WarmStripe, NMSRetroA, NMSRetroB, NMSRetroC, NMSRetroD, NMSRetroE,
            NMSRetroF, NMSRetroG
        }
		public ScreenFilterEnum ScreenFilter;
    }
}
