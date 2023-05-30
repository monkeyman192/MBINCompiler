using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals // 0x690
{
    public class GcCreatureGlobals : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: char *__fastcall GcCreatureGlobals_LoadDefaults(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        // line:   char *result; // rax@1
        // line:   v1 = a1;
        public bool Unknown0;     // offset: 0, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)a1 = 0;
        public float Unknown4;     // offset: 4, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 4) = 0;
        public float Unknown8;     // offset: 8, sz: 4, origin: 0x3F800000i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float UnknownC;     // offset: 12, sz: 4, origin: 0x3F800000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 8) = 0x3F800000i64;

        public float Unknown10;     // offset: 0x10, sz: 4, origin: 0x3D4CCCCD, parsed: 0.05        // line:   *(_DWORD *)(a1 + 0x10) = 0x3D4CCCCD;
        public float Unknown14;     // offset: 0x14, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(a1 + 0x14) = 0x40A00000;
        public float Unknown18;     // offset: 0x18, sz: 4, origin: 0x41400000, parsed: 12        // line:   *(_DWORD *)(a1 + 0x18) = 0x41400000;
        public float Unknown1C;     // offset: 0x1C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0x1C) = 0x3F800000;

        public float Unknown20;     // offset: 0x20, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0x20) = 0x3F800000;
        public float Unknown24;     // offset: 0x24, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(a1 + 0x24) = 0x3E4CCCCD;
        public float Unknown28;     // offset: 0x28, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(a1 + 0x28) = 0x41000000;
        public float Unknown2C;     // offset: 0x2C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x2C) = 0x41200000;

        public float Unknown30;     // offset: 0x30, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(a1 + 0x30) = 0x42C80000;
        public float Unknown34;     // offset: 0x34, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(a1 + 0x34) = 0x3DCCCCCD;
        public float Unknown38;     // offset: 0x38, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(a1 + 0x38) = 0x3DCCCCCD;
        public float Unknown3C;     // offset: 0x3C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0x3C) = 0x3F800000;

        public float Unknown40;     // offset: 0x40, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x40) = 0x41200000;
        public float Unknown44;     // offset: 0x44, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(a1 + 0x44) = 0x3DCCCCCD;
        public float Unknown48;     // offset: 0x48, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(a1 + 0x48) = 0x3FC00000;
        public float Unknown4C;     // offset: 0x4C, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(a1 + 0x4C) = 0x3F800000;

        public float Unknown50;     // offset: 0x50, sz: 4, origin: 0x3EB33333, parsed: 0.35        // line:   *(_DWORD *)(a1 + 0x50) = 0x3EB33333;
        public float Unknown54;     // offset: 0x54, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(a1 + 0x54) = 0x40200000;
        public float Unknown58;     // offset: 0x58, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(a1 + 0x58) = 0x40200000;
        public float Unknown5C;     // offset: 0x5C, sz: 4, origin: 0x3F666666, parsed: 0.9        // line:   *(_DWORD *)(a1 + 0x5C) = 0x3F666666;

        public float Unknown60;     // offset: 0x60, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(a1 + 0x60) = 0x41200000;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding64;        // offset: 100, sz: 12, comment: auto padding 

        public GcCameraShakeData Unknown70;

        public float Unknown130;     // offset: 0x130, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x130) = 0x3F000000;
        public float Unknown134;     // offset: 0x134, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x134) = 0x3F800000;
        public float Unknown138;     // offset: 0x138, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x138) = 0x3F000000;
        public float Unknown13C;     // offset: 0x13C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x13C) = 0x40400000;

        public float Unknown140;     // offset: 0x140, sz: 4, origin: 0x44480000, parsed: 800        // line:   *(_DWORD *)(v1 + 0x140) = 0x44480000;
        public float Unknown144;     // offset: 0x144, sz: 4, origin: 0x442F0000, parsed: 700        // line:   *(_DWORD *)(v1 + 0x144) = 0x442F0000;
        public float Unknown148;     // offset: 0x148, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x148) = 0x40A00000;
        public float Unknown14C;     // offset: 0x14C, sz: 4, origin: 0x44610000, parsed: 900        // line:   *(_DWORD *)(v1 + 0x14C) = 0x44610000;

        public float Unknown150;     // offset: 0x150, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x150) = 0x40A00000;
        public float Unknown154;     // offset: 0x154, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x154) = 0x3F800000;
        public float Unknown158;     // offset: 0x158, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x158) = 0x42200000;
        public float Unknown15C;     // offset: 0x15C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x15C) = 0x41200000;

        public float Unknown160;     // offset: 0x160, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x160) = 0x3F800000;
        public float Unknown164;     // offset: 0x164, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x164) = 0x3F800000;
        public float Unknown168;     // offset: 0x168, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x168) = 0x40000000;
        public float Unknown16C;     // offset: 0x16C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x16C) = 0x3F000000;

        public float Unknown170;     // offset: 0x170, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x170) = 0x41200000;
        public float Unknown174;     // offset: 0x174, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x174) = 0x40400000;
        public float Unknown178;     // offset: 0x178, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x178) = 0x42480000;
        public float Unknown17C;     // offset: 0x17C, sz: 4, origin: 0x447A0000, parsed: 1000        // line:   *(_DWORD *)(v1 + 0x17C) = 0x447A0000;

        public float Unknown180;     // offset: 0x180, sz: 4, origin: 0x40A33333, parsed: 5.1        // line:   *(_DWORD *)(v1 + 0x180) = 0x40A33333;
        public float Unknown184;     // offset: 0x184, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x184) = 0x3F800000;
        public float Unknown188;     // offset: 0x188, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x188) = 0x3E99999A;
        public float Unknown18C;     // offset: 0x18C, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x18C) = 0x3F000000;

        public float Unknown190;     // offset: 0x190, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x190) = 0x3E99999A;
        public float Unknown194;     // offset: 0x194, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x194) = 0x41700000;
        public float Unknown198;     // offset: 0x198, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x198) = 0x41A00000;
        public float Unknown19C;     // offset: 0x19C, sz: 4, origin: 0x3A83126F, parsed: 0.001        // line:   *(_DWORD *)(v1 + 0x19C) = 0x3A83126F;

        public float Unknown1A0;     // offset: 0x1A0, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x1A0) = 0x3F4CCCCD;
        public float Unknown1A4;     // offset: 0x1A4, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x1A4) = 0x3F000000;
        public float Unknown1A8;     // offset: 0x1A8, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x1A8) = 0x42480000;
        public float Unknown1AC;     // offset: 0x1AC, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x1AC) = 0x3E99999A;

        public float Unknown1B0;     // offset: 0x1B0, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x1B0) = 0x41200000;
        public float Unknown1B4;     // offset: 0x1B4, sz: 4, origin: 0x41900000, parsed: 18        // line:   *(_DWORD *)(v1 + 0x1B4) = 0x41900000;
        public float Unknown1B8;     // offset: 0x1B8, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x1B8) = 0x40000000;
        public float Unknown1BC;     // offset: 0x1BC, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x1BC) = 0x40400000;

        public float Unknown1C0;     // offset: 0x1C0, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x1C0) = 0x41000000;
        public float Unknown1C4;     // offset: 0x1C4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x1C4) = 0x40000000;
        public float Unknown1C8;     // offset: 0x1C8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x1C8) = 0x40400000;
        public float Unknown1CC;     // offset: 0x1CC, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x1CC) = 0x42C80000;

        public float Unknown1D0;     // offset: 0x1D0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x1D0) = 0x3F800000;
        public float Unknown1D4;     // offset: 0x1D4, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x1D4) = 0x40A00000;
        public float Unknown1D8;     // offset: 0x1D8, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x1D8) = 0x3E99999A;
        public float Unknown1DC;     // offset: 0x1DC, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x1DC) = 0x42480000;

        public float Unknown1E0;     // offset: 0x1E0, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x1E0) = 0x40A00000;
        public float Unknown1E4;     // offset: 0x1E4, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x1E4) = 0x3F800000;
        public float Unknown1E8;     // offset: 0x1E8, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(v1 + 0x1E8) = 0x40200000;
        public float Unknown1EC;     // offset: 0x1EC, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x1EC) = 0x40400000;

        public float Unknown1F0;     // offset: 0x1F0, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x1F0) = 0x41F00000;
        public float Unknown1F4;     // offset: 0x1F4, sz: 4, origin: 0x43FA0000, parsed: 500        // line:   *(_DWORD *)(v1 + 0x1F4) = 0x43FA0000;
        public float Unknown1F8;     // offset: 0x1F8, sz: 4, origin: 0x42480000, parsed: 50        // line:   *(_DWORD *)(v1 + 0x1F8) = 0x42480000;
        public float Unknown1FC;     // offset: 0x1FC, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x1FC) = 0x3DCCCCCD;

        public float Unknown200;     // offset: 0x200, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x200) = 0x3F19999A;
        public float Unknown204;     // offset: 0x204, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x204) = 0x41700000;
        public float Unknown208;     // offset: 0x208, sz: 4, origin: 0x41600000, parsed: 14        // line:   *(_DWORD *)(v1 + 0x208) = 0x41600000;
        public float Unknown20C;     // offset: 0x20C, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x20C) = 0x42C80000;

        public float Unknown210;     // offset: 0x210, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x210) = 0x3FC00000;
        public float Unknown214;     // offset: 0x214, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x214) = 0x40400000;
        public float Unknown218;     // offset: 0x218, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x218) = 0x40A00000;
        public float Unknown21C;     // offset: 0x21C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x21C) = 0x40400000;

        public float Unknown220;     // offset: 0x220, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x220) = 0x41000000;
        public float Unknown224;     // offset: 0x224, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x224) = 0x40A00000;
        public float Unknown228;     // offset: 0x228, sz: 4, origin: 0x41700000i64, parsed: 15, comment: two packed floats in a QWORD?(1)
        public float Unknown22C;     // offset: 556, sz: 4, origin: 0x41700000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x228) = 0x41700000i64;

        public float Unknown230;     // offset: 0x230, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 0x230) = 0;
        public float Unknown234;     // offset: 0x234, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x234) = 0x40A00000;
        public float Unknown238;     // offset: 0x238, sz: 4, origin: 0x40C00000i64, parsed: 6, comment: two packed floats in a QWORD?(1)
        public float Unknown23C;     // offset: 572, sz: 4, origin: 0x40C00000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x238) = 0x40C00000i64;

        public float Unknown240;     // offset: 0x240, sz: 4, origin: 0x41600000i64, parsed: 14, comment: two packed floats in a QWORD?(1)
        public float Unknown244;     // offset: 580, sz: 4, origin: 0x41600000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x240) = 0x41600000i64;
        public float Unknown248;     // offset: 0x248, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 0x248) = 0;
        public float Unknown24C;     // offset: 0x24C, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x24C) = 0x42C80000;

        public float Unknown250;     // offset: 0x250, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x250) = 0x43160000;
        public float Unknown254;     // offset: 0x254, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x254) = 0x42700000;
        public float Unknown258;     // offset: 0x258, sz: 4, origin: 0x41700000i64, parsed: 15, comment: two packed floats in a QWORD?(1)
        public float Unknown25C;     // offset: 604, sz: 4, origin: 0x41700000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x258) = 0x41700000i64;

        public float Unknown260;     // offset: 0x260, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 0x260) = 0;
        public float Unknown264;     // offset: 0x264, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x264) = 0x42C80000;
        public float Unknown268;     // offset: 0x268, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x268) = 0x43160000;
        public float Unknown26C;     // offset: 0x26C, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x26C) = 0x42700000;

        public float Unknown270;     // offset: 0x270, sz: 4, origin: 0x41700000i64, parsed: 15, comment: two packed floats in a QWORD?(1)
        public float Unknown274;     // offset: 628, sz: 4, origin: 0x41700000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x270) = 0x41700000i64;
        public float Unknown278;     // offset: 0x278, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 0x278) = 0;
        public float Unknown27C;     // offset: 0x27C, sz: 4, origin: 0x42C80000, parsed: 100        // line:   *(_DWORD *)(v1 + 0x27C) = 0x42C80000;

        public float Unknown280;     // offset: 0x280, sz: 4, origin: 0x43160000, parsed: 150        // line:   *(_DWORD *)(v1 + 0x280) = 0x43160000;
        public float Unknown284;     // offset: 0x284, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x284) = 0x42700000;
        public float Unknown288;     // offset: 0x288, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x288) = 0x41700000;
        public bool Unknown28C;     // offset: 0x28C, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 0x28C) = 0;

        public float Unknown290;     // offset: 0x290, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x290) = 0x3F99999A;
        public float Unknown294;     // offset: 0x294, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(v1 + 0x294) = 0x40200000;
        public float Unknown298;     // offset: 0x298, sz: 4, origin: 0x40900000, parsed: 4.5        // line:   *(_DWORD *)(v1 + 0x298) = 0x40900000;
        public int Unknown29C;     // offset: 0x29C, sz: 4, origin: 0x28, parsed: 40        // line:   *(_DWORD *)(v1 + 0x29C) = 0x28;

        public int Unknown2A0;     // offset: 0x2A0, sz: 4, origin: 0x50, parsed: 80        // line:   *(_DWORD *)(v1 + 0x2A0) = 0x50;
        public int Unknown2A4;     // offset: 0x2A4, sz: 4, origin: 0xA0, parsed: 160        // line:   *(_DWORD *)(v1 + 0x2A4) = 0xA0;
        public int Unknown2A8;     // offset: 0x2A8, sz: 4, origin: 0x168, parsed: 360        // line:   *(_DWORD *)(v1 + 0x2A8) = 0x168;

        // missing 4 bytes at offset 680
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2AC;        // offset: 684, sz: 4, comment: auto padding 

        public NMSString0x10 Unknown2B0;     // offset: 0x2B0, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 0x2B0), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 0x2B0));
        // line:   *(_BYTE *)(v1 + 0x2BF) = 0;
        public float Unknown2C0;     // offset: 0x2C0, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x2C0) = 0x40000000;

        // missing 4 bytes at offset 704
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2C4;        // offset: 708, sz: 4, comment: auto padding 

        public NMSString0x10 Unknown2C8;     // offset: 0x2C8, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 0x2C8), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 0x2C8));
        // line:   *(_BYTE *)(v1 + 0x2D7) = 0;
        public float Unknown2D8;     // offset: 0x2D8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x2D8) = 0x40400000;

        // missing 4 bytes at offset 728
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2DC;        // offset: 732, sz: 4, comment: auto padding 

        public NMSString0x10 Unknown2E0;     // offset: 0x2E0, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 0x2E0), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 0x2E0));
        // line:   *(_BYTE *)(v1 + 0x2EF) = 0;
        public float Unknown2F0;     // offset: 0x2F0, sz: 4, origin: 0x40800000, parsed: 4        // line:   *(_DWORD *)(v1 + 0x2F0) = 0x40800000;

        // missing 4 bytes at offset 752
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2F4;        // offset: 756, sz: 4, comment: auto padding 

        public NMSString0x10 Unknown2F8;     // offset: 0x2F8, sz: 15, origin:  "LARGECREATUREWA"        // line:   strncpy((char *)(v1 + 0x2F8), "LARGECREATUREWA", 0xFui64);
        // line:   strupr((char *)(v1 + 0x2F8));
        // line:   *(_BYTE *)(v1 + 0x307) = 0;
        public float Unknown308;     // offset: 0x308, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x308) = 0x41000000;
        public float Unknown30C;     // offset: 0x30C, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x30C) = 0x41F00000;

        public float Unknown310;     // offset: 0x310, sz: 4, origin: 0x428C0000, parsed: 70        // line:   *(_DWORD *)(v1 + 0x310) = 0x428C0000;
        public float Unknown314;     // offset: 0x314, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x314) = 0x41700000;
        public float Unknown318;     // offset: 0x318, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x318) = 0x42700000;
        public float Unknown31C;     // offset: 0x31C, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x31C) = 0x40400000;

        public float Unknown320;     // offset: 0x320, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x320) = 0x42200000;
        public float Unknown324;     // offset: 0x324, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x324) = 0x42200000;
        public float Unknown328;     // offset: 0x328, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x328) = 0x41200000;
        public float Unknown32C;     // offset: 0x32C, sz: 4, origin: 0x428C0000, parsed: 70        // line:   *(_DWORD *)(v1 + 0x32C) = 0x428C0000;

        public int Unknown330;     // offset: 0x330, sz: 4, origin: 0x6E, parsed: 110        // line:   *(_DWORD *)(v1 + 0x330) = 0x6E;
        public int Unknown334;     // offset: 0x334, sz: 4, origin: 0x78, parsed: 120        // line:   *(_DWORD *)(v1 + 0x334) = 0x78;
        public int Unknown338;     // offset: 0x338, sz: 4, origin: 0x96, parsed: 150        // line:   *(_DWORD *)(v1 + 0x338) = 0x96;
        public int Unknown33C;     // offset: 0x33C, sz: 4, origin: 0xA0, parsed: 160        // line:   *(_DWORD *)(v1 + 0x33C) = 0xA0;

        public int Unknown340;     // offset: 0x340, sz: 4, origin: 0x5D, parsed: 93        // line:   *(_DWORD *)(v1 + 0x340) = 0x5D;
        public float Unknown344;     // offset: 0x344, sz: 4, origin: 0x40800000, parsed: 4        // line:   *(_DWORD *)(v1 + 0x344) = 0x40800000;
        public float Unknown348;     // offset: 0x348, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x348) = 0x3FC00000;
        public float Unknown34C;     // offset: 0x34C, sz: 4, origin: 0x41300000, parsed: 11        // line:   *(_DWORD *)(v1 + 0x34C) = 0x41300000;

        public float Unknown350;     // offset: 0x350, sz: 4, origin: 0x40E00000, parsed: 7        // line:   *(_DWORD *)(v1 + 0x350) = 0x40E00000;
        public float Unknown354;     // offset: 0x354, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x354) = 0x3E99999A;
        public float Unknown358;     // offset: 0x358, sz: 4, origin: 0x40E00000, parsed: 7        // line:   *(_DWORD *)(v1 + 0x358) = 0x40E00000;
        public float Unknown35C;     // offset: 0x35C, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x35C) = 0x3E99999A;

        public float Unknown360;     // offset: 0x360, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x360) = 0x42700000;
        public float Unknown364;     // offset: 0x364, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x364) = 0x42A00000;
        public float Unknown368;     // offset: 0x368, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x368) = 0x41F00000;
        public float Unknown36C;     // offset: 0x36C, sz: 4, origin: 0x41F00000, parsed: 30        // line:   *(_DWORD *)(v1 + 0x36C) = 0x41F00000;

        public float Unknown370;     // offset: 0x370, sz: 4, origin: 0x40A00000, parsed: 5        // line:   *(_DWORD *)(v1 + 0x370) = 0x40A00000;
        public float Unknown374;     // offset: 0x374, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x374) = 0x3F19999A;
        public float Unknown378;     // offset: 0x378, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x378) = 0x3F333333;
        public float Unknown37C;     // offset: 0x37C, sz: 4, origin: 0x42200000, parsed: 40        // line:   *(_DWORD *)(v1 + 0x37C) = 0x42200000;

        public float Unknown380;     // offset: 0x380, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x380) = 0x3F800000;
        public float Unknown384;     // offset: 0x384, sz: 4, origin: 0x45849000, parsed: 4242        // line:   *(_DWORD *)(v1 + 0x384) = 0x45849000;
        public float Unknown388;     // offset: 0x388, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x388) = 0x3F19999A;
        public float Unknown38C;     // offset: 0x38C, sz: 4, origin: 0x3F666666, parsed: 0.9        // line:   *(_DWORD *)(v1 + 0x38C) = 0x3F666666;

        public float Unknown390;     // offset: 0x390, sz: 4, origin: 0x420C0000, parsed: 35        // line:   *(_DWORD *)(v1 + 0x390) = 0x420C0000;
        public float Unknown394;     // offset: 0x394, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x394) = 0x41A00000;
        public float Unknown398;     // offset: 0x398, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x398) = 0x3F4CCCCD;
        public float Unknown39C;     // offset: 0x39C, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x39C) = 0x40000000;

        public int Unknown3A0;     // offset: 0x3A0, sz: 4, origin: 0xC, parsed: 12        // line:   *(_DWORD *)(v1 + 0x3A0) = 0xC;
        public int Unknown3A4;     // offset: 0x3A4, sz: 4, origin: 0x12, parsed: 18        // line:   *(_DWORD *)(v1 + 0x3A4) = 0x12;
        public float Unknown3A8;     // offset: 0x3A8, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x3A8) = 0x3F800000;
        public float Unknown3AC;     // offset: 0x3AC, sz: 4, origin: 0x3F400000, parsed: 0.75        // line:   *(_DWORD *)(v1 + 0x3AC) = 0x3F400000;

        public float Unknown3B0;     // offset: 0x3B0, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x3B0) = 0x3F333333;
        public float Unknown3B4;     // offset: 0x3B4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x3B4) = 0x40000000;
        public float Unknown3B8;     // offset: 0x3B8, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x3B8) = 0x3E4CCCCD;
        public float Unknown3BC;     // offset: 0x3BC, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x3BC) = 0x3F19999A;

        public float Unknown3C0;     // offset: 0x3C0, sz: 4, origin: 0x41700000, parsed: 15        // line:   *(_DWORD *)(v1 + 0x3C0) = 0x41700000;
        public float Unknown3C4;     // offset: 0x3C4, sz: 4, origin: 0x41800000, parsed: 16        // line:   *(_DWORD *)(v1 + 0x3C4) = 0x41800000;
        public float Unknown3C8;     // offset: 0x3C8, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x3C8) = 0x3F333333;
        public float Unknown3CC;     // offset: 0x3CC, sz: 4, origin: 0x40C00000, parsed: 6        // line:   *(_DWORD *)(v1 + 0x3CC) = 0x40C00000;

        public float Unknown3D0;     // offset: 0x3D0, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x3D0) = 0x3F800000;
        public float Unknown3D4;     // offset: 0x3D4, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x3D4) = 0x40000000;
        public float Unknown3D8;     // offset: 0x3D8, sz: 4, origin: 0x40800000, parsed: 4        // line:   *(_DWORD *)(v1 + 0x3D8) = 0x40800000;
        public float Unknown3DC;     // offset: 0x3DC, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x3DC) = 0x3F800000;

        public float Unknown3E0;     // offset: 0x3E0, sz: 4, origin: 0x40200000, parsed: 2.5        // line:   *(_DWORD *)(v1 + 0x3E0) = 0x40200000;
        public float Unknown3E4;     // offset: 0x3E4, sz: 4, origin: 0x40C00000, parsed: 6        // line:   *(_DWORD *)(v1 + 0x3E4) = 0x40C00000;
        public float Unknown3E8;     // offset: 0x3E8, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x3E8) = 0x40400000;
        public float Unknown3EC;     // offset: 0x3EC, sz: 4, origin: 0x40C00000, parsed: 6        // line:   *(_DWORD *)(v1 + 0x3EC) = 0x40C00000;

        public float Unknown3F0;     // offset: 0x3F0, sz: 4, origin: 0x3E800000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 0x3F0) = 0x3E800000;
        public float Unknown3F4;     // offset: 0x3F4, sz: 4, origin: 0x3E800000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 0x3F4) = 0x3E800000;
        public float Unknown3F8;     // offset: 0x3F8, sz: 4, origin: 0x40C00000, parsed: 6        // line:   *(_DWORD *)(v1 + 0x3F8) = 0x40C00000;
        public float Unknown3FC;     // offset: 0x3FC, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x3FC) = 0x40400000;

        public float Unknown400;     // offset: 0x400, sz: 4, origin: 0x40C00000, parsed: 6        // line:   *(_DWORD *)(v1 + 0x400) = 0x40C00000;
        public float Unknown404;     // offset: 0x404, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x404) = 0x40000000;
        public float Unknown408;     // offset: 0x408, sz: 4, origin: 0x3FC00000, parsed: 1.5        // line:   *(_DWORD *)(v1 + 0x408) = 0x3FC00000;
        public float Unknown40C;     // offset: 0x40C, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x40C) = 0x42700000;

        public float Unknown410;     // offset: 0x410, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x410) = 0x41200000;
        public float Unknown414;     // offset: 0x414, sz: 4, origin: 0x42700000, parsed: 60        // line:   *(_DWORD *)(v1 + 0x414) = 0x42700000;
        public float Unknown418;     // offset: 0x418, sz: 4, origin: 0x44FA0000, parsed: 2000        // line:   *(_DWORD *)(v1 + 0x418) = 0x44FA0000;
        public int Unknown41C;     // offset: 0x41C, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(v1 + 0x41C) = 4;

        public bool Unknown420;     // offset: 0x420, sz: 2, origin: 0, parsed: 0        // line:   *(_WORD *)(v1 + 0x420) = 0;
        public bool Unknown421;
        public float Unknown424;     // offset: 0x424, sz: 4, origin: 0x42A00000, parsed: 80        // line:   *(_DWORD *)(v1 + 0x424) = 0x42A00000;
        public bool Unknown428;     // offset: 0x428, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 0x428) = 1;
        public float Unknown42C;     // offset: 0x42C, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x42C) = 0x3E4CCCCD;

        public float Unknown430;     // offset: 0x430, sz: 4, origin: 0x3E4CCCCD, parsed: 0.2        // line:   *(_DWORD *)(v1 + 0x430) = 0x3E4CCCCD;
        public float Unknown434;     // offset: 0x434, sz: 4, origin: 0x3ECCCCCD, parsed: 0.4        // line:   *(_DWORD *)(v1 + 0x434) = 0x3ECCCCCD;
        public float Unknown438;     // offset: 0x438, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x438) = 0x3F99999A;
        public bool Unknown43C;     // offset: 0x43C, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(v1 + 0x43C) = 1;

        // missing 3 bytes at offset 1084
        // does 1084 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding43D;        // offset: 1085, sz: 3, comment: auto padding 

        public NMSString0x10 Unknown440;     // offset: 0x440, sz: 15, origin:  "DEATHBLOODSMALL"        // line:   strncpy((char *)(v1 + 0x440), "DEATHBLOODSMALL", 0xFui64);

        public NMSString0x10 Unknown450;     // offset: 0x450, sz: 13, origin:  "DEATHBLOODMED"        // line:   strncpy((char *)(v1 + 0x450), "DEATHBLOODMED", 0xDui64);

        public NMSString0x10 Unknown460;     // offset: 0x460, sz: 13, origin:  "DEATHBLOODBIG"        // line:   strncpy((char *)(v1 + 0x460), "DEATHBLOODBIG", 0xDui64);

        public float Unknown470;     // offset: 0x470, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x470) = 0x3E99999A;
        public float Unknown474;     // offset: 0x474, sz: 4, origin: 0x41000000, parsed: 8        // line:   *(_DWORD *)(v1 + 0x474) = 0x41000000;
        public float Unknown478;     // offset: 0x478, sz: 4, origin: 0x41900000, parsed: 18        // line:   *(_DWORD *)(v1 + 0x478) = 0x41900000;
        public float Unknown47C;     // offset: 0x47C, sz: 4, origin: 0x42340000, parsed: 45        // line:   *(_DWORD *)(v1 + 0x47C) = 0x42340000;

        public float Unknown480;     // offset: 0x480, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x480) = 0x41A00000;
        public float Unknown484;     // offset: 0x484, sz: 4, origin: 0x428C0000, parsed: 70        // line:   *(_DWORD *)(v1 + 0x484) = 0x428C0000;
        public float Unknown488;     // offset: 0x488, sz: 4, origin: 0x41A00000, parsed: 20        // line:   *(_DWORD *)(v1 + 0x488) = 0x41A00000;
        public float Unknown48C;     // offset: 0x48C, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x48C) = 0x41200000;

        public float Unknown490;     // offset: 0x490, sz: 4, origin: 0x3F000000i64, parsed: 0.5, comment: two packed floats in a QWORD?(1)
        public float Unknown494;     // offset: 1172, sz: 4, origin: 0x3F000000i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 0x490) = 0x3F000000i64;
        public bool Unknown498;     // offset: 0x498, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 0x498) = 0;
        public int Unknown49C;     // offset: 0x49C, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(v1 + 0x49C) = 4;

        public int Unknown4A0;     // offset: 0x4A0, sz: 4, origin: 4, parsed: 4        // line:   *(_DWORD *)(v1 + 0x4A0) = 4;
        public float Unknown4A4;     // offset: 0x4A4, sz: 4, origin: 0x3E800000, parsed: 0.25        // line:   *(_DWORD *)(v1 + 0x4A4) = 0x3E800000;
        public float Unknown4A8;     // offset: 0x4A8, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x4A8) = 0x3F4CCCCD;
        public float Unknown4AC;     // offset: 0x4AC, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x4AC) = 0x3F4CCCCD;

        public float Unknown4B0;     // offset: 0x4B0, sz: 4, origin: 0x3F733333, parsed: 0.95        // line:   *(_DWORD *)(v1 + 0x4B0) = 0x3F733333;
        public float Unknown4B4;     // offset: 0x4B4, sz: 4, origin: 0x3DCCCCCD, parsed: 0.1        // line:   *(_DWORD *)(v1 + 0x4B4) = 0x3DCCCCCD;
        public float Unknown4B8;     // offset: 0x4B8, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4B8) = 0x3F800000;
        public float Unknown4BC;     // offset: 0x4BC, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 0x4BC) = 0x40000000;

        public float Unknown4C0;     // offset: 0x4C0, sz: 4, origin: 0x40E00000, parsed: 7        // line:   *(_DWORD *)(v1 + 0x4C0) = 0x40E00000;
        public float Unknown4C4;     // offset: 0x4C4, sz: 4, origin: 0x41200000, parsed: 10        // line:   *(_DWORD *)(v1 + 0x4C4) = 0x41200000;
        public float Unknown4C8;     // offset: 0x4C8, sz: 4, origin: 0x3F19999A, parsed: 0.6        // line:   *(_DWORD *)(v1 + 0x4C8) = 0x3F19999A;
        public float Unknown4CC;     // offset: 0x4CC, sz: 4, origin: 0x3E99999A, parsed: 0.3        // line:   *(_DWORD *)(v1 + 0x4CC) = 0x3E99999A;

        public float Unknown4D0;     // offset: 0x4D0, sz: 4, origin: 0x3F000000, parsed: 0.5        // line:   *(_DWORD *)(v1 + 0x4D0) = 0x3F000000;
        public float Unknown4D4;     // offset: 0x4D4, sz: 4, origin: 0x3F4CCCCD, parsed: 0.8        // line:   *(_DWORD *)(v1 + 0x4D4) = 0x3F4CCCCD;
        public bool Unknown4D8;     // offset: 0x4D8, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 0x4D8) = 0;
        public float Unknown4DC;     // offset: 0x4DC, sz: 4, origin: 0x3F333333, parsed: 0.7        // line:   *(_DWORD *)(v1 + 0x4DC) = 0x3F333333;

        public float Unknown4E0;     // offset: 0x4E0, sz: 4, origin: 0x40400000, parsed: 3        // line:   *(_DWORD *)(v1 + 0x4E0) = 0x40400000;
        public float Unknown4E4;     // offset: 0x4E4, sz: 4, origin: 0x3F800000, parsed: 1        // line:   *(_DWORD *)(v1 + 0x4E4) = 0x3F800000;
        public float Unknown4E8;     // offset: 0x4E8, sz: 4, origin: 0x3FA00000, parsed: 1.25        // line:   *(_DWORD *)(v1 + 0x4E8) = 0x3FA00000;
        public bool Unknown4EC;     // offset: 0x4EC, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 0x4EC) = 0;

        public NMSString0x80 Unknown4ED; // offset: 0x4ED, sz: 128, origin:  "metadata/simulation/ecosystem/roledescriptiontables/ground/groundtablecommon.mxml"

        public NMSString0x80 Unknown56D;     // offset: 0x56D, sz: 128, origin:  "metadata/simulation/ecosystem/roledescriptiontables/air/AirTableCommon.mxml"        // line:   strncpy((char *)(v1 + 0x56D), "metadata/simulation/ecosystem/roledescriptiontables/air/AirTableCommon.mxml", 0x80ui64);
                                      // line:   *(_BYTE *)(v1 + 0x5EC) = 0;

        public float Unknown5F0;     // offset: 0x5F0, sz: 4, origin: 0x3F99999A, parsed: 1.2        // line:   *(_DWORD *)(v1 + 0x5F0) = 0x3F99999A;
        public float Unknown5F4;     // offset: 0x5F4, sz: 4, origin: 0x3F8CCCCD, parsed: 1.1        // line:   *(_DWORD *)(v1 + 0x5F4) = 0x3F8CCCCD;

        public NMSString0x10 Unknown5F8;

        public NMSString0x10 Unknown608;

        public NMSString0x10 Unknown618;

        public NMSString0x10 Unknown628;

        public NMSString0x10 Unknown638;

        public NMSString0x10 Unknown648;

        public NMSString0x10 Unknown658;

        public NMSString0x10 Unknown668;

        public NMSString0x10 Unknown678;

        [NMS(Size = 8, Ignore = true)]
        public string Padding688;
    }
}