using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFB74F8DC16DC037E, NameHash = 0x69A0FDE1)]
    public class TkTestMetadata : NMSTemplate
    {
        [NMS(Index = 45)]
        /* 0x0000 */ public Vector3f DocOptionalVector;
        [NMS(Index = 5)]
        /* 0x0010 */ public Colour TestColour;
        [NMS(Index = 41)]
        /* 0x0020 */ public Vector3f TestVector;
        [NMS(Index = 42)]
        /* 0x0030 */ public Vector4f TestVector4;
        [NMS(Index = 2)]
        /* 0x0040 */ public TkTrophyEntry TestClass;
        [NMS(Index = 51)]
        /* 0x00B8 */ public HashMap<TkLocalisationEntry> TestHashMap;
        [NMS(Index = 47)]
        /* 0x00E8 */ public NMSString0x20A DocOptionalRenamed;
        [NMS(Index = 19)]
        /* 0x0108 */ public NMSString0x20A TestID256;
        [NMS(Index = 20)]
        /* 0x0128 */ public NMSString0x20A TestLocID;
        [NMS(Index = 8)]
        /* 0x0148 */ public HashedString TestHashedString;
        [NMS(Index = 3)]
        /* 0x0160 */ public NMSTemplate TestClassPointer;
        [NMS(Index = 6)]
        /* 0x0170 */ public List<float> TestDynamicArray;
        [NMS(Index = 7)]
        /* 0x0180 */ public VariableSizeString TestDynamicString;
        [NMS(Index = 18)]
        /* 0x0190 */ public NMSString0x10 TestID;
        [NMS(Index = 43)]
        /* 0x01A0 */ public NMSString0x10 TestIDLookup;
        [NMS(Index = 4)]
        /* 0x01B0 */ public List<LinkableNMSTemplate> TestLinkableClassPointerArray;
        [NMS(Index = 14)]
        /* 0x01C0 */ public VariableSizeString TestModelFilename;
        [NMS(Index = 27)]
        /* 0x01D0 */ public GcSeed TestSeed;
        [NMS(Index = 15)]
        /* 0x01E0 */ public VariableSizeString TestTextureFilename;
        [NMS(Index = 24)]
        /* 0x01F0 */ public long TestInt64;
        [NMS(Index = 38)]
        /* 0x01F8 */ public ulong TestUInt64;
        [NMS(Index = 39)]
        /* 0x0200 */ public ulong TestUniqueId;
        [NMS(Index = 28, Size = 0xA)]
        /* 0x0208 */ public float[] TestStaticArray;
        [NMS(Index = 50, Size = 0x5, EnumType = typeof(TkEqualityEnum.EqualityEnumEnum))]
        /* 0x0230 */ public float[] TestExternalEnumArray;
        // size: 0x4
        public enum TestEnumArrayEnum {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Index = 49, Size = 0x4, EnumType = typeof(TestEnumArrayEnum))]
        /* 0x0244 */ public float[] TestEnumArray;
        [NMS(Index = 40)]
        /* 0x0254 */ public Vector2f TestVector2;
        // size: 0x4
        public enum DocOptionalEnumEnum : uint {
            SomeValue1,
            SomeValue2,
            SomeValue3,
            SomeValue4,
        }
        [NMS(Index = 48)]
        /* 0x025C */ public DocOptionalEnumEnum DocOptionalEnum;
        [NMS(Index = 44)]
        /* 0x0260 */ public GcAudioWwiseEvents TestAudioEvent;
        // size: 0x4
        public enum TestEnumEnum : uint {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Index = 9)]
        /* 0x0264 */ public TestEnumEnum TestEnum;
        // size: 0x4
        public enum TestEnumUInt32BitFieldEnum : uint {
            Enum1 = 0x1,
            Enum2 = 0x2,
            Enum3 = 0x4,
            None = 0x0,
        }
        [NMS(Index = 11)]
        /* 0x0268 */ public TestEnumUInt32BitFieldEnum TestEnumUInt32BitField;
        [NMS(Index = 13)]
        /* 0x026C */ public TkLanguages TestExternalEnum;
        // size: 0x4
        [Flags]
        public enum TestFlagsEnum : uint {
            None = 0x0,
            Flag1 = 0x1,
            Flag2 = 0x2,
            Flag3 = 0x4,
        }
        [NMS(Index = 16)]
        /* 0x0270 */ public TestFlagsEnum TestFlags;
        [NMS(Index = 17)]
        /* 0x0274 */ public float TestFloat;
        // size: 0x3
        public enum TestInlineEnumEnum : uint {
            Default,
            NotDefault,
            Other,
        }
        [NMS(Index = 12)]
        /* 0x0278 */ public TestInlineEnumEnum TestInlineEnum;
        [NMS(Index = 23)]
        /* 0x027C */ public int TestInt;
        [NMS(Index = 25)]
        /* 0x0280 */ public GcNodeID TestNodeHandle;
        [NMS(Index = 26)]
        /* 0x0284 */ public GcResource TestResource;
        [NMS(Index = 37)]
        /* 0x0288 */ public uint TestUInt32;
        [NMS(Index = 22)]
        /* 0x028C */ public short TestInt16;
        [NMS(Index = 36)]
        /* 0x028E */ public ushort TestUInt16;
        [NMS(Index = 35)]
        /* 0x0290 */ public NMSString0x800 TestString2048;
        [NMS(Index = 34)]
        /* 0x0A90 */ public NMSString0x400 TestString1024;
        [NMS(Index = 33)]
        /* 0x0E90 */ public NMSString0x200 TestString512;
        [NMS(Index = 32)]
        /* 0x1090 */ public NMSString0x100 TestString256;
        [NMS(Index = 31)]
        /* 0x1190 */ public NMSString0x80 TestString128;
        [NMS(Index = 46)]
        /* 0x1210 */ public NMSString0x40 DocRenamedString64;
        [NMS(Index = 30)]
        /* 0x1250 */ public NMSString0x40 TestString64;
        [NMS(Index = 29)]
        /* 0x1290 */ public NMSString0x20 TestString;
        [NMS(Index = 0)]
        /* 0x12B0 */ public bool TestBool;
        [NMS(Index = 1)]
        /* 0x12B1 */ public byte TestByte;
        // size: 0x3
        public enum TestEnumUInt8Enum : byte {
            Enum1,
            Enum2,
            Enum3,
        }
        [NMS(Index = 10)]
        /* 0x12B2 */ public TestEnumUInt8Enum TestEnumUInt8;
        [NMS(Index = 21)]
        /* 0x12B3 */ public sbyte TestInt8;
    }
}
