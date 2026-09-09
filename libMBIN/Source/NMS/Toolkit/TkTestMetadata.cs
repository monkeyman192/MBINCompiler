using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7C3C90BCF80FFCF6, NameHash = 0x69A0FDE1)]
    public class TkTestMetadata : NMSTemplate
    {
        [NMS(Index = 47)]
        /* 0x0000 */ public Vector3f DocOptionalVector;
        [NMS(Index = 5)]
        /* 0x0010 */ public Colour TestColour;
        [NMS(Index = 43)]
        /* 0x0020 */ public Vector3f TestVector;
        [NMS(Index = 44)]
        /* 0x0030 */ public Vector4f TestVector4;
        [NMS(Index = 2)]
        /* 0x0040 */ public TkTrophyEntry TestClass;
        [NMS(Index = 55, Size = 0x4, EnumType = typeof(TkTestBitFieldEnum.EnumEnum))]
        /* 0x00B8 */ public NMSString0x10[] TestExternalBitfieldEnumArray;
        [NMS(Index = 56, KeyField = "Id")]
        /* 0x00F8 */ public HashMap<TkLocalisationEntry> TestHashMap;
        [NMS(Index = 49)]
        /* 0x0128 */ public NMSString0x20A DocOptionalRenamed;
        [NMS(Index = 21)]
        /* 0x0148 */ public NMSString0x20A TestID256;
        [NMS(Index = 22)]
        /* 0x0168 */ public NMSString0x20A TestLocID;
        [NMS(Index = 9)]
        /* 0x0188 */ public HashedString TestHashedString;
        [NMS(Index = 3)]
        /* 0x01A0 */ public NMSTemplate TestClassPointer;
        [NMS(Index = 7)]
        /* 0x01B0 */ public List<float> TestDynamicArray;
        [NMS(Index = 8)]
        /* 0x01C0 */ public VariableSizeString TestDynamicString;
        [NMS(Index = 20)]
        /* 0x01D0 */ public NMSString0x10 TestID;
        [NMS(Index = 45)]
        /* 0x01E0 */ public NMSString0x10 TestIDLookup;
        [NMS(Index = 4)]
        /* 0x01F0 */ public List<LinkableNMSTemplate> TestLinkableClassPointerArray;
        [NMS(Index = 16)]
        /* 0x0200 */ public GcFilename TestModelFilename;
        [NMS(Index = 29)]
        /* 0x0210 */ public GcSeed TestSeed;
        [NMS(Index = 17)]
        /* 0x0220 */ public GcFilename TestTextureFilename;
        [NMS(Index = 26)]
        /* 0x0230 */ public long TestInt64;
        [NMS(Index = 40)]
        /* 0x0238 */ public ulong TestUInt64;
        [NMS(Index = 41)]
        /* 0x0240 */ public ulong TestUniqueId;
        [NMS(Index = 30, Size = 0xA)]
        /* 0x0248 */ public float[] TestStaticArray;
        [NMS(Index = 54, Size = 0x5, EnumType = typeof(TkEqualityEnum.EqualityEnumEnum))]
        /* 0x0270 */ public float[] TestExternalEnumArray;
        // size: 0x4
        public enum TestEnumArrayEnum {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Index = 53, Size = 0x4, EnumType = typeof(TestEnumArrayEnum))]
        /* 0x0284 */ public float[] TestEnumArray;
        [NMS(Index = 42)]
        /* 0x0294 */ public Vector2f TestVector2;
        // size: 0x4
        public enum DocOptionalEnumEnum : uint {
            SomeValue1,
            SomeValue2,
            SomeValue3,
            SomeValue4,
        }
        [NMS(Index = 50)]
        /* 0x029C */ public DocOptionalEnumEnum DocOptionalEnum;
        [NMS(Index = 57)]
        /* 0x02A0 */ public TkEqualityEnum EqualityEnumOverride;
        // size: 0x2
        public enum RenamedEnumEnum : uint {
            CurrentOption,
            OtherOption,
        }
        [NMS(Index = 52)]
        /* 0x02A4 */ public RenamedEnumEnum RenamedEnum;
        [NMS(Index = 51)]
        /* 0x02A8 */ public float RenamedFloat;
        [NMS(Index = 46)]
        /* 0x02AC */ public GcAudioWwiseEvents TestAudioEvent;
        // size: 0x4
        public enum TestEnumEnum : uint {
            Default = 0x0,
            Option1 = 0x1,
            Option2 = 0x45,
            Option3 = 0x46,
        }
        [NMS(Index = 10)]
        /* 0x02B0 */ public TestEnumEnum TestEnum;
        // size: 0x4
        public enum TestEnumClassEnum : uint {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Index = 11)]
        /* 0x02B4 */ public TestEnumClassEnum TestEnumClass;
        // size: 0x4
        public enum TestEnumUInt32BitFieldEnum : uint {
            None = 0x0,
            Enum1 = 0x1,
            Enum2 = 0x2,
            Enum3 = 0x4,
        }
        [NMS(Index = 13)]
        /* 0x02B8 */ public TestEnumUInt32BitFieldEnum TestEnumUInt32BitField;
        [NMS(Index = 15)]
        /* 0x02BC */ public TkLanguages TestExternalEnum;
        // size: 0x4
        [Flags]
        public enum TestFlagsEnum : uint {
            None = 0x0,
            Flag1 = 0x1,
            Flag2 = 0x2,
            Flag3 = 0x4,
        }
        [NMS(Index = 18)]
        /* 0x02C0 */ public TestFlagsEnum TestFlags;
        [NMS(Index = 19)]
        /* 0x02C4 */ public float TestFloat;
        // size: 0x3
        public enum TestInlineEnumEnum : uint {
            Default,
            NotDefault,
            Other,
        }
        [NMS(Index = 14)]
        /* 0x02C8 */ public TestInlineEnumEnum TestInlineEnum;
        [NMS(Index = 25)]
        /* 0x02CC */ public int TestInt;
        [NMS(Index = 27)]
        /* 0x02D0 */ public GcNodeID TestNodeHandle;
        [NMS(Index = 28)]
        /* 0x02D4 */ public GcResource TestResource;
        [NMS(Index = 39)]
        /* 0x02D8 */ public uint TestUInt32;
        [NMS(Index = 24)]
        /* 0x02DC */ public short TestInt16;
        [NMS(Index = 38)]
        /* 0x02DE */ public ushort TestUInt16;
        [NMS(Index = 37)]
        /* 0x02E0 */ public NMSString0x800 TestString2048;
        [NMS(Index = 36)]
        /* 0x0AE0 */ public NMSString0x400 TestString1024;
        [NMS(Index = 35)]
        /* 0x0EE0 */ public NMSString0x200 TestString512;
        [NMS(Index = 34)]
        /* 0x10E0 */ public NMSString0x100 TestString256;
        [NMS(Index = 33)]
        /* 0x11E0 */ public NMSString0x80 TestString128;
        [NMS(Index = 48)]
        /* 0x1260 */ public NMSString0x40 DocRenamedString64;
        [NMS(Index = 32)]
        /* 0x12A0 */ public NMSString0x40 TestString64;
        [NMS(Index = 31)]
        /* 0x12E0 */ public NMSString0x20 TestString;
        [NMS(Index = 6)]
        /* 0x1300 */ public Colour32 TestColour32;
        [NMS(Index = 0)]
        /* 0x1304 */ public bool TestBool;
        [NMS(Index = 1)]
        /* 0x1305 */ public byte TestByte;
        // size: 0x3
        public enum TestEnumUInt8Enum : byte {
            Enum1,
            Enum2,
            Enum3,
        }
        [NMS(Index = 12)]
        /* 0x1306 */ public TestEnumUInt8Enum TestEnumUInt8;
        [NMS(Index = 23)]
        /* 0x1307 */ public sbyte TestInt8;
    }
}
