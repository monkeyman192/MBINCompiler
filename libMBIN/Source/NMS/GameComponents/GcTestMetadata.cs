using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x6E0, GUID = 0xED9D01EDEE998FDB,  NameHash = 0xCE965FAFD6BBF99E)]
    public class GcTestMetadata : NMSTemplate
    {
        public bool TestBool;
        public byte TestByte;
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

        public Vector3f TestVector;
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

        public Vector3f DocOptionalVector;
        public NMSString0x40 DocRenamedString64;
        public NMSString0x20 DocOptionalRenamed;
		public enum DocOptionalEnumEnum { SomeValue1, SomeValue2, SomeValue3, SomeValue4 }
		public DocOptionalEnumEnum DocOptionalEnum;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding5E4;

        public VariableSizeString TestDynamicString;
		public enum TestEnumEnum { Default, Option1, Option2, Option3 }
		public TestEnumEnum TestEnum;

        [NMS(Size = 0xA)]
        public float[] TestStaticArray;

        public List<float> TestDynamicArray;

        [NMS(Size = 0x4, EnumType = typeof(TestEnumEnum))]
        public float[] TestEnumArray;

        [NMS(Size = 0x24, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        public float[] TestExternalEnumArray;

		public enum TestFlagsEnum { Null, Flag1, Flag2 }
		public TestFlagsEnum TestFlags;

        [NMS(Size = 4, Ignore = true)]
        public byte[] EndPadding;
    }
}
