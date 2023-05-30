using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTestMetadata : NMSTemplate // size = 0x6A4
    {
        public bool TestBool;
        public int TestInt;
        public short TestInt16;
        public ushort TestUInt16;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC;

        public long TestInt64;
        public ulong TestUInt64;
        public long TestInt64_2;
        public ulong TestUInt64_2;

        [NMS(Size = 0x10, Ignore = true)]
        public byte[] Padding30;

        public Vector4f TestVector; // actually Vector3, but it's 0x10 bytes so we read it as Vector4
        public Vector2f TestVector2;
        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding58;

        public Vector4f TestVector4;
        public Colour TestColour;
        public float TestFloat;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding84;

        public GcSeed TestSeed;

        public NMSString0x80 TestModelFilename;
        public NMSString0x80 TestTextureFilename;
        public NMSString0x20 TestString;
        public NMSString0x80 TestString128;
        public NMSString0x100 TestString256;
        public NMSString0x200 TestString512;

        public NMSString0x10 TestID; // most likely they use a special ID field which maps this to the object using this ID automatically
        public NMSString0x20 TestLocID; // ditto

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding568;

        public Vector4f DocOptionalVector;
        public NMSString0x40 DocRenamedString64;
        public NMSString0x20 DocOptionalRenamed;
        public int DocOptionalEnum;
        public string[] DocOptionalEnumValues()
        {
            return new[] { "SomeValue1", "SomeValue2", "SomeValue3", "SomeValue4" };
        }
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding5E4;

        public VariableSizeString TestDynamicString;
        public int TestEnum;
        public string[] TestEnumValues()
        {
            return new[] { "Default", "Option1", "Option2", "Option3" };
        }

        [NMS(Size = 0xA)]
        public float[] TestStaticArray;

        public List<float> TestDynamicArray;

        [NMS(Size = 0x4, EnumValue = new[] { "Default", "Option1", "Option2", "Option3" })]
        public float[] TestEnumArray;

        [NMS(Size = 0x16, EnumValue = new[] // EnumValue taken from GcBuildingClassification.BuildingClass
            {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad"
            })]
        public float[] TestExternalEnumArray; // external probably means it gets enum values from outside the GcTestMetadata source file

        public int TestFlags; // not mentioned in the normal template sub that we get fields from, mentioned in different one @ 0x140237E50 (which is also much easier to understand, and it seems all templates have these alternate subs...)
        public string[] TestFlagsValues()
        {
            return new[] { "null", "Flag1", "Flag2" }; // null is actually a pointer to 00 in the exe, we give it a value here because xml parser treats empty values different
        }

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding6A4;
    }
}
