using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    public class GcSkyGlobals : NMSTemplate
    {
        // generated with MBINRawTemplateParser

        // line: __int64 __fastcall sub_14015CE70(__int64 a1, __int64 a2)
        // line: {
        // line:   __int64 v2; // r8@1
        // line:   __int64 v3; // r8@1
        // line:   __int64 v4; // r8@1
        // line:   __int64 v5; // r8@1
        // line:   __int64 v6; // r8@1
        // line:   __int64 result; // rax@1
        // line:   __int64 v8; // r8@1
        public float Unknown0;     // offset: 0, sz: 4, origin: 1155596288, parsed: 1800        // line:   *(_DWORD *)a1 = 1155596288;
        public bool Unknown4;     // offset: 4, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(a1 + 4) = 1;

        // missing 11 bytes at offset 4
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] Padding5;        // offset: 5, sz: 11, comment: auto padding 

        public float Unknown10;     // offset: 16, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown14;     // offset: 20, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 16) = 1065353216i64;
        public float Unknown18;     // offset: 24, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 24) = 0;

        // missing 4 bytes at offset 24
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding1C;        // offset: 28, sz: 4, comment: auto padding 

        public float Unknown20;     // offset: 32, sz: 4, origin: 1113325568, parsed: 55        // line:   *(_DWORD *)(a1 + 32) = 1113325568;
        public bool Unknown24;     // offset: 36, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(a1 + 36) = 0;

        // missing 3 bytes at offset 36
        // does 36 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding25;        // offset: 37, sz: 3, comment: auto padding 

        public float Unknown28;     // offset: 40, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 40) = 0;
        public float Unknown2C;     // offset: 44, sz: 4, origin: 1144258560, parsed: 720        // line:   *(_DWORD *)(a1 + 44) = 1144258560;
        public float Unknown30;     // offset: 48, sz: 4, origin: 1147207680, parsed: 900        // line:   *(_DWORD *)(a1 + 48) = 1147207680;
        public float Unknown34;     // offset: 52, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 52) = 1123024896;
        public float Unknown38;     // offset: 56, sz: 4, origin: 1137836032, parsed: 420        // line:   *(_DWORD *)(a1 + 56) = 1137836032;
        public float Unknown3C;     // offset: 60, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 60) = 1123024896;
        public float Unknown40;     // offset: 64, sz: 4, origin: 1127481344, parsed: 180        // line:   *(_DWORD *)(a1 + 64) = 1127481344;
        public float Unknown44;     // offset: 68, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(a1 + 68) = 1125515264;
        public float Unknown48;     // offset: 72, sz: 4, origin: 1131413504, parsed: 240        // line:   *(_DWORD *)(a1 + 72) = 1131413504;
        public float Unknown4C;     // offset: 76, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 76) = 1101004800;
        public bool Unknown50;     // offset: 80, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(a1 + 80) = 0;

        // missing 3 bytes at offset 80
        // does 80 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding51;        // offset: 81, sz: 3, comment: auto padding 

        public float Unknown54;     // offset: 84, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 84) = 1065353216;
        public float Unknown58;     // offset: 88, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 88) = 1077936128;
        public float Unknown5C;     // offset: 92, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 92) = 1077936128;
        public float Unknown60;     // offset: 96, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 96) = 1045220557;
        public float Unknown64;     // offset: 100, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 100) = 1045220557;
        public float Unknown68;     // offset: 104, sz: 4, origin: 1017370378, parsed: 0.02        // line:   *(_DWORD *)(a1 + 104) = 1017370378;
        public float Unknown6C;     // offset: 108, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(a1 + 108) = 1050253722;
        public float Unknown70;     // offset: 112, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 112) = 1056964608;
        public bool Unknown74;     // offset: 116, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(a1 + 116) = 1;

        // missing 11 bytes at offset 116
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0xB, Ignore = true)]
        public byte[] Padding75;        // offset: 117, sz: 11, comment: auto padding 

        public float Unknown80;     // offset: 128, sz: 4, origin: 1107397053, parsed: 32.38451        // line:   *(_DWORD *)(a1 + 128) = 1107397053;
        public float Unknown84;     // offset: 132, sz: 4, origin: 1118282843, parsed: 83.82101        // line:   *(_DWORD *)(a1 + 132) = 1118282843;
        public float Unknown88;     // offset: 136, sz: 4, origin: -1037073462, parsed: -43.8787        // line:   *(_DWORD *)(a1 + 136) = -1037073462;

        // missing 4 bytes at offset 136
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding8C;        // offset: 140, sz: 4, comment: auto padding 

        public float Unknown90;     // offset: 144, sz: 4, origin: -1030061708, parsed: -77.25284        // line:   *(_DWORD *)(a1 + 144) = -1030061708;
        public float Unknown94;     // offset: 148, sz: 4, origin: 1115061758, parsed: 61.62304        // line:   *(_DWORD *)(a1 + 148) = 1115061758;
        public float Unknown98;     // offset: 152, sz: 4, origin: -1045512884, parsed: -21.84243        // line:   *(_DWORD *)(a1 + 152) = -1045512884;

        // missing 4 bytes at offset 152
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding9C;        // offset: 156, sz: 4, comment: auto padding 

        public float UnknownA0;     // offset: 160, sz: 4, origin: 1054530268, parsed: 0.427451        // line:   *(_DWORD *)(a1 + 160) = 1054530268;
        public float UnknownA4;     // offset: 164, sz: 4, origin: 1057589643, parsed: 0.537255        // line:   *(_DWORD *)(a1 + 164) = 1057589643;
        public float UnknownA8;     // offset: 168, sz: 4, origin: 1059826600, parsed: 0.670588        // line:   *(_DWORD *)(a1 + 168) = 1059826600;
        public float UnknownAC;     // offset: 172, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 172) = 1065353216;
        public float UnknownB0;     // offset: 176, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 176) = 1065353216;
        public float UnknownB4;     // offset: 180, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 180) = 1065353216;
        public float UnknownB8;     // offset: 184, sz: 4, origin: 1063742603, parsed: 0.904        // line:   *(_DWORD *)(a1 + 184) = 1063742603;
        public float UnknownBC;     // offset: 188, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 188) = 1065353216;
        public float UnknownC0;     // offset: 192, sz: 4, origin: 1039918957, parsed: 0.123        // line:   *(_DWORD *)(a1 + 192) = 1039918957;
        public float UnknownC4;     // offset: 196, sz: 4, origin: 1055353995, parsed: 0.452        // line:   *(_DWORD *)(a1 + 196) = 1055353995;
        public float UnknownC8;     // offset: 200, sz: 4, origin: 1063004406, parsed: 0.86        // line:   *(_DWORD *)(a1 + 200) = 1063004406;
        public float UnknownCC;     // offset: 204, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 204) = 1065353216;
        public float UnknownD0;     // offset: 208, sz: 4, origin: 1064732459, parsed: 0.963        // line:   *(_DWORD *)(a1 + 208) = 1064732459;
        public float UnknownD4;     // offset: 212, sz: 4, origin: 1063960707, parsed: 0.917        // line:   *(_DWORD *)(a1 + 212) = 1063960707;
        public float UnknownD8;     // offset: 216, sz: 4, origin: 1063037960, parsed: 0.862        // line:   *(_DWORD *)(a1 + 216) = 1063037960;
        public float UnknownDC;     // offset: 220, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float UnknownE0;     // offset: 224, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 220) = 1065353216i64;
        public float UnknownE4;     // offset: 228, sz: 4, origin: 1036697731, parsed: 0.099        // line:   *(_DWORD *)(a1 + 228) = 1036697731;
        public float UnknownE8;     // offset: 232, sz: 4, origin: 1058424226, parsed: 0.587        // line:   *(_DWORD *)(a1 + 232) = 1058424226;
        public float UnknownEC;     // offset: 236, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 236) = 1065353216;
        public float UnknownF0;     // offset: 240, sz: 4, origin: 1063960707, parsed: 0.917        // line:   *(_DWORD *)(a1 + 240) = 1063960707;
        public float UnknownF4;     // offset: 244, sz: 4, origin: 1062903742, parsed: 0.854        // line:   *(_DWORD *)(a1 + 244) = 1062903742;
        public float UnknownF8;     // offset: 248, sz: 4, origin: 1062064882, parsed: 0.804        // line:   *(_DWORD *)(a1 + 248) = 1062064882;
        public float UnknownFC;     // offset: 252, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 252) = 1065353216;
        public float Unknown100;     // offset: 256, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 256) = 1065353216;
        public float Unknown104;     // offset: 260, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 260) = 1053609165;
        public float Unknown108;     // offset: 264, sz: 4, origin: 1051931443, parsed: 0.35        // line:   *(_DWORD *)(a1 + 264) = 1051931443;
        public float Unknown10C;     // offset: 268, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 268) = 1059481190;
        public float Unknown110;     // offset: 272, sz: 4, origin: 1048576000, parsed: 0.25        // line:   *(_DWORD *)(a1 + 272) = 1048576000;
        public float Unknown114;     // offset: 276, sz: 4, origin: 1058977874, parsed: 0.62        // line:   *(_DWORD *)(a1 + 276) = 1058977874;
        public float Unknown118;     // offset: 280, sz: 4, origin: 1058977874, parsed: 0.62        // line:   *(_DWORD *)(a1 + 280) = 1058977874;
        public float Unknown11C;     // offset: 284, sz: 4, origin: 1059984507, parsed: 0.68        // line:   *(_DWORD *)(a1 + 284) = 1059984507;
        public float Unknown120;     // offset: 288, sz: 4, origin: 1059984507, parsed: 0.68        // line:   *(_DWORD *)(a1 + 288) = 1059984507;
        public float Unknown124;     // offset: 292, sz: 4, origin: 1060655596, parsed: 0.72        // line:   *(_DWORD *)(a1 + 292) = 1060655596;
        public float Unknown128;     // offset: 296, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 296) = 1059481190;
        public float Unknown12C;     // offset: 300, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 300) = 1060320051;
        public float Unknown130;     // offset: 304, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 304) = 1059481190;
        public float Unknown134;     // offset: 308, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 308) = 1060320051;
        public float Unknown138;     // offset: 312, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 312) = 1059481190;
        public float Unknown13C;     // offset: 316, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 316) = 1060320051;
        public float Unknown140;     // offset: 320, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 320) = 1059481190;
        public float Unknown144;     // offset: 324, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 324) = 1059481190;
        public float Unknown148;     // offset: 328, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(a1 + 328) = 1050253722;
        public float Unknown14C;     // offset: 332, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 332) = 1056964608;
        public float Unknown150;     // offset: 336, sz: 4, origin: 1041865114, parsed: 0.15        // line:   *(_DWORD *)(a1 + 336) = 1041865114;
        public float Unknown154;     // offset: 340, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(a1 + 340) = 1050253722;
        public float Unknown158;     // offset: 344, sz: 4, origin: 1062836634, parsed: 0.85        // line:   *(_DWORD *)(a1 + 344) = 1062836634;
        public float Unknown15C;     // offset: 348, sz: 4, origin: 1063675494i64, parsed: 0.9, comment: two packed floats in a QWORD?(1)
        public float Unknown160;     // offset: 352, sz: 4, origin: 1063675494i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 348) = 1063675494i64;
        public float Unknown164;     // offset: 356, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 356) = 1065353216;
        public float Unknown168;     // offset: 360, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 360) = 1053609165;
        public float Unknown16C;     // offset: 364, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 364) = 1058642330;
        public float Unknown170;     // offset: 368, sz: 4, origin: 1039516303, parsed: 0.12        // line:   *(_DWORD *)(a1 + 368) = 1039516303;
        public float Unknown174;     // offset: 372, sz: 4, origin: 1022739087i64, parsed: 0.03, comment: two packed floats in a QWORD?(1)
        public float Unknown178;     // offset: 376, sz: 4, origin: 1022739087i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 372) = 1022739087i64;
        public long Unknown17C;     // offset: 380, sz: 8, origin: 0i64, parsed: 0. comment: either a long or two floats        // line:   *(_QWORD *)(a1 + 380) = 0i64;
        public float Unknown184;     // offset: 388, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 388) = 0;
        public float Unknown188;     // offset: 392, sz: 4, origin: 1036831949i64, parsed: 0.1, comment: two packed floats in a QWORD?(1)
        public float Unknown18C;     // offset: 396, sz: 4, origin: 1036831949i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 392) = 1036831949i64;
        public float Unknown190;     // offset: 400, sz: 4, origin: -1105618534, parsed: -0.15        // line:   *(_DWORD *)(a1 + 400) = -1105618534;
        public float Unknown194;     // offset: 404, sz: 4, origin: 1025758986, parsed: 0.04        // line:   *(_DWORD *)(a1 + 404) = 1025758986;
        public float Unknown198;     // offset: 408, sz: 4, origin: -1119040307, parsed: -0.05        // line:   *(_DWORD *)(a1 + 408) = -1119040307;
        public float Unknown19C;     // offset: 412, sz: 4, origin: 1022739087, parsed: 0.03        // line:   *(_DWORD *)(a1 + 412) = 1022739087;
        public float Unknown1A0;     // offset: 416, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 416) = 1036831949;
        public float Unknown1A4;     // offset: 420, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 420) = 1053609165;
        public float Unknown1A8;     // offset: 424, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 424) = 1045220557;
        public float Unknown1AC;     // offset: 428, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 428) = 1058642330;
        public float Unknown1B0;     // offset: 432, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 432) = 1058642330;
        public float Unknown1B4;     // offset: 436, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 436) = 1036831949;
        public float Unknown1B8;     // offset: 440, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 440) = 1036831949;
        public float Unknown1BC;     // offset: 444, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 444) = 1059481190;
        public float Unknown1C0;     // offset: 448, sz: 4, origin: 1059481190, parsed: 0.65        // line:   *(_DWORD *)(a1 + 448) = 1059481190;
        public bool Unknown1C4;     // offset: 452, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(a1 + 452) = 0;

        // missing 3 bytes at offset 452
        // does 452 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1C5;        // offset: 453, sz: 3, comment: auto padding 

        public float Unknown1C8;     // offset: 456, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 456) = 0;
        public float Unknown1CC;     // offset: 460, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(a1 + 460) = 1050253722;
        public float Unknown1D0;     // offset: 464, sz: 4, origin: 1064849900, parsed: 0.97        // line:   *(_DWORD *)(a1 + 464) = 1064849900;
        public float Unknown1D4;     // offset: 468, sz: 4, origin: 1094713344, parsed: 12        // line:   *(_DWORD *)(a1 + 468) = 1094713344;
        public float Unknown1D8;     // offset: 472, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 472) = 1065353216;
        public float Unknown1DC;     // offset: 476, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 476) = 1053609165;
        public float Unknown1E0;     // offset: 480, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 480) = 1065353216;
        public float Unknown1E4;     // offset: 484, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 484) = 1065353216;
        public float Unknown1E8;     // offset: 488, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 488) = 1065353216;
        public float Unknown1EC;     // offset: 492, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown1F0;     // offset: 496, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 492) = 1065353216i64;
        public float Unknown1F4;     // offset: 500, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 500) = 1053609165;
        public float Unknown1F8;     // offset: 504, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 504) = 1056964608;
        public float Unknown1FC;     // offset: 508, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 508) = 1065353216;
        public float Unknown200;     // offset: 512, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 512) = 1056964608;
        public float Unknown204;     // offset: 516, sz: 4, origin: 1094713344i64, parsed: 12, comment: two packed floats in a QWORD?(1)
        public float Unknown208;     // offset: 520, sz: 4, origin: 1094713344i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 516) = 1094713344i64;
        public GcFogProperties Template20C;     // offset: 524, sz: 768, origin: sub_14015A680(a1 + 524);, comment: call sub        // line:   sub_14015A680(a1 + 524);
        public GcFogProperties Template2E8;     // offset: 744, sz: 768, origin: sub_14015A680(v2 + 744);, comment: call sub        // line:   sub_14015A680(v2 + 744);
        public GcFogProperties Template3C4;     // offset: 964, sz: 768, origin: sub_14015A680(v3 + 964);, comment: call sub        // line:   sub_14015A680(v3 + 964);
        public GcFogProperties Template4A0;     // offset: 1184, sz: 768, origin: sub_14015A680(v4 + 1184);, comment: call sub        // line:   sub_14015A680(v4 + 1184);
        public GcSpaceSkyProperties Template580;     // offset: 1408, sz: 304, origin: sub_14015B150(v5 + 1408);, comment: call sub        // line:   sub_14015B150(v5 + 1408);
        public GcSpaceSkyProperties Template6B0;     // offset: 1712, sz: 304, origin: result = sub_14015B150(v6 + 1712);, comment: call sub        // line:   result = sub_14015B150(v6 + 1712);
        public float Unknown7E0;     // offset: 2016, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(v8 + 2016) = -1082130432;
        public float Unknown7E4;     // offset: 2020, sz: 4, origin: -1082130432i64, parsed: -1, comment: two packed floats in a QWORD?(1)
        public float Unknown7E8;     // offset: 2024, sz: 4, origin: -1082130432i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v8 + 2020) = -1082130432i64;

        // missing 4 bytes at offset 2020
        // could be a subroutine, padding or something that the parser skipped
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding7EC;        // offset: 2028, sz: 4, comment: auto padding 

        public float Unknown7F0;     // offset: 2032, sz: 4, origin: 1049515524, parsed: 0.278        // line:   *(_DWORD *)(v8 + 2032) = 1049515524;
        public float Unknown7F4;     // offset: 2036, sz: 4, origin: 1057786692, parsed: 0.549        // line:   *(_DWORD *)(v8 + 2036) = 1057786692;
        public float Unknown7F8;     // offset: 2040, sz: 4, origin: 1058877211, parsed: 0.614        // line:   *(_DWORD *)(v8 + 2040) = 1058877211;
        public float Unknown7FC;     // offset: 2044, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2044) = 1065353216;
        public float Unknown800;     // offset: 2048, sz: 4, origin: 1049515524, parsed: 0.278        // line:   *(_DWORD *)(v8 + 2048) = 1049515524;
        public float Unknown804;     // offset: 2052, sz: 4, origin: 1057786692, parsed: 0.549        // line:   *(_DWORD *)(v8 + 2052) = 1057786692;
        public float Unknown808;     // offset: 2056, sz: 4, origin: 1058877211, parsed: 0.614        // line:   *(_DWORD *)(v8 + 2056) = 1058877211;
        public float Unknown80C;     // offset: 2060, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2060) = 1065353216;
        public float Unknown810;     // offset: 2064, sz: 4, origin: 1065286107, parsed: 0.996        // line:   *(_DWORD *)(v8 + 2064) = 1065286107;
        public float Unknown814;     // offset: 2068, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2068) = 1065353216;
        public float Unknown818;     // offset: 2072, sz: 4, origin: 1062501089, parsed: 0.83        // line:   *(_DWORD *)(v8 + 2072) = 1062501089;
        public float Unknown81C;     // offset: 2076, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2076) = 1065353216;
        public float Unknown820;     // offset: 2080, sz: 4, origin: 1032134328, parsed: 0.065        // line:   *(_DWORD *)(v8 + 2080) = 1032134328;
        public float Unknown824;     // offset: 2084, sz: 4, origin: 1064497578, parsed: 0.949        // line:   *(_DWORD *)(v8 + 2084) = 1064497578;
        public float Unknown828;     // offset: 2088, sz: 4, origin: 1042670420, parsed: 0.162        // line:   *(_DWORD *)(v8 + 2088) = 1042670420;
        public float Unknown82C;     // offset: 2092, sz: 4, origin: 1065353216i64, parsed: 1, comment: two packed floats in a QWORD?(1)
        public float Unknown830;     // offset: 2096, sz: 4, origin: 1065353216i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v8 + 2092) = 1065353216i64;
        public float Unknown834;     // offset: 2100, sz: 4, origin: 1058994651, parsed: 0.621        // line:   *(_DWORD *)(v8 + 2100) = 1058994651;
        public float Unknown838;     // offset: 2104, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2104) = 1065353216;
        public float Unknown83C;     // offset: 2108, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2108) = 1065353216;
        public float Unknown840;     // offset: 2112, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2112) = 1065353216;
        public float Unknown844;     // offset: 2116, sz: 4, origin: 1031396131i64, parsed: 0.061, comment: two packed floats in a QWORD?(1)
        public float Unknown848;     // offset: 2120, sz: 4, origin: 1031396131i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v8 + 2116) = 1031396131i64;
        public float Unknown84C;     // offset: 2124, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2124) = 1065353216;
        public float Unknown850;     // offset: 2128, sz: 4, origin: 990057071, parsed: 0.002        // line:   *(_DWORD *)(v8 + 2128) = 990057071;
        public float Unknown854;     // offset: 2132, sz: 4, origin: 1019517862, parsed: 0.024        // line:   *(_DWORD *)(v8 + 2132) = 1019517862;
        public float Unknown858;     // offset: 2136, sz: 4, origin: 1029248647, parsed: 0.053        // line:   *(_DWORD *)(v8 + 2136) = 1029248647;
        public float Unknown85C;     // offset: 2140, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2140) = 1065353216;
        public float Unknown860;     // offset: 2144, sz: 4, origin: 1006834287, parsed: 0.008        // line:   *(_DWORD *)(v8 + 2144) = 1006834287;
        public float Unknown864;     // offset: 2148, sz: 4, origin: 1029248647, parsed: 0.053        // line:   *(_DWORD *)(v8 + 2148) = 1029248647;
        public float Unknown868;     // offset: 2152, sz: 4, origin: 1036831949i64, parsed: 0.1, comment: two packed floats in a QWORD?(1)
        public float Unknown86C;     // offset: 2156, sz: 4, origin: 1036831949i64, parsed: 0, comment: two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v8 + 2152) = 1036831949i64;
        public float Unknown870;     // offset: 2160, sz: 4, origin: 1041999331, parsed: 0.152        // line:   *(_DWORD *)(v8 + 2160) = 1041999331;
        public float Unknown874;     // offset: 2164, sz: 4, origin: 1050924810, parsed: 0.32        // line:   *(_DWORD *)(v8 + 2164) = 1050924810;
        public float Unknown878;     // offset: 2168, sz: 4, origin: 1039650521, parsed: 0.121        // line:   *(_DWORD *)(v8 + 2168) = 1039650521;
        public float Unknown87C;     // offset: 2172, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2172) = 1065353216;
        public float Unknown880;     // offset: 2176, sz: 4, origin: 1053542056, parsed: 0.398        // line:   *(_DWORD *)(v8 + 2176) = 1053542056;
        public float Unknown884;     // offset: 2180, sz: 4, origin: 1056025084, parsed: 0.472        // line:   *(_DWORD *)(v8 + 2180) = 1056025084;
        public float Unknown888;     // offset: 2184, sz: 4, origin: 1058256454, parsed: 0.577        // line:   *(_DWORD *)(v8 + 2184) = 1058256454;
        public float Unknown88C;     // offset: 2188, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v8 + 2188) = 1065353216;
        // line:   return result;
        // line: }
    }
}
