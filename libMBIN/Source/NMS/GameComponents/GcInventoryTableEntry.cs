using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInventoryTableEntry : NMSTemplate
    {
        public NMSString0x10 Id;
        public int MinSize;
        public int MaxSize;
        public int SizeType;
        public string[] SizeTypeValues()
        {
            return new[] { "SciSmall", "SciMedium", "SciLarge", "FgtSmall", "FgtMedium", "FgtLarge", "ShuSmall", "ShtMedium", "ShtLarge", "DrpSmall", "DrpMedium", "DrpLarge",
						   "WeaponSmall", "WeaponMedium", "WeaponLarge", "FreighterSmall", "FreighterMedium", "FreighterLarge", "BuggySmall", "BuggyMedium", "BuggyLarge",
						   "ChestSmall", "ChestMedium", "ChestLarge"}; // Shu/Sht spelling mistake(?) is from the exe
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
