using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59306510A2330F75, NameHash = 0xCE965FAFD6BBF99E)]
    public class GcTestMetadata : NMSTemplate
    {
        /* 0x000 */ public Vector3f DocOptionalVector;
        /* 0x010 */ public Colour TestColour;
        /* 0x020 */ public Vector3f TestVector;
        /* 0x030 */ public Vector4f TestVector4;
        /* 0x040 */ public NMSString0x20A DocOptionalRenamed;
        /* 0x060 */ public NMSString0x20A TestLocID;
        /* 0x080 */ public List<float> TestDynamicArray;
        /* 0x090 */ public VariableSizeString TestDynamicString;
        /* 0x0A0 */ public NMSString0x10 TestID;
        /* 0x0B0 */ public NMSString0x10 TestLookupSpecies;
        /* 0x0C0 */ public GcSeed TestSeed;
        /* 0x0D0 */ public long TestInt64;
        /* 0x0D8 */ public long TestInt64_2;
        /* 0x0E0 */ public ulong TestUInt64;
        /* 0x0E8 */ public ulong TestUInt64_2;
        [NMS(Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0F0 */ public float[] TestExternalEnumArray;
        [NMS(Size = 0xA)]
        /* 0x1CC */ public float[] TestStaticArray;
        // size: 0x4
        public enum TestEnumArrayEnum {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Size = 0x4, EnumType = typeof(TestEnumArrayEnum))]
        /* 0x1F4 */ public float[] TestEnumArray;
        /* 0x204 */ public Vector2f TestVector2;
        // size: 0x4
        public enum DocOptionalEnumEnum : uint {
            SomeValue1,
            SomeValue2,
            SomeValue3,
            SomeValue4,
        }
        /* 0x20C */ public DocOptionalEnumEnum DocOptionalEnum;
        /* 0x210 */ public GcAudioWwiseEvents TestAudioEvent;
        // size: 0x4
        public enum TestEnumEnum : uint {
            Default,
            Option1,
            Option2,
            Option3,
        }
        /* 0x214 */ public TestEnumEnum TestEnum;
        // size: 0x4
        [Flags]
        public enum TestFlagsEnum : uint {
            None = 0x0,
            Flag1 = 0x1,
            Flag2 = 0x2,
            Flag3 = 0x4,
        }
        /* 0x218 */ public TestFlagsEnum TestFlags;
        /* 0x21C */ public float TestFloat;
        /* 0x220 */ public int TestInt;
        /* 0x224 */ public GcResource TestResource;
        /* 0x228 */ public short TestInt16;
        /* 0x22A */ public ushort TestUInt16;
        /* 0x22C */ public NMSString0x200 TestString512;
        /* 0x42C */ public NMSString0x100 TestString256;
        /* 0x52C */ public NMSString0x80 TestModelFilename;
        /* 0x5AC */ public NMSString0x80 TestString128;
        /* 0x62C */ public NMSString0x80 TestTextureFilename;
        /* 0x6AC */ public NMSString0x40 DocRenamedString64;
        /* 0x6EC */ public NMSString0x20 TestString;
        /* 0x70C */ public bool TestBool;
        /* 0x70D */ public byte TestByte;
    }
}
