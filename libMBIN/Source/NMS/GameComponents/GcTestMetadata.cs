using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xED9D01EDEE998FDB, Size = 0x6E0, NameHash = 0xCE965FAFD6BBF99E)]
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

        [NMS(Size = 0x80)]
        public string TestModelFilename;
        [NMS(Size = 0x80)]
        public string TestTextureFilename;
        [NMS(Size = 0x20)]
        public string TestString;
        [NMS(Size = 0x80)]
        public string TestString128;
        [NMS(Size = 0x100)]
        public string TestString256;
        [NMS(Size = 0x200)]
        public string TestString512;

        [NMS(Size = 0x10)]
        public string TestID; // most likely they use a special ID field which maps this to the object using this ID automatically
        [NMS(Size = 0x20)]
        public string TestLocID; // ditto

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding568;

        public Vector4f DocOptionalVector;
        [NMS(Size = 0x40)]
        public string DocRenamedString64;
        [NMS(Size = 0x20)]
        public string DocOptionalRenamed;
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

        [NMS(Size = 0x23, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        public float[] TestExternalEnumArray;

		public enum TestFlagsEnum { Null, Flag1, Flag2 }
		public TestFlagsEnum TestFlags;
    }
}
