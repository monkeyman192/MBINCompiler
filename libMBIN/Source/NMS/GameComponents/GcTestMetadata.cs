using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59306510A2330F75, NameHash = 0xCE965FAFD6BBF99E)]
    public class GcTestMetadata : NMSTemplate
    {
        [NMS(Index = 26)]
        /* 0x000 */ public Vector3f DocOptionalVector;
        [NMS(Index = 13)]
        /* 0x010 */ public Colour TestColour;
        [NMS(Index = 10)]
        /* 0x020 */ public Vector3f TestVector;
        [NMS(Index = 12)]
        /* 0x030 */ public Vector4f TestVector4;
        [NMS(Index = 28)]
        /* 0x040 */ public NMSString0x20A DocOptionalRenamed;
        [NMS(Index = 23)]
        /* 0x060 */ public NMSString0x20A TestLocID;
        [NMS(Index = 33)]
        /* 0x080 */ public List<float> TestDynamicArray;
        [NMS(Index = 30)]
        /* 0x090 */ public VariableSizeString TestDynamicString;
        [NMS(Index = 22)]
        /* 0x0A0 */ public NMSString0x10 TestID;
        [NMS(Index = 24)]
        /* 0x0B0 */ public NMSString0x10 TestLookupSpecies;
        [NMS(Index = 15)]
        /* 0x0C0 */ public GcSeed TestSeed;
        [NMS(Index = 5)]
        /* 0x0D0 */ public long TestInt64;
        [NMS(Index = 7)]
        /* 0x0D8 */ public long TestInt64_2;
        [NMS(Index = 6)]
        /* 0x0E0 */ public ulong TestUInt64;
        [NMS(Index = 8)]
        /* 0x0E8 */ public ulong TestUInt64_2;
        [NMS(Index = 35, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0F0 */ public float[] TestExternalEnumArray;
        [NMS(Index = 32, Size = 0xA)]
        /* 0x1CC */ public float[] TestStaticArray;
        // size: 0x4
        public enum TestEnumArrayEnum {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Index = 34, Size = 0x4, EnumType = typeof(TestEnumArrayEnum))]
        /* 0x1F4 */ public float[] TestEnumArray;
        [NMS(Index = 11)]
        /* 0x204 */ public Vector2f TestVector2;
        // size: 0x4
        public enum DocOptionalEnumEnum : uint {
            SomeValue1,
            SomeValue2,
            SomeValue3,
            SomeValue4,
        }
        [NMS(Index = 29)]
        /* 0x20C */ public DocOptionalEnumEnum DocOptionalEnum;
        [NMS(Index = 25)]
        /* 0x210 */ public GcAudioWwiseEvents TestAudioEvent;
        // size: 0x4
        public enum TestEnumEnum : uint {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Index = 31)]
        /* 0x214 */ public TestEnumEnum TestEnum;
        // size: 0x4
        [Flags]
        public enum TestFlagsEnum : uint {
            None = 0x0,
            Flag1 = 0x1,
            Flag2 = 0x2,
            Flag3 = 0x4,
        }
        [NMS(Index = 36)]
        /* 0x218 */ public TestFlagsEnum TestFlags;
        [NMS(Index = 14)]
        /* 0x21C */ public float TestFloat;
        [NMS(Index = 2)]
        /* 0x220 */ public int TestInt;
        [NMS(Index = 9)]
        /* 0x224 */ public GcResource TestResource;
        [NMS(Index = 3)]
        /* 0x228 */ public short TestInt16;
        [NMS(Index = 4)]
        /* 0x22A */ public ushort TestUInt16;
        [NMS(Index = 21)]
        /* 0x22C */ public NMSString0x200 TestString512;
        [NMS(Index = 20)]
        /* 0x42C */ public NMSString0x100 TestString256;
        [NMS(Index = 16)]
        /* 0x52C */ public NMSString0x80 TestModelFilename;
        [NMS(Index = 19)]
        /* 0x5AC */ public NMSString0x80 TestString128;
        [NMS(Index = 17)]
        /* 0x62C */ public NMSString0x80 TestTextureFilename;
        [NMS(Index = 27)]
        /* 0x6AC */ public NMSString0x40 DocRenamedString64;
        [NMS(Index = 18)]
        /* 0x6EC */ public NMSString0x20 TestString;
        [NMS(Index = 0)]
        /* 0x70C */ public bool TestBool;
        [NMS(Index = 1)]
        /* 0x70D */ public byte TestByte;
    }
}
