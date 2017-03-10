// generated output for subroutine:
// char *__fastcall GcSpaceshipGlobals_LoadDefaults(__int64 a1) -----> hash: 3C805E77
// hash of whole input: A1693D66

namespace MBINCompiler.Models.Structs
{
    public class GcSpaceshipGlobals_old : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: char *__fastcall GcSpaceshipGlobals_LoadDefaults(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        // line:   __int64 v2; // rdx@1
        // line:   char *result; // rax@1
        public bool Unknown0;     // offset: 0, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)a1 = 1;

        // missing 3 bytes at offset 0
        // does 0 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;        // offset: 1, sz: 3, comment: auto padding 

        public float Unknown4;     // offset: 4, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 4) = 0x3F800000;
        public float Unknown8;     // offset: 8, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 8) = 0x40000000;
        public float UnknownC;     // offset: 0xC, sz: 4, origin: 0x437A0000, parsed: 250        // line:   *(_DWORD *)(a1 + 0xC) = 0x437A0000;
        public float Unknown10;     // offset: 0x10, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(a1 + 0x10) = 0x43FA0000;
        public float Unknown14;     // offset: 0x14, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(a1 + 0x14) = 0x41700000;
        public float Unknown18;     // offset: 0x18, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(a1 + 0x18) = 0x41700000;
        public float Unknown1C;     // offset: 0x1C, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(a1 + 0x1C) = 0x42480000;
        public float Unknown20;     // offset: 0x20, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(a1 + 0x20) = 0x43160000;
        public float Unknown24;     // offset: 0x24, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0x24) = 0x3F800000;
        public float Unknown28;     // offset: 0x28, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(a1 + 0x28) = 0x42C80000;
        public float Unknown2C;     // offset: 0x2C, sz: 4, origin: 0xC1F00000, parsed: -30        // line:   *(_DWORD *)(a1 + 0x2C) = 0xC1F00000;
        public float Unknown30;     // offset: 0x30, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 0x30) = 0x40000000;
        public float Unknown34;     // offset: 0x34, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(a1 + 0x34) = 0x3F4CCCCD;
        public float Unknown38;     // offset: 0x38, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x38) = 0x41200000;
        public float Unknown3C;     // offset: 0x3C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x3C) = 0x41200000;
        public float Unknown40;     // offset: 0x40, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 0x40) = 0x40000000;
        public float Unknown44;     // offset: 0x44, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x44) = 0x41200000;
        public float Unknown48;     // offset: 0x48, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(a1 + 0x48) = 0x42700000;
        public float Unknown4C;     // offset: 0x4C, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(a1 + 0x4C) = 0x3F99999A;
        public float Unknown50;     // offset: 0x50, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(a1 + 0x50) = 0x3F000000;
        public float Unknown54;     // offset: 0x54, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(a1 + 0x54) = 0x41F00000;
        public float Unknown58;     // offset: 0x58, sz: 4, origin: 0xC0000000, parsed: -2        // line:   *(_DWORD *)(a1 + 0x58) = 0xC0000000;
        public float Unknown5C;     // offset: 0x5C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x5C) = 0x41200000;
        public float Unknown60;     // offset: 0x60, sz: 4, origin: 0xC0000000, parsed: -2        // line:   *(_DWORD *)(a1 + 0x60) = 0xC0000000;
        public float Unknown64;     // offset: 0x64, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 0x64) = 0x40000000;
        public int Unknown68;     // offset: 0x68, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(a1 + 0x68) = 4;
        public float Unknown6C;     // offset: 0x6C, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(a1 + 0x6C) = 0x453B8000;
        public float Unknown70;     // offset: 0x70, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(a1 + 0x70) = 0x447A0000;
        public float Unknown74;     // offset: 0x74, sz: 4, origin: 0x44480000, parsed: 800        // line:   *(_DWORD *)(a1 + 0x74) = 0x44480000;
        public float Unknown78;     // offset: 0x78, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(a1 + 0x78) = 0x42C80000;
        public float Unknown7C;     // offset: 0x7C, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(a1 + 0x7C) = 0x43480000;
        public float Unknown80;     // offset: 0x80, sz: 4, origin: 0x459C4000i64, parsed: 5000, comment: two packed floats in a QWORD?(1)
        public float Unknown84;     // offset: 132, sz: 4, origin: 0x459C4000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 0x80) = 0x459C4000i64;
        public float Unknown88;     // offset: 0x88, sz: 4, origin: 0x3F733333, parsed: 0.95        // line:   *(_DWORD *)(a1 + 0x88) = 0x3F733333;
        public float Unknown8C;     // offset: 0x8C, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(a1 + 0x8C) = 0x3E4CCCCD;
        public float Unknown90;     // offset: 0x90, sz: 4, origin: 0x3BA3D70A, parsed: 0.005        // line:   *(_DWORD *)(a1 + 0x90) = 0x3BA3D70A;
        public float Unknown94;     // offset: 0x94, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(a1 + 0x94) = 0x41700000;
        public float Unknown98;     // offset: 0x98, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0x98) = 0x3F800000;
        public float Unknown9C;     // offset: 0x9C, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(a1 + 0x9C) = 0x40A00000;
        public float UnknownA0;     // offset: 0xA0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0xA0) = 0x3F800000;

        public GcPlayerSpaceshipControlData UnknownA4;

        public float Unknown194;     // offset: 0x194, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x194) = 0x41700000;
        public float Unknown198;     // offset: 0x198, sz: 4, origin: 0x43C80000, parsed: 400        // line:   *(_DWORD *)(v1 + 0x198) = 0x43C80000;
        public float Unknown19C;     // offset: 0x19C, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x19C) = 0x41000000;
        public float Unknown1A0;     // offset: 0x1A0, sz: 4, origin: 0x3F8CCCCD, parsed: 1.1        // line:   *(_DWORD *)(v1 + 0x1A0) = 0x3F8CCCCD;
        public float Unknown1A4;     // offset: 0x1A4, sz: 4, origin: 0x3F666666, parsed: 0.9        // line:   *(_DWORD *)(v1 + 0x1A4) = 0x3F666666;
        public float Unknown1A8;     // offset: 0x1A8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x1A8) = 0x40400000;
        public int Unknown1AC;     // offset: 0x1AC, sz: 8, origin: 5i64, parsed: 5        // line:   *(_QWORD *)(v1 + 0x1AC) = 5i64;
        public float Unknown1B0;
        public float Unknown1B4;     // offset: 0x1B4, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown1B8;     // offset: 440, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1B4) = 0x40A00000i64;
        public float Unknown1BC;     // offset: 0x1BC, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x1BC) = 0x41200000;
        public float Unknown1C0;     // offset: 0x1C0, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x1C0) = 0x42C80000;
        public float Unknown1C4;     // offset: 0x1C4, sz: 4, origin: 0x447A0000i64, parsed: 1000, comment: two packed floats in a QWORD?(1)
        public float Unknown1C8;     // offset: 456, sz: 4, origin: 0x447A0000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1C4) = 0x447A0000i64;
        public float Unknown1CC;     // offset: 0x1CC, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown1D0;     // offset: 464, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1CC) = 0x40A00000i64;
        public float Unknown1D4;     // offset: 0x1D4, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x1D4) = 0x41200000;
        public float Unknown1D8;     // offset: 0x1D8, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x1D8) = 0x42C80000;
        public float Unknown1DC;     // offset: 0x1DC, sz: 4, origin: 0x447A0000i64, parsed: 1000, comment: two packed floats in a QWORD?(1)
        public float Unknown1E0;     // offset: 480, sz: 4, origin: 0x447A0000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1DC) = 0x447A0000i64;
        public float Unknown1E4;     // offset: 0x1E4, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown1E8;     // offset: 488, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1E4) = 0x40A00000i64;
        public float Unknown1EC;     // offset: 0x1EC, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x1EC) = 0x41200000;
        public float Unknown1F0;     // offset: 0x1F0, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x1F0) = 0x42C80000;
        public float Unknown1F4;     // offset: 0x1F4, sz: 4, origin: 0x447A0000i64, parsed: 1000, comment: two packed floats in a QWORD?(1)
        public float Unknown1F8;     // offset: 504, sz: 4, origin: 0x447A0000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x1F4) = 0x447A0000i64;
        public float Unknown1FC;
        public float Unknown200;     // offset: 0x200, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown204;     // offset: 516, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x200) = 0x40A00000i64;
        public float Unknown208;     // offset: 0x208, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x208) = 0x41200000;
        public float Unknown20C;     // offset: 0x20C, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x20C) = 0x42C80000;
        public float Unknown210;     // offset: 0x210, sz: 4, origin: 0x447A0000i64, parsed: 1000, comment: two packed floats in a QWORD?(1)
        public float Unknown214;     // offset: 532, sz: 4, origin: 0x447A0000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x210) = 0x447A0000i64;
        public float Unknown218;     // offset: 0x218, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown21C;     // offset: 540, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x218) = 0x40A00000i64;
        public float Unknown220;     // offset: 0x220, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x220) = 0x41200000;
        public float Unknown224;     // offset: 0x224, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x224) = 0x42C80000;
        public float Unknown228;     // offset: 0x228, sz: 4, origin: 0x447A0000i64, parsed: 1000, comment: two packed floats in a QWORD?(1)
        public float Unknown22C;     // offset: 556, sz: 4, origin: 0x447A0000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x228) = 0x447A0000i64;
        public float Unknown230;     // offset: 0x230, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown234;     // offset: 564, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x230) = 0x40A00000i64;
        public float Unknown238;     // offset: 0x238, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x238) = 0x41200000;
        public float Unknown23C;     // offset: 0x23C, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x23C) = 0x42C80000;
        public float Unknown240;     // offset: 0x240, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x240) = 0x447A0000;
        public int Unknown244;     // offset: 0x244, sz: 8, origin: 0x32i64, parsed: 50        // line:   *(_QWORD *)(v1 + 0x244) = 0x32i64;
        public int Unknown248; // empty? (244 was LONG, but LONGs have to be aligned to 0x8, so it must be an int?)
        // line:   *(_QWORD *)(v1 + 0x24C) = v2;

        // missing 8 bytes at offset 580
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding24C;        // offset: 588, sz: 8, comment: auto padding 

        public float Unknown254;     // offset: 0x254, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown258;     // offset: 600, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x254) = 0x40A00000i64;
        public float Unknown25C;     // offset: 0x25C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x25C) = 0x41200000;
        public float Unknown260;     // offset: 0x260, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x260) = 0x42C80000;
        public float Unknown264;     // offset: 0x264, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x264) = 0x447A0000;
        public float Unknown268;     // offset: 0x268, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x268) = 0x40000000;
        public float Unknown26C;     // offset: 0x26C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x26C) = 0x40400000;
        public float Unknown270;     // offset: 0x270, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x270) = 0x40400000;
        public float Unknown274;     // offset: 0x274, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x274) = 0x42480000;
        public float Unknown278;     // offset: 0x278, sz: 4, origin: 0x43960000, parsed: 300        // line:   *(_DWORD *)(v1 + 0x278) = 0x43960000;
        public float Unknown27C;     // offset: 0x27C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x27C) = 0x3F000000;
        public float Unknown280;     // offset: 0x280, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x280) = 0x40000000;
        public float Unknown284;     // offset: 0x284, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x284) = 0x43FA0000;
        public float Unknown288;     // offset: 0x288, sz: 4, origin: 0x442F0000, parsed: 700        // line:   *(_DWORD *)(v1 + 0x288) = 0x442F0000;
        public float Unknown28C;     // offset: 0x28C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x28C) = 0x3F000000;
        public float Unknown290;     // offset: 0x290, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x290) = 0x40000000;
        public float Unknown294;     // offset: 0x294, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x294) = 0x40000000;
        public float Unknown298;     // offset: 0x298, sz: 4, origin: 0x469C4000, parsed: 20000        // line:   *(_DWORD *)(v1 + 0x298) = 0x469C4000;
        public float Unknown29C;     // offset: 0x29C, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x29C) = 0x3DCCCCCD;
        public float Unknown2A0;     // offset: 0x2A0, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x2A0) = 0x41200000;
        public float Unknown2A4;     // offset: 0x2A4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x2A4) = 0x40000000;
        public float Unknown2A8;     // offset: 0x2A8, sz: 4, origin: 0x459C4000, parsed: 5000        // line:   *(_DWORD *)(v1 + 0x2A8) = 0x459C4000;
        public float Unknown2AC;     // offset: 0x2AC, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x2AC) = 0x44FA0000;
        public float Unknown2B0;     // offset: 0x2B0, sz: 4, origin: 0x451C4000, parsed: 2500        // line:   *(_DWORD *)(v1 + 0x2B0) = 0x451C4000;
        public float Unknown2B4;     // offset: 0x2B4, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x2B4) = 0x42C80000;
        public float Unknown2B8;     // offset: 0x2B8, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x2B8) = 0x447A0000;
        public float Unknown2BC;     // offset: 0x2BC, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x2BC) = 0x43FA0000;
        public float Unknown2C0;     // offset: 0x2C0, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x2C0) = 0x3F000000;
        public float Unknown2C4;     // offset: 0x2C4, sz: 4, origin: 0x40A00000i64, parsed: 5, comment: two packed floats in a QWORD?(1)
        public float Unknown2C8;     // offset: 712, sz: 4, origin: 0x40A00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x2C4) = 0x40A00000i64;
        public float Unknown2CC;     // offset: 0x2CC, sz: 4, origin: 0x3F666666, parsed: 0.9        // line:   *(_DWORD *)(v1 + 0x2CC) = 0x3F666666;
        public float Unknown2D0;     // offset: 0x2D0, sz: 4, origin: 0x3F666666i64, parsed: 0.9, comment: two packed floats in a QWORD?(1)
        public float Unknown2D4;     // offset: 724, sz: 4, origin: 0x3F666666i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x2D0) = 0x3F666666i64;
        public float Unknown2D8;     // offset: 0x2D8, sz: 4, origin: 0x44480000, parsed: 800        // line:   *(_DWORD *)(v1 + 0x2D8) = 0x44480000;
        public float Unknown2DC;     // offset: 0x2DC, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x2DC) = 0x40A00000;
        public float Unknown2E0;     // offset: 0x2E0, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x2E0) = 0x3FC00000;
        public float Unknown2E4;     // offset: 0x2E4, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x2E4) = 0x3E4CCCCD;
        public float Unknown2E8;     // offset: 0x2E8, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x2E8) = 0x41200000;
        public float Unknown2EC;     // offset: 0x2EC, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x2EC) = 0x3F800000;
        public float Unknown2F0;     // offset: 0x2F0, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x2F0) = 0x40A00000;
        public float Unknown2F4;     // offset: 0x2F4, sz: 4, origin: 0x3E19999A, parsed: 0.15        // line:   *(_DWORD *)(v1 + 0x2F4) = 0x3E19999A;
        public float Unknown2F8;     // offset: 0x2F8, sz: 4, origin: 0x40800000, parsed: 4        // line:   *(_DWORD *)(v1 + 0x2F8) = 0x40800000;
        public int Unknown2FC;     // offset: 0x2FC, sz: 4, origin: 0x1F4, parsed: 500        // line:   *(_DWORD *)(v1 + 0x2FC) = 0x1F4;

        public bool Unknown300; // unused?
        public bool Unknown301; // used!

        public float Unknown304;     // offset: 0x304, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x304) = 0x41A00000;
        public float Unknown308;     // offset: 0x308, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x308) = 0x41200000;
        public float Unknown30C;     // offset: 0x30C, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x30C) = 0x42200000;
        public float Unknown310;     // offset: 0x310, sz: 4, origin: 0x3ECCCCCD, parsed: 0.4        // line:   *(_DWORD *)(v1 + 0x310) = 0x3ECCCCCD;
        public float Unknown314;     // offset: 0x314, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x314) = 0x3FC00000;
        public float Unknown318;     // offset: 0x318, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x318) = 0x44FA0000;
        public float Unknown31C;     // offset: 0x31C, sz: 4, origin: 0x453B8000, parsed: 3000        // line:   *(_DWORD *)(v1 + 0x31C) = 0x453B8000;
        public float Unknown320;     // offset: 0x320, sz: 4, origin: 0x442F0000, parsed: 700        // line:   *(_DWORD *)(v1 + 0x320) = 0x442F0000;
        public float Unknown324;     // offset: 0x324, sz: 4, origin: 0x44480000, parsed: 800        // line:   *(_DWORD *)(v1 + 0x324) = 0x44480000;
        public float Unknown328;     // offset: 0x328, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x328) = 0x41200000;
        public float Unknown32C;     // offset: 0x32C, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x32C) = 0x44FA0000;
        public float Unknown330;     // offset: 0x330, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x330) = 0x41700000;
        public float Unknown334;     // offset: 0x334, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x334) = 0x41200000;
        public float Unknown338;     // offset: 0x338, sz: 4, origin: 0x42100000, parsed: 36        // line:   *(_DWORD *)(v1 + 0x338) = 0x42100000;
        public float Unknown33C;     // offset: 0x33C, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x33C) = 0x3F333333;
        public float Unknown340;     // offset: 0x340, sz: 4, origin: 0x437A0000, parsed: 250        // line:   *(_DWORD *)(v1 + 0x340) = 0x437A0000;
        public float Unknown344;     // offset: 0x344, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x344) = 0x40000000;
        public float Unknown348;     // offset: 0x348, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x348) = 0x41700000;
        public float Unknown34C;     // offset: 0x34C, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(v1 + 0x34C) = 0x40200000;
        public float Unknown350;     // offset: 0x350, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x350) = 0x3F000000;
        public float Unknown354;     // offset: 0x354, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x354) = 0x3F800000;
        public float Unknown358;     // offset: 0x358, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x358) = 0x3F000000;
        public float Unknown35C;     // offset: 0x35C, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x35C) = 0x3F333333;
        public float Unknown360;     // offset: 0x360, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x360) = 0x3E4CCCCD;
        public float Unknown364;     // offset: 0x364, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(v1 + 0x364) = 0x40200000;
        public float Unknown368;     // offset: 0x368, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(v1 + 0x368) = 0x40200000;
        public float Unknown36C;     // offset: 0x36C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x36C) = 0x3F000000;
        public float Unknown370;     // offset: 0x370, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x370) = 0x3F000000;
        public float Unknown374;     // offset: 0x374, sz: 4, origin: 0xC1200000, parsed: -10        // line:   *(_DWORD *)(v1 + 0x374) = 0xC1200000;
        public float Unknown378;     // offset: 0x378, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x378) = 0x41200000;
        public float Unknown37C;     // offset: 0x37C, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x37C) = 0x3E4CCCCD;
        public float Unknown380;     // offset: 0x380, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x380) = 0x3F800000;
        public float Unknown384;     // offset: 0x384, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x384) = 0x41000000;
        public float Unknown388;     // offset: 0x388, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x388) = 0x41200000;
        public float Unknown38C;     // offset: 0x38C, sz: 4, origin: 0x442F0000i64, parsed: 700, comment: two packed floats in a QWORD?(1)
        public float Unknown390;     // offset: 912, sz: 4, origin: 0x442F0000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x38C) = 0x442F0000i64;
        public float Unknown394;     // offset: 0x394, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x394) = 0x3F800000;
        public float Unknown398;     // offset: 0x398, sz: 4, origin: 0x3E19999A, parsed: 0.15        // line:   *(_DWORD *)(v1 + 0x398) = 0x3E19999A;
        public float Unknown39C;     // offset: 0x39C, sz: 4, origin: 0x3F666666, parsed: 0.9        // line:   *(_DWORD *)(v1 + 0x39C) = 0x3F666666;
        public float Unknown3A0;     // offset: 0x3A0, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x3A0) = 0x3FC00000;
        public float Unknown3A4;     // offset: 0x3A4, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x3A4) = 0x3F19999A;
        public float Unknown3A8;     // offset: 0x3A8, sz: 4, origin: 0x41880000, parsed: 17        // line:   *(_DWORD *)(v1 + 0x3A8) = 0x41880000;
        public float Unknown3AC;     // offset: 0x3AC, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x3AC) = 0x43160000;
        public float Unknown3B0;     // offset: 0x3B0, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x3B0) = 0x3FC00000;
        public float Unknown3B4;     // offset: 0x3B4, sz: 4, origin: 0x3F19999Ai64, parsed: 0.6, comment: two packed floats in a QWORD?(1)
        public float Unknown3B8;     // offset: 952, sz: 4, origin: 0x3F19999Ai64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x3B4) = 0x3F19999Ai64;
        public float Unknown3BC;     // offset: 0x3BC, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x3BC) = 0x3F99999A;
        public float Unknown3C0;     // offset: 0x3C0, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x3C0) = 0x42A00000;
        public float Unknown3C4;     // offset: 0x3C4, sz: 4, origin: 0x420C0000, parsed: 35        // line:   *(_DWORD *)(v1 + 0x3C4) = 0x420C0000;
        public float Unknown3C8;     // offset: 0x3C8, sz: 4, origin: 0x3EE66666, parsed: 0.45        // line:   *(_DWORD *)(v1 + 0x3C8) = 0x3EE66666;
        public float Unknown3CC;     // offset: 0x3CC, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x3CC) = 0x3E99999A;
        public float Unknown3D0;     // offset: 0x3D0, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x3D0) = 0x3F19999A;
        public float Unknown3D4;     // offset: 0x3D4, sz: 4, origin: 0x43960000, parsed: 300        // line:   *(_DWORD *)(v1 + 0x3D4) = 0x43960000;
        public float Unknown3D8;     // offset: 0x3D8, sz: 4, origin: 0xC0A00000, parsed: -5        // line:   *(_DWORD *)(v1 + 0x3D8) = 0xC0A00000;
        public float Unknown3DC;     // offset: 0x3DC, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x3DC) = 0x41200000;
        public int Unknown3E0;     // offset: 0x3E0, sz: 4, origin: 7, parsed: 7        // line:   *(_DWORD *)(v1 + 0x3E0) = 7;
        public float Unknown3E4;     // offset: 0x3E4, sz: 4, origin: 0x3ECCCCCD, parsed: 0.4        // line:   *(_DWORD *)(v1 + 0x3E4) = 0x3ECCCCCD;
        public float Unknown3E8;     // offset: 0x3E8, sz: 4, origin: 0x3C23D70Ai64, parsed: 0.01, comment: two packed floats in a QWORD?(1)
        public float Unknown3EC;     // offset: 1004, sz: 4, origin: 0x3C23D70Ai64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x3E8) = 0x3C23D70Ai64;
        public float Unknown3F0;     // offset: 0x3F0, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x3F0) = 0x42C80000;
        public float Unknown3F4;     // offset: 0x3F4, sz: 4, origin: 0x42F00000, parsed: 120        // line:   *(_DWORD *)(v1 + 0x3F4) = 0x42F00000;
        public float Unknown3F8;     // offset: 0x3F8, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x3F8) = 0x3E4CCCCD;
        public float Unknown3FC;     // offset: 0x3FC, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x3FC) = 0x3F000000;
        public float Unknown400;     // offset: 0x400, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x400) = 0x41A00000;

        // missing 12 bytes at offset 1024
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding404;        // offset: 1028, sz: 12, comment: auto padding 

        public float Unknown410;     // offset: 0x410, sz: 4, origin: 0xC0000000, parsed: -2        // line:   *(_DWORD *)(v1 + 0x410) = 0xC0000000;
        public float Unknown414;     // offset: 0x414, sz: 4, origin: 0xC0000000, parsed: -2        // line:   *(_DWORD *)(v1 + 0x414) = 0xC0000000;
        public float Unknown418;
        // line:   *(_DWORD *)(v1 + 0x418) = v2;

        // missing 8 bytes at offset 1044
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding41C;        // offset: 1048, sz: 8, comment: auto padding 

        public float Unknown420;     // offset: 0x420, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x420) = 0x40000000;
        public float Unknown424;     // offset: 0x424, sz: 4, origin: 0xC0000000, parsed: -2        // line:   *(_DWORD *)(v1 + 0x424) = 0xC0000000;
        public float Unknown428;
        // line:   *(_DWORD *)(v1 + 0x428) = v2;

        // missing 8 bytes at offset 1060
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding42C;        // offset: 1064, sz: 8, comment: auto padding 

        public float Unknown430;     // offset: 0x430, sz: 4, origin: 0x3F800000i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown434;     // offset: 1076, sz: 4, origin: 0x3F800000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x430) = 0x3F800000i64;
        public float Unknown438;     // offset: 0x438, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x438) = 0x42480000;
        public float Unknown43C;     // offset: 0x43C, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x43C) = 0x43FA0000;
        public float Unknown440;     // offset: 0x440, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x440) = 0x40000000;
        public float Unknown444;     // offset: 0x444, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x444) = 0x42C80000;
        public float Unknown448;     // offset: 0x448, sz: 4, origin: 0x3E800000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 0x448) = 0x3E800000;
        public float Unknown44C;     // offset: 0x44C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x44C) = 0x3F800000;
        public float Unknown450;     // offset: 0x450, sz: 4, origin: 0x3F000000i64, parsed: 0.5, comment: two packed floats in a QWORD?(1)
        public float Unknown454;     // offset: 1108, sz: 4, origin: 0x3F000000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x450) = 0x3F000000i64;
        public float Unknown458;     // offset: 0x458, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x458) = 0x43FA0000;
        public float Unknown45C;     // offset: 0x45C, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x45C) = 0x447A0000;
        public float Unknown460;     // offset: 0x460, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x460) = 0x3F800000;
        public float Unknown464;     // offset: 0x464, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x464) = 0x41200000;
        public float Unknown468;     // offset: 0x468, sz: 4, origin: 0x3F0CCCCD, parsed: 0.55        // line:   *(_DWORD *)(v1 + 0x468) = 0x3F0CCCCD;
        public float Unknown46C;     // offset: 0x46C, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x46C) = 0x3F333333;
        public float Unknown470;     // offset: 0x470, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x470) = 0x3F800000;
        public float Unknown474;     // offset: 0x474, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x474) = 0x43160000;
        public float Unknown478;     // offset: 0x478, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x478) = 0x40A00000;
        public float Unknown47C;     // offset: 0x47C, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x47C) = 0x42C80000;
        public float Unknown480;     // offset: 0x480, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x480) = 0x41A00000;
        public float Unknown484;     // offset: 0x484, sz: 4, origin: 0xC1700000, parsed: -15        // line:   *(_DWORD *)(v1 + 0x484) = 0xC1700000;
        public float Unknown488;     // offset: 0x488, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x488) = 0x3F000000;
        public float Unknown48C;     // offset: 0x48C, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x48C) = 0x3F4CCCCD;
        public float Unknown490;     // offset: 0x490, sz: 4, origin: 0x41A80000, parsed: 21        // line:   *(_DWORD *)(v1 + 0x490) = 0x41A80000;
        public float Unknown494;     // offset: 0x494, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x494) = 0x41200000;
        public float Unknown498;     // offset: 0x498, sz: 4, origin: 0x3FE66666, parsed: 1.8        // line:   *(_DWORD *)(v1 + 0x498) = 0x3FE66666;
        public float Unknown49C;     // offset: 0x49C, sz: 4, origin: 0x41C80000, parsed: 25        // line:   *(_DWORD *)(v1 + 0x49C) = 0x41C80000;
        public float Unknown4A0;     // offset: 0x4A0, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x4A0) = 0x3F99999A;
        public float Unknown4A4;     // offset: 0x4A4, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x4A4) = 0x42C80000;
        public float Unknown4A8;     // offset: 0x4A8, sz: 4, origin: 0x49742400, parsed: 1000000        // line:   *(_DWORD *)(v1 + 0x4A8) = 0x49742400;

        // missing 4 bytes at offset 1192
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4AC;        // offset: 1196, sz: 4, comment: auto padding 

        public float Unknown4B0;     // offset: 0x4B0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4B0) = 0x3F800000;
        public float Unknown4B4;     // offset: 0x4B4, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4B4) = 0x3F800000;
        public float Unknown4B8;     // offset: 0x4B8, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4B8) = 0x3F800000;

        // missing 4 bytes at offset 1208
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4BC;        // offset: 1212, sz: 4, comment: auto padding 

        public float Unknown4C0;     // offset: 0x4C0, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x4C0) = 0x3F333333;
        public float Unknown4C4;     // offset: 0x4C4, sz: 4, origin: 0x437A0000, parsed: 250        // line:   *(_DWORD *)(v1 + 0x4C4) = 0x437A0000;
        public float Unknown4C8;     // offset: 0x4C8, sz: 4, origin: 0x3FA66666, parsed: 1.3        // line:   *(_DWORD *)(v1 + 0x4C8) = 0x3FA66666;
        public float Unknown4CC;     // offset: 0x4CC, sz: 4, origin: 0x3ECCCCCD, parsed: 0.4        // line:   *(_DWORD *)(v1 + 0x4CC) = 0x3ECCCCCD;
        public float Unknown4D0;     // offset: 0x4D0, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x4D0) = 0x3F333333;
        public float Unknown4D4;     // offset: 0x4D4, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x4D4) = 0x3E4CCCCD;
        public float Unknown4D8;     // offset: 0x4D8, sz: 4, origin: 0x3E800000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 0x4D8) = 0x3E800000;
        public float Unknown4DC;     // offset: 0x4DC, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4DC) = 0x3F800000;
        public float Unknown4E0;     // offset: 0x4E0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4E0) = 0x3F800000;
        public float Unknown4E4;     // offset: 0x4E4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x4E4) = 0x40000000;
        public float Unknown4E8;     // offset: 0x4E8, sz: 4, origin: 0x44AF0000, parsed: 1400        // line:   *(_DWORD *)(v1 + 0x4E8) = 0x44AF0000;
        public float Unknown4EC;     // offset: 0x4EC, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4EC) = 0x3F800000;
        public float Unknown4F0;     // offset: 0x4F0, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x4F0) = 0x41A00000;
        public float Unknown4F4;     // offset: 0x4F4, sz: 4, origin: 0x41400000, parsed: 12        // line:   *(_DWORD *)(v1 + 0x4F4) = 0x41400000;
        public float Unknown4F8;     // offset: 0x4F8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x4F8) = 0x40400000;
        public float Unknown4FC;     // offset: 0x4FC, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4FC) = 0x3F800000;
        public float Unknown500;     // offset: 0x500, sz: 4, origin: 0x40400000i64, parsed: 3, comment: two packed floats in a QWORD?(1)
        public float Unknown504;     // offset: 1284, sz: 4, origin: 0x40400000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x500) = 0x40400000i64;
        public float Unknown508;     // offset: 0x508, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x508) = 0x42C80000;
        public float Unknown50C;     // offset: 0x50C, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x50C) = 0x3F19999A;
        public float Unknown510;     // offset: 0x510, sz: 4, origin: 0x42B40000, parsed: 90        // line:   *(_DWORD *)(v1 + 0x510) = 0x42B40000;
        public float Unknown514;     // offset: 0x514, sz: 4, origin: 0xC2C80000, parsed: -100        // line:   *(_DWORD *)(v1 + 0x514) = 0xC2C80000;
        public float Unknown518;     // offset: 0x518, sz: 4, origin: 0x420C0000, parsed: 35        // line:   *(_DWORD *)(v1 + 0x518) = 0x420C0000;
        public float Unknown51C;     // offset: 0x51C, sz: 4, origin: 0x43480000, parsed: 200        // line:   *(_DWORD *)(v1 + 0x51C) = 0x43480000;
        public float Unknown520;     // offset: 0x520, sz: 4, origin: 0x43960000, parsed: 300        // line:   *(_DWORD *)(v1 + 0x520) = 0x43960000;
        public float Unknown524;     // offset: 0x524, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x524) = 0x43FA0000;
        public float Unknown528;     // offset: 0x528, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x528) = 0x42C80000;
        public float Unknown52C;     // offset: 0x52C, sz: 4, origin: 0x3E19999A, parsed: 0.15        // line:   *(_DWORD *)(v1 + 0x52C) = 0x3E19999A;
        public float Unknown530;     // offset: 0x530, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x530) = 0x43160000;
        public float Unknown534;     // offset: 0x534, sz: 4, origin: 0x47C35000, parsed: 100000        // line:   *(_DWORD *)(v1 + 0x534) = 0x47C35000;
        public float Unknown538;     // offset: 0x538, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x538) = 0x44FA0000;
        public float Unknown53C;     // offset: 0x53C, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x53C) = 0x43160000;
        public float Unknown540;     // offset: 0x540, sz: 4, origin: 0x40800000, parsed: 4        // line:   *(_DWORD *)(v1 + 0x540) = 0x40800000;
        public float Unknown544;     // offset: 0x544, sz: 4, origin: 0x40E00000, parsed: 7        // line:   *(_DWORD *)(v1 + 0x544) = 0x40E00000;
        public float Unknown548;     // offset: 0x548, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x548) = 0x41A00000;
        public float Unknown54C;     // offset: 0x54C, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x54C) = 0x3E99999A;
        public float Unknown550;     // offset: 0x550, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x550) = 0x41700000;
        public float Unknown554;     // offset: 0x554, sz: 4, origin: 0x3F400000, parsed: 0.75        // line:   *(_DWORD *)(v1 + 0x554) = 0x3F400000;
        public float Unknown558;     // offset: 0x558, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x558) = 0x3F4CCCCD;
        public float Unknown55C;     // offset: 0x55C, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x55C) = 0x41700000;
        public float Unknown560;     // offset: 0x560, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x560) = 0x3F000000;
        [NMS(Size = 0x80)]
        public string Unknown564;     // offset: 0x564, sz: 128, origin:  "MODELS/COMMON/SPACECRAFT/DROPSHIPS/DROPSHIP_PROC.DAE"        // line:   strncpy((char *)(v1 + 0x564), "MODELS/COMMON/SPACECRAFT/DROPSHIPS/DROPSHIP_PROC.DAE", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 0x5E3) = 0;
        [NMS(Size = 0x80)]
        public string Unknown5E4;     // offset: 0x5E4, sz: 128, origin:  "MODELS/COMMON/SPACECRAFT/FIGHTERS/FIGHTER_PROC.DAE"        // line:   strncpy((char *)(v1 + 0x5E4), "MODELS/COMMON/SPACECRAFT/FIGHTERS/FIGHTER_PROC.DAE", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 0x663) = 0;
        [NMS(Size = 0x80)]
        public string Unknown664;     // offset: 0x664, sz: 128, origin:  "MODELS/COMMON/SPACECRAFT/SCIENTIFIC/SCIENTIFIC_PROC.DAE"        // line:   strncpy((char *)(v1 + 0x664), "MODELS/COMMON/SPACECRAFT/SCIENTIFIC/SCIENTIFIC_PROC.DAE", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 0x6E3) = 0;
        [NMS(Size = 0x80)]
        public string Unknown6E4;     // offset: 0x6E4, sz: 128, origin:  "MODELS/COMMON/SPACECRAFT/SHUTTLE/SHUTTLE_PROC.DAE"        // line:   result = strncpy((char *)(v1 + 0x6E4), "MODELS/COMMON/SPACECRAFT/SHUTTLE/SHUTTLE_PROC.DAE", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 0x763) = 0;
        public float Unknown764;     // offset: 0x764, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x764) = 0x41200000;
        // line:   return result;
        // line: }
        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding768;
    }
}
