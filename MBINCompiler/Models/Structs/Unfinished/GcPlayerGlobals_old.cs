// generated output for subroutine:
// char *__fastcall sub_140153C50(__int64 a1) -----> hash: 5FCBDD7
// hash of whole input: A92EA4F

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerGlobals_old : NMSTemplate // 0x990
    {
        // generated with MBINRawTemplateParser

        // line: char *__fastcall sub_140153C50(__int64 a1)
        // line: {
        // line:   __int64 v1; // rdi@1
        // line:   char *result; // rax@1
        public float Unknown0;     // offset: 0, sz: 4, origin: 1083179008, parsed: 4.5        // line:   *(_DWORD *)a1 = 1083179008;
        public float Unknown4;     // offset: 4, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 4) = 1065353216;
        public float Unknown8;     // offset: 8, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 8) = 1069547520;
        public float UnknownC;     // offset: 12, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 12) = 1077936128;
        public bool Unknown10;     // offset: 16, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(a1 + 16) = 0;

        // missing 3 bytes at offset 16
        // does 16 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding11;        // offset: 17, sz: 3, comment: auto padding 

        public float Unknown14;     // offset: 20, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(a1 + 20) = 1090519040;
        public float Unknown18;     // offset: 24, sz: 4, origin: 1088421888, parsed: 7        // line:   *(_DWORD *)(a1 + 24) = 1088421888;
        public float Unknown1C;     // offset: 28, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 28) = 1065353216;
        public float Unknown20;     // offset: 32, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 32) = 0x40000000;
        public float Unknown24;     // offset: 36, sz: 4, origin: 1132068864, parsed: 250        // line:   *(_DWORD *)(a1 + 36) = 1132068864;
        public float Unknown28;     // offset: 40, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(a1 + 40) = 1133903872;
        public float Unknown2C;     // offset: 44, sz: 4, origin: 1112014848i64, parsed: 50, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown30;     // offset: 48, sz: 4, origin: 1112014848i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 44) = 1112014848i64;
        public int Unknown34;     // offset: 52, sz: 4, origin: 257, parsed: 257        // line:   *(_DWORD *)(a1 + 52) = 257;
        public bool Unknown38;     // offset: 56, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(a1 + 56) = 0; // moved

        // missing 3 bytes at offset 56
        // does 56 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding39;        // offset: 57, sz: 3, comment: auto padding 

        public int Unknown3C;     // offset: 60, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 60) = 2;
        public int Unknown40;     // offset: 64, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 64) = 2;
        public float Unknown44;     // offset: 68, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 68) = 1120403456;
        public float Unknown48;     // offset: 72, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 72) = 1075838976;
        public float Unknown4C;     // offset: 76, sz: 4, origin: 1117126656, parsed: 75        // line:   *(_DWORD *)(a1 + 76) = 1117126656;
        public float Unknown50;     // offset: 80, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 80) = 1120403456;
        public float Unknown54;     // offset: 84, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 84) = 1101004800;
        public float Unknown58;     // offset: 88, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(a1 + 88) = 1061997773;
        public float Unknown5C;     // offset: 92, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 92) = 1114636288;
        public float Unknown60;     // offset: 96, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 96) = 0x40000000;
        public float Unknown64;     // offset: 100, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 100) = 1120403456;
        public float Unknown68;     // offset: 104, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(a1 + 104) = 1133903872;
        public float Unknown6C;     // offset: 108, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 108) = 1123024896;
        public float Unknown70;     // offset: 112, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 112) = 1084227584;
        public float Unknown74;     // offset: 116, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 116) = 1120403456;
        public float Unknown78;     // offset: 120, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 120) = 1077936128;
        public int Unknown7C;     // offset: 124, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 124) = 2;
        public int Unknown80;     // offset: 128, sz: 4, origin: 2, parsed: 2        // line:   *(_DWORD *)(a1 + 128) = 2;
        public float Unknown84;     // offset: 132, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 132) = 1077936128;
        public float Unknown88;     // offset: 136, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 136) = 1069547520;
        public float Unknown8C;     // offset: 140, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 140) = 0x40000000;
        public float Unknown90;     // offset: 144, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 144) = 0x40000000;
        public float Unknown94;     // offset: 148, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 148) = 1082130432;
        public float Unknown98;     // offset: 152, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 152) = 1077936128;
        public float Unknown9C;     // offset: 156, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 156) = 1084227584;
        public float UnknownA0;     // offset: 160, sz: 4, origin: 1085276160, parsed: 5.5        // line:   *(_DWORD *)(a1 + 160) = 1085276160;
        public float UnknownA4;     // offset: 164, sz: 4, origin: 1167867904, parsed: 5000        // line:   *(_DWORD *)(a1 + 164) = 1167867904;
        public float UnknownA8;     // offset: 168, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 168) = 1077936128;
        public float UnknownAC;     // offset: 172, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 172) = 1082130432;
        public float UnknownB0;     // offset: 176, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(a1 + 176) = 1133903872;
        public float UnknownB4;     // offset: 180, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 180) = 1065353216;
        public float UnknownB8;     // offset: 184, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 184) = 1065353216;
        public float UnknownBC;     // offset: 188, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 188) = 1092616192;
        public float UnknownC0;     // offset: 192, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 192) = 1053609165;
        public float UnknownC4;     // offset: 196, sz: 4, origin: 1061158912, parsed: 0.75        // line:   *(_DWORD *)(a1 + 196) = 1061158912;
        public float UnknownC8;     // offset: 200, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 200) = 1045220557;
        public float UnknownCC;     // offset: 204, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(a1 + 204) = 1028443341;
        public float UnknownD0;     // offset: 208, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(a1 + 208) = 1053609165;
        public float UnknownD4;     // offset: 212, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 212) = 1045220557;
        public float UnknownD8;     // offset: 216, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 216) = 1101004800;
        public float UnknownDC;     // offset: 220, sz: 4, origin: 1140460749, parsed: 500.1        // line:   *(_DWORD *)(a1 + 220) = 1140460749;
        public float UnknownE0;     // offset: 224, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 224) = 1101004800;
        public float UnknownE4;     // offset: 228, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 228) = 1056964608;
        public float UnknownE8;     // offset: 232, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 232) = 1065353216;
        public int UnknownEC;     // offset: 236, sz: 4, origin: 40, parsed: 40        // line:   *(_DWORD *)(a1 + 236) = 40;
        public float UnknownF0;     // offset: 240, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 240) = 1084227584;
        public float UnknownF4;     // offset: 244, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 244) = 1082130432;
        public int UnknownF8;     // offset: 248, sz: 4, origin: 48, parsed: 48        // line:   *(_DWORD *)(a1 + 248) = 48;
        public int UnknownFC;     // offset: 252, sz: 4, origin: 6, parsed: 6        // line:   *(_DWORD *)(a1 + 252) = 6;
        public float Unknown100;     // offset: 256, sz: 4, origin: 1080033280, parsed: 3.5        // line:   *(_DWORD *)(a1 + 256) = 1080033280;
        public float Unknown104;     // offset: 260, sz: 4, origin: 1061158912, parsed: 0.75        // line:   *(_DWORD *)(a1 + 260) = 1061158912;
        public float Unknown108;     // offset: 264, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 264) = 1045220557;
        public int Unknown10C;     // offset: 268, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 268) = 10;
        public float Unknown110;     // offset: 272, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 272) = 1092616192;
        public float Unknown114;     // offset: 276, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 276) = 1067030938;
        public float Unknown118;     // offset: 280, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 280) = 1067030938;
        public float Unknown11C;     // offset: 284, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 284) = 1045220557;
        public float Unknown120;     // offset: 288, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 288) = 1056964608;
        // line: //  *(_BYTE *)(a1 + 56) = 0; // moved

        // missing 12 bytes at offset 288
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding124;        // offset: 292, sz: 12, comment: auto padding 

        public float Unknown130;     // offset: 304, sz: 4, origin: 1064262697, parsed: 0.935        // line:   *(_DWORD *)(a1 + 304) = 1064262697;
        public float Unknown134;     // offset: 308, sz: 4, origin: 1064011039, parsed: 0.92        // line:   *(_DWORD *)(a1 + 308) = 1064011039;
        public float Unknown138;     // offset: 312, sz: 4, origin: 1063977484, parsed: 0.918        // line:   *(_DWORD *)(a1 + 312) = 1063977484;
        public float Unknown13C;     // offset: 316, sz: 4, origin: 1055085560, parsed: 0.444        // line:   *(_DWORD *)(a1 + 316) = 1055085560;
        // line:   v1 = a1;
        public float Unknown140;     // offset: 320, sz: 4, origin: 1148846080, parsed: 1000        // line:   *(_DWORD *)(a1 + 320) = 1148846080;
        public float Unknown144;     // offset: 324, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(a1 + 324) = 1120403456;
        public float Unknown148;     // offset: 328, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(a1 + 328) = 1050253722;
        public float Unknown14C;     // offset: 332, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 332) = 1045220557;
        public float Unknown150;     // offset: 336, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(a1 + 336) = 1128792064;
        public float Unknown154;     // offset: 340, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(a1 + 340) = 1090519040;
        public float Unknown158;     // offset: 344, sz: 4, origin: 1124859904, parsed: 140        // line:   *(_DWORD *)(a1 + 344) = 1124859904;
        public float Unknown15C;     // offset: 348, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 348) = 1036831949;
        public float Unknown160;     // offset: 352, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 352) = 1045220557;
        public float Unknown164;     // offset: 356, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(a1 + 356) = 1125515264;
        public float Unknown168;     // offset: 360, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(a1 + 360) = 1125515264;
        public float Unknown16C;     // offset: 364, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 364) = 1082130432;
        public float Unknown170;     // offset: 368, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(a1 + 368) = 1063675494;
        public float Unknown174;     // offset: 372, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 372) = 1058642330;
        public float Unknown178;     // offset: 376, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 376) = 1065353216;
        public float Unknown17C;     // offset: 380, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(a1 + 380) = 1112014848;
        public float Unknown180;     // offset: 384, sz: 4, origin: 1080033280, parsed: 3.5        // line:   *(_DWORD *)(a1 + 384) = 1080033280;
        public float Unknown184;     // offset: 388, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 388) = 1036831949;
        public float Unknown188;     // offset: 392, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 392) = 1036831949;
        public float Unknown18C;     // offset: 396, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 396) = 1056964608;
        public float Unknown190;     // offset: 400, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 400) = 1067030938;
        public float Unknown194;     // offset: 404, sz: 4, origin: 1017370378, parsed: 0.02        // line:   *(_DWORD *)(a1 + 404) = 1017370378;
        public float Unknown198;     // offset: 408, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 408) = 1058642330;
        public float Unknown19C;     // offset: 412, sz: 4, origin: 1017370378, parsed: 0.02        // line:   *(_DWORD *)(a1 + 412) = 1017370378;
        public float Unknown1A0;     // offset: 416, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 416) = 1067030938;
        public float Unknown1A4;     // offset: 420, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 420) = 1056964608;
        public float Unknown1A8;     // offset: 424, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 424) = 1045220557;
        public float Unknown1AC;     // offset: 428, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 428) = 1045220557;
        public float Unknown1B0;     // offset: 432, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 432) = 1056964608;
        public float Unknown1B4;     // offset: 436, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 436) = 1045220557;
        public float Unknown1B8;     // offset: 440, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 440) = 1056964608;
        public float Unknown1BC;     // offset: 444, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 444) = 1065353216;
        public float Unknown1C0;     // offset: 448, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(a1 + 448) = 1077936128;
        public float Unknown1C4;     // offset: 452, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 452) = 1101004800;
        public float Unknown1C8;     // offset: 456, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 456) = 1084227584;
        public float Unknown1CC;     // offset: 460, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 460) = 1036831949;
        public float Unknown1D0;     // offset: 464, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 464) = 1058642330;
        public float Unknown1D4;     // offset: 468, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 468) = 1036831949;
        public float Unknown1D8;     // offset: 472, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 472) = 1101004800;
        public float Unknown1DC;     // offset: 476, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 476) = 1084227584;
        public float Unknown1E0;     // offset: 480, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(a1 + 480) = 1086324736;
        public float Unknown1E4;     // offset: 484, sz: 4, origin: 1088421888, parsed: 7        // line:   *(_DWORD *)(a1 + 484) = 1088421888;
        public float Unknown1E8;     // offset: 488, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 488) = 1092616192;
        public float Unknown1EC;     // offset: 492, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 492) = 1092616192;
        public float Unknown1F0;     // offset: 496, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(a1 + 496) = -1082130432;
        public float Unknown1F4;     // offset: 500, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 500) = 1106247680;
        public float Unknown1F8;     // offset: 504, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 504) = 1114636288;
        public float Unknown1FC;     // offset: 508, sz: 4, origin: 1119092736, parsed: 90        // line:   *(_DWORD *)(a1 + 508) = 1119092736;
        public float Unknown200;     // offset: 512, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(a1 + 512) = -1082130432;
        public float Unknown204;     // offset: 516, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(a1 + 516) = -1082130432;
        public float Unknown208;     // offset: 520, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 520) = 1101004800;
        public float Unknown20C;     // offset: 524, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(a1 + 524) = 1109393408;
        public float Unknown210;     // offset: 528, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 528) = 1123024896;
        public float Unknown214;     // offset: 532, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(a1 + 532) = -1082130432;
        public float Unknown218;     // offset: 536, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 536) = 0;
        public float Unknown21C;     // offset: 540, sz: 4, origin: 1117782016, parsed: 80        // line:   *(_DWORD *)(a1 + 540) = 1117782016;
        public float Unknown220;     // offset: 544, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 544) = 1092616192;
        public float Unknown224;     // offset: 548, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 548) = 1056964608;
        public float Unknown228;     // offset: 552, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(a1 + 552) = 1109393408;
        public float Unknown22C;     // offset: 556, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(a1 + 556) = 1128792064;
        public float Unknown230;     // offset: 560, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 560) = 1056964608;
        public float Unknown234;     // offset: 564, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 564) = 0x40000000;
        public float Unknown238;     // offset: 568, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 568) = 1069547520;
        public float Unknown23C;     // offset: 572, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 572) = 0x40000000;
        public float Unknown240;     // offset: 576, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(a1 + 576) = 1086324736;
        public float Unknown244;     // offset: 580, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 580) = 1092616192;
        public float Unknown248;     // offset: 584, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(a1 + 584) = 1028443341;
        public float Unknown24C;     // offset: 588, sz: 4, origin: 1050253722, parsed: 0.3        // line:   *(_DWORD *)(a1 + 588) = 1050253722;
        public float Unknown250;     // offset: 592, sz: 4, origin: 1041865114, parsed: 0.15        // line:   *(_DWORD *)(a1 + 592) = 1041865114;
        public float Unknown254;     // offset: 596, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(a1 + 596) = 1058642330;
        public float Unknown258;     // offset: 600, sz: 4, origin: -1102263091, parsed: -0.2        // line:   *(_DWORD *)(a1 + 600) = -1102263091;
        public float Unknown25C;     // offset: 604, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 604) = 1036831949;
        public float Unknown260;     // offset: 608, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 608) = 1045220557;
        public float Unknown264;     // offset: 612, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 612) = 1067030938;
        public float Unknown268;     // offset: 616, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 616) = 1075838976;
        public float Unknown26C;     // offset: 620, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 620) = 1056964608;
        public float Unknown270;     // offset: 624, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(a1 + 624) = 1063675494;
        public float Unknown274;     // offset: 628, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 628) = 1060320051;
        public float Unknown278;     // offset: 632, sz: 4, origin: 1066192077, parsed: 1.1        // line:   *(_DWORD *)(a1 + 632) = 1066192077;
        public float Unknown27C;     // offset: 636, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 636) = 1056964608;
        public float Unknown280;     // offset: 640, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 640) = 0x40000000;
        public float Unknown284;     // offset: 644, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 644) = 1069547520;
        public float Unknown288;     // offset: 648, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 648) = 1082130432;
        public float Unknown28C;     // offset: 652, sz: 4, origin: -1102263091, parsed: -0.2        // line:   *(_DWORD *)(a1 + 652) = -1102263091;
        public float Unknown290;     // offset: 656, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 656) = 1036831949;
        public float Unknown294;     // offset: 660, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 660) = 1045220557;
        public float Unknown298;     // offset: 664, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 664) = 1067030938;
        public float Unknown29C;     // offset: 668, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 668) = 1075838976;
        public float Unknown2A0;     // offset: 672, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 672) = 1056964608;
        public float Unknown2A4;     // offset: 676, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(a1 + 676) = 1063675494;
        public float Unknown2A8;     // offset: 680, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 680) = 1060320051;
        public float Unknown2AC;     // offset: 684, sz: 4, origin: 1066192077, parsed: 1.1        // line:   *(_DWORD *)(a1 + 684) = 1066192077;
        public float Unknown2B0;     // offset: 688, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 688) = 1056964608;
        public float Unknown2B4;     // offset: 692, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 692) = 0x40000000;
        public float Unknown2B8;     // offset: 696, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 696) = 1069547520;
        public float Unknown2BC;     // offset: 700, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 700) = 1082130432;
        public float Unknown2C0;     // offset: 704, sz: 4, origin: -1102263091, parsed: -0.2        // line:   *(_DWORD *)(a1 + 704) = -1102263091;
        public float Unknown2C4;     // offset: 708, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 708) = 1036831949;
        public float Unknown2C8;     // offset: 712, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 712) = 1045220557;
        public float Unknown2CC;     // offset: 716, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 716) = 1067030938;
        public float Unknown2D0;     // offset: 720, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 720) = 1075838976;
        public float Unknown2D4;     // offset: 724, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 724) = 1056964608;
        public float Unknown2D8;     // offset: 728, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(a1 + 728) = 1063675494;
        public float Unknown2DC;     // offset: 732, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 732) = 1060320051;
        public float Unknown2E0;     // offset: 736, sz: 4, origin: 1066192077, parsed: 1.1        // line:   *(_DWORD *)(a1 + 736) = 1066192077;
        public float Unknown2E4;     // offset: 740, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 740) = 1056964608;
        public float Unknown2E8;     // offset: 744, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 744) = 0x40000000;
        public float Unknown2EC;     // offset: 748, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 748) = 1069547520;
        public float Unknown2F0;     // offset: 752, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 752) = 1082130432;
        public float Unknown2F4;     // offset: 756, sz: 4, origin: -1102263091, parsed: -0.2        // line:   *(_DWORD *)(a1 + 756) = -1102263091;
        public float Unknown2F8;     // offset: 760, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 760) = 1036831949;
        public float Unknown2FC;     // offset: 764, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 764) = 1045220557;
        public float Unknown300;     // offset: 768, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(a1 + 768) = 1067030938;
        public float Unknown304;     // offset: 772, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 772) = 1075838976;
        public float Unknown308;     // offset: 776, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 776) = 1056964608;
        public float Unknown30C;     // offset: 780, sz: 4, origin: 1063675494, parsed: 0.9        // line:   *(_DWORD *)(a1 + 780) = 1063675494;
        public float Unknown310;     // offset: 784, sz: 4, origin: 1060320051, parsed: 0.7        // line:   *(_DWORD *)(a1 + 784) = 1060320051;
        public float Unknown314;     // offset: 788, sz: 4, origin: 1066192077, parsed: 1.1        // line:   *(_DWORD *)(a1 + 788) = 1066192077;
        public float Unknown318;     // offset: 792, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 792) = 1056964608;
        public float Unknown31C;     // offset: 796, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 796) = 0x40000000;
        public float Unknown320;     // offset: 800, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 800) = 1069547520;
        public float Unknown324;     // offset: 804, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 804) = 1082130432;
        public float Unknown328;     // offset: 808, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 808) = 1056964608;
        public float Unknown32C;     // offset: 812, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 812) = 1045220557;
        public float Unknown330;     // offset: 816, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 816) = 1065353216;
        public float Unknown334;     // offset: 820, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 820) = 1092616192;
        public float Unknown338;     // offset: 824, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 824) = 1056964608;
        public float Unknown33C;     // offset: 828, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 828) = 0x40000000;
        public float Unknown340;     // offset: 832, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(a1 + 832) = 1133903872;
        public float Unknown344;     // offset: 836, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 836) = 1065353216;
        public float Unknown348;     // offset: 840, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 840) = 1036831949;
        public float Unknown34C;     // offset: 844, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 844) = 1065353216;
        public float Unknown350;     // offset: 848, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 848) = 1065353216;
        public float Unknown354;     // offset: 852, sz: 4, origin: 1064514355, parsed: 0.95        // line:   *(_DWORD *)(a1 + 852) = 1064514355;
        public float Unknown358;     // offset: 856, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(a1 + 856) = 1045220557;
        public float Unknown35C;     // offset: 860, sz: 4, origin: 1000593162, parsed: 0.005        // line:   *(_DWORD *)(a1 + 860) = 1000593162;
        public float Unknown360;     // offset: 864, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(a1 + 864) = 1097859072;
        public float Unknown364;     // offset: 868, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 868) = 1065353216;
        public float Unknown368;     // offset: 872, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(a1 + 872) = 1084227584;
        public float Unknown36C;     // offset: 876, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 876) = 1065353216;
        public bool Unknown370;     // offset: 880, sz: 1, origin: 1, parsed: 1        // line:   *(_BYTE *)(a1 + 880) = 1;

        // missing 3 bytes at offset 880
        // does 880 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding371;        // offset: 881, sz: 3, comment: auto padding 

        public float Unknown374;     // offset: 884, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(a1 + 884) = 1061997773;
        public float Unknown378;     // offset: 888, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(a1 + 888) = 1128792064;
        public float Unknown37C;     // offset: 892, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(a1 + 892) = 1056964608;
        public float Unknown380;     // offset: 896, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 896) = 1092616192;
        public float Unknown384;     // offset: 900, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 900) = 1101004800;
        public float Unknown388;     // offset: 904, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 904) = 0x40000000;
        public float Unknown38C;     // offset: 908, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(a1 + 908) = 1065353216;
        public float Unknown390;     // offset: 912, sz: 4, origin: 1056964608i64, parsed: 0.5, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown394;     // offset: 916, sz: 4, origin: 1056964608i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 912) = 1056964608i64;
        public float Unknown398;     // offset: 920, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(a1 + 920) = 0;
        public float Unknown39C;     // offset: 924, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(a1 + 924) = 1114636288;
        public float Unknown3A0;     // offset: 928, sz: 4, origin: 1161527296, parsed: 3000        // line:   *(_DWORD *)(a1 + 928) = 1161527296;
        public float Unknown3A4;     // offset: 932, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(a1 + 932) = 1128792064;
        public float Unknown3A8;     // offset: 936, sz: 4, origin: 1017370378, parsed: 0.02        // line:   *(_DWORD *)(a1 + 936) = 1017370378;
        public float Unknown3AC;     // offset: 940, sz: 4, origin: 1008981770, parsed: 0.01        // line:   *(_DWORD *)(a1 + 940) = 1008981770;
        public float Unknown3B0;     // offset: 944, sz: 4, origin: 1065017672, parsed: 0.98        // line:   *(_DWORD *)(a1 + 944) = 1065017672;
        public float Unknown3B4;     // offset: 948, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(a1 + 948) = 1069547520;
        public float Unknown3B8;     // offset: 952, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 952) = 1092616192;
        public float Unknown3BC;     // offset: 956, sz: 4, origin: 1080033280, parsed: 3.5        // line:   *(_DWORD *)(a1 + 956) = 1080033280;
        public float Unknown3C0;     // offset: 960, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(a1 + 960) = 1092616192;
        public float Unknown3C4;     // offset: 964, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(a1 + 964) = 1075838976;
        public float Unknown3C8;     // offset: 968, sz: 4, origin: 1045220557i64, parsed: 0.2, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown3CC;     // offset: 972, sz: 4, origin: 1045220557i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(a1 + 968) = 1045220557i64;
        public float Unknown3D0;     // offset: 976, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 976) = 0x40000000;
        public float Unknown3D4;     // offset: 980, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 980) = 1101004800;
        public float Unknown3D8;     // offset: 984, sz: 4, origin: 1189765120, parsed: 30000        // line:   *(_DWORD *)(a1 + 984) = 1189765120;
        public float Unknown3DC;     // offset: 988, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(a1 + 988) = 1082130432;
        public float Unknown3E0;     // offset: 992, sz: 4, origin: 1157234688, parsed: 2000        // line:   *(_DWORD *)(a1 + 992) = 1157234688;
        public float Unknown3E4;     // offset: 996, sz: 4, origin: 1203982336, parsed: 100000        // line:   *(_DWORD *)(a1 + 996) = 1203982336;
        public float Unknown3E8;     // offset: 1000, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(a1 + 1000) = 1128792064;
        public float Unknown3EC;     // offset: 1004, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(a1 + 1004) = 1101004800;
        public float Unknown3F0;     // offset: 1008, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(a1 + 1008) = 1109393408;
        public int Unknown3F4;     // offset: 1012, sz: 4, origin: 10, parsed: 10        // line:   *(_DWORD *)(a1 + 1012) = 10;
        public float Unknown3F8;     // offset: 1016, sz: 4, origin: 1117782016, parsed: 80        // line:   *(_DWORD *)(a1 + 1016) = 1117782016;
        public float Unknown3FC;     // offset: 1020, sz: 4, origin: 1133903872, parsed: 300        // line:   *(_DWORD *)(a1 + 1020) = 1133903872;
        public float Unknown400;     // offset: 1024, sz: 4, origin: 1100480512, parsed: 19        // line:   *(_DWORD *)(a1 + 1024) = 1100480512;
        public float Unknown404;     // offset: 1028, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(a1 + 1028) = 1112014848;
        public float Unknown408;     // offset: 1032, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(a1 + 1032) = 1106247680;
        public float Unknown40C;     // offset: 1036, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(a1 + 1036) = 0x40000000;
        public float Unknown410;     // offset: 1040, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(a1 + 1040) = 1112014848;
        public float Unknown414;     // offset: 1044, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(a1 + 1044) = 1128792064;
        public float Unknown418;     // offset: 1048, sz: 4, origin: 1110704128, parsed: 45        // line:   *(_DWORD *)(a1 + 1048) = 1110704128;
        public float Unknown41C;     // offset: 1052, sz: 4, origin: 1103626240, parsed: 25        // line:   *(_DWORD *)(a1 + 1052) = 1103626240;
        public float Unknown420;     // offset: 1056, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(a1 + 1056) = 1123024896;
        public float Unknown424;     // offset: 1060, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(a1 + 1060) = 1036831949;
        [NMS(Size = 0x80)]
        public string Unknown428;     // offset: 1064, sz: 128, origin:  "MODELS//COMMON//WEAPONS//DEFAULTGUN//DEFAULTGUN.SCENE.MBIN"        // line:   result = strncpy((char *)(a1 + 1064), "MODELS//COMMON//WEAPONS//DEFAULTGUN//DEFAULTGUN.SCENE.MBIN", 0x80ui64);
        // line:   *(_BYTE *)(v1 + 1191) = 0;
        public float Unknown4A8;     // offset: 1192, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1192) = 0;
        public float Unknown4AC;     // offset: 1196, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown4B0;     // offset: 1200, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1196) = 1065353216i64;
        public float Unknown4B4;     // offset: 1204, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1204) = 1120403456;
        public float Unknown4B8;     // offset: 1208, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 1208) = 0x40000000;
        public float Unknown4BC;     // offset: 1212, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1212) = 1056964608;
        public float Unknown4C0;     // offset: 1216, sz: 4, origin: 1098383360, parsed: 15.5        // line:   *(_DWORD *)(v1 + 1216) = 1098383360;
        public float Unknown4C4;     // offset: 1220, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 1220) = 1069547520;
        public float Unknown4C8;     // offset: 1224, sz: 4, origin: 0x40000000i64, parsed: 2, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown4CC;     // offset: 1228, sz: 4, origin: 0x40000000i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1224) = 0x40000000i64;
        public float Unknown4D0;     // offset: 1232, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1232) = 0;
        public float Unknown4D4;     // offset: 1236, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1236) = 1120403456;
        public float Unknown4D8;     // offset: 1240, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1240) = 1125515264;
        public float Unknown4DC;     // offset: 1244, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1244) = 1114636288;
        public float Unknown4E0;     // offset: 1248, sz: 4, origin: 1097859072i64, parsed: 15, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown4E4;     // offset: 1252, sz: 4, origin: 1097859072i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1248) = 1097859072i64;
        public float Unknown4E8;     // offset: 1256, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1256) = 0;
        public float Unknown4EC;     // offset: 1260, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1260) = 1120403456;
        public float Unknown4F0;     // offset: 1264, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1264) = 1125515264;
        public float Unknown4F4;     // offset: 1268, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1268) = 1114636288;
        public float Unknown4F8;     // offset: 1272, sz: 4, origin: 1097859072i64, parsed: 15, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown4FC;     // offset: 1276, sz: 4, origin: 1097859072i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1272) = 1097859072i64;
        public float Unknown500;     // offset: 1280, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1280) = 0;
        public float Unknown504;     // offset: 1284, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1284) = 1120403456;
        public float Unknown508;     // offset: 1288, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1288) = 1125515264;
        public float Unknown50C;     // offset: 1292, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1292) = 1114636288;
        public float Unknown510;     // offset: 1296, sz: 4, origin: 1097859072i64, parsed: 15, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown514;     // offset: 1300, sz: 4, origin: 1097859072i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1296) = 1097859072i64;
        public float Unknown518;     // offset: 1304, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1304) = 0;
        public float Unknown51C;     // offset: 1308, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1308) = 1120403456;
        public float Unknown520;     // offset: 1312, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1312) = 1125515264;
        public float Unknown524;     // offset: 1316, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1316) = 1114636288;
        public float Unknown528;     // offset: 1320, sz: 4, origin: 1097859072i64, parsed: 15, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown52C;     // offset: 1324, sz: 4, origin: 1097859072i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1320) = 1097859072i64;
        public float Unknown530;     // offset: 1328, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1328) = 0;
        public float Unknown534;     // offset: 1332, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1332) = 1120403456;
        public float Unknown538;     // offset: 1336, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1336) = 1125515264;
        public float Unknown53C;     // offset: 1340, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1340) = 1114636288;
        public float Unknown540;     // offset: 1344, sz: 4, origin: 1097859072i64, parsed: 15, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown544;     // offset: 1348, sz: 4, origin: 1097859072i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1344) = 1097859072i64;
        public float Unknown548;     // offset: 1352, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1352) = 0;
        public float Unknown54C;     // offset: 1356, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1356) = 1120403456;
        public float Unknown550;     // offset: 1360, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1360) = 1125515264;
        public float Unknown554;     // offset: 1364, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1364) = 1114636288;
        public float Unknown558;     // offset: 1368, sz: 4, origin: 1097859072i64, parsed: 15, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown55C;     // offset: 1372, sz: 4, origin: 1097859072i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1368) = 1097859072i64;
        public float Unknown560;     // offset: 1376, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1376) = 0;
        public float Unknown564;     // offset: 1380, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1380) = 1120403456;
        public float Unknown568;     // offset: 1384, sz: 4, origin: 1125515264, parsed: 150        // line:   *(_DWORD *)(v1 + 1384) = 1125515264;
        public float Unknown56C;     // offset: 1388, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 1388) = 1114636288;
        public float Unknown570;     // offset: 1392, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 1392) = 1097859072;
        public float Unknown574;     // offset: 1396, sz: 4, origin: 1067869798, parsed: 1.3        // line:   *(_DWORD *)(v1 + 1396) = 1067869798;
        public float Unknown578;     // offset: 1400, sz: 4, origin: 1025758986, parsed: 0.04        // line:   *(_DWORD *)(v1 + 1400) = 1025758986;
        public float Unknown57C;     // offset: 1404, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1404) = 1053609165;
        public float Unknown580;     // offset: 1408, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1408) = 1036831949;
        public float Unknown584;     // offset: 1412, sz: 4, origin: 1041865114, parsed: 0.15        // line:   *(_DWORD *)(v1 + 1412) = 1041865114;
        public float Unknown588;     // offset: 1416, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1416) = 1065353216;
        public float Unknown58C;     // offset: 1420, sz: 4, origin: 1090519040i64, parsed: 8, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown590;     // offset: 1424, sz: 4, origin: 1090519040i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1420) = 1090519040i64;
        public float Unknown594;     // offset: 1428, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown598;     // offset: 1432, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1428) = 1065353216i64;
        public float Unknown59C;     // offset: 1436, sz: 4, origin: 1145569280, parsed: 800        // line:   *(_DWORD *)(v1 + 1436) = 1145569280;
        public float Unknown5A0;     // offset: 1440, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 1440) = 1128792064;
        public float Unknown5A4;     // offset: 1444, sz: 4, origin: 1157234688, parsed: 2000        // line:   *(_DWORD *)(v1 + 1444) = 1157234688;
        public float Unknown5A8;     // offset: 1448, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1448) = 1036831949;
        public float Unknown5AC;     // offset: 1452, sz: 4, origin: 1041865114, parsed: 0.15        // line:   *(_DWORD *)(v1 + 1452) = 1041865114;
        public float Unknown5B0;     // offset: 1456, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1456) = 1065353216;
        public float Unknown5B4;     // offset: 1460, sz: 4, origin: 1090519040i64, parsed: 8, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown5B8;     // offset: 1464, sz: 4, origin: 1090519040i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1460) = 1090519040i64;
        public float Unknown5BC;     // offset: 1468, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown5C0;     // offset: 1472, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1468) = 1065353216i64;
        public float Unknown5C4;     // offset: 1476, sz: 4, origin: 1145569280, parsed: 800        // line:   *(_DWORD *)(v1 + 1476) = 1145569280;
        public float Unknown5C8;     // offset: 1480, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 1480) = 1128792064;
        public float Unknown5CC;     // offset: 1484, sz: 4, origin: 1157234688, parsed: 2000        // line:   *(_DWORD *)(v1 + 1484) = 1157234688;
        public float Unknown5D0;     // offset: 1488, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1488) = 1036831949;
        public float Unknown5D4;     // offset: 1492, sz: 4, origin: 1041865114, parsed: 0.15        // line:   *(_DWORD *)(v1 + 1492) = 1041865114;
        public float Unknown5D8;     // offset: 1496, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1496) = 1065353216;
        public float Unknown5DC;     // offset: 1500, sz: 4, origin: 1090519040i64, parsed: 8, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown5E0;     // offset: 1504, sz: 4, origin: 1090519040i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1500) = 1090519040i64;
        public float Unknown5E4;     // offset: 1508, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown5E8;     // offset: 1512, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1508) = 1065353216i64;
        public float Unknown5EC;     // offset: 1516, sz: 4, origin: 1145569280, parsed: 800        // line:   *(_DWORD *)(v1 + 1516) = 1145569280;
        public float Unknown5F0;     // offset: 1520, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 1520) = 1128792064;
        public float Unknown5F4;     // offset: 1524, sz: 4, origin: 1157234688, parsed: 2000        // line:   *(_DWORD *)(v1 + 1524) = 1157234688;
        public float Unknown5F8;     // offset: 1528, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 1528) = 1101004800;
        public float Unknown5FC;     // offset: 1532, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1532) = 1061997773;
        public float Unknown600;     // offset: 1536, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 1536) = 1058642330;
        public float Unknown604;     // offset: 1540, sz: 4, origin: -1130113270, parsed: -0.02        // line:   *(_DWORD *)(v1 + 1540) = -1130113270;
        public float Unknown608;     // offset: 1544, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1544) = 0;
        public float Unknown60C;     // offset: 1548, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1548) = 1036831949;
        public float Unknown610;     // offset: 1552, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1552) = 1036831949;
        public float Unknown614;     // offset: 1556, sz: 4, origin: 1034147594, parsed: 0.08        // line:   *(_DWORD *)(v1 + 1556) = 1034147594;
        public float Unknown618;     // offset: 1560, sz: 4, origin: 1036831949i64, parsed: 0.1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown61C;     // offset: 1564, sz: 4, origin: 1036831949i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1560) = 1036831949i64;
        public float Unknown620;     // offset: 1568, sz: 4, origin: -1082130432, parsed: -1        // line:   *(_DWORD *)(v1 + 1568) = -1082130432;
        public float Unknown624;     // offset: 1572, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 1572) = 1058642330;
        public float Unknown628;     // offset: 1576, sz: 4, origin: 1025758986, parsed: 0.04        // line:   *(_DWORD *)(v1 + 1576) = 1025758986;
        public float Unknown62C;     // offset: 1580, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1580) = 1056964608;
        public float Unknown630;     // offset: 1584, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 1584) = 1092616192;
        public float Unknown634;     // offset: 1588, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1588) = 1036831949;
        public float Unknown638;     // offset: 1592, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 1592) = 1082130432;
        public float Unknown63C;     // offset: 1596, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1596) = 1077936128;
        public float Unknown640;     // offset: 1600, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1600) = 1084227584;
        public float Unknown644;     // offset: 1604, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 1604) = 1067030938;
        public float Unknown648;     // offset: 1608, sz: 4, origin: 1061158912, parsed: 0.75        // line:   *(_DWORD *)(v1 + 1608) = 1061158912;

        // missing 4 bytes at offset 1608
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding64C;        // offset: 1612, sz: 4, comment: auto padding 

        public long Unknown650;     // offset: 1616, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 1616) = 0i64;
        public float Unknown658;     // offset: 1624, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 1624) = 0;

        // missing 4 bytes at offset 1624
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding65C;        // offset: 1628, sz: 4, comment: auto padding 

        public float Unknown660;     // offset: 1632, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 1632) = 1077936128;
        public float Unknown664;     // offset: 1636, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 1636) = 1086324736;
        public float Unknown668;     // offset: 1640, sz: 4, origin: 1058642330, parsed: 0.6        // line:   *(_DWORD *)(v1 + 1640) = 1058642330;
        public float Unknown66C;     // offset: 1644, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1644) = 1065353216;
        public float Unknown670;     // offset: 1648, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1648) = 1045220557;
        public float Unknown674;     // offset: 1652, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1652) = 1045220557;
        public float Unknown678;     // offset: 1656, sz: 4, origin: 1056964608i64, parsed: 0.5, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown67C;     // offset: 1660, sz: 4, origin: 1056964608i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1656) = 1056964608i64;
        public float Unknown680;     // offset: 1664, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1664) = 1056964608;
        public float Unknown684;     // offset: 1668, sz: 4, origin: 1039516303, parsed: 0.12        // line:   *(_DWORD *)(v1 + 1668) = 1039516303;
        public float Unknown688;     // offset: 1672, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1672) = 1053609165;
        public float Unknown68C;     // offset: 1676, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1676) = 1061997773;
        public int Unknown690;     // offset: 1680, sz: 4, origin: 64, parsed: 64        // line:   *(_DWORD *)(v1 + 1680) = 64;
        public float Unknown694;     // offset: 1684, sz: 4, origin: 1149239296, parsed: 1024        // line:   *(_DWORD *)(v1 + 1684) = 1149239296;
        public float Unknown698;     // offset: 1688, sz: 4, origin: 1140850688, parsed: 512        // line:   *(_DWORD *)(v1 + 1688) = 1140850688;
        public float Unknown69C;     // offset: 1692, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1692) = 1045220557;
        public float Unknown6A0;     // offset: 1696, sz: 4, origin: 1083808154, parsed: 4.8        // line:   *(_DWORD *)(v1 + 1696) = 1083808154;
        public float Unknown6A4;     // offset: 1700, sz: 4, origin: 1103626240, parsed: 25        // line:   *(_DWORD *)(v1 + 1700) = 1103626240;
        public float Unknown6A8;     // offset: 1704, sz: 4, origin: 1077936128i64, parsed: 3, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown6AC;     // offset: 1708, sz: 4, origin: 1077936128i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1704) = 1077936128i64;
        public float Unknown6B0;     // offset: 1712, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 1712) = 1097859072;
        public float Unknown6B4;     // offset: 1716, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 1716) = 1092616192;
        public float Unknown6B8;     // offset: 1720, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1720) = 1056964608;
        public float Unknown6BC;     // offset: 1724, sz: 4, origin: 1008981770, parsed: 0.01        // line:   *(_DWORD *)(v1 + 1724) = 1008981770;
        public float Unknown6C0;     // offset: 1728, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1728) = 1036831949;
        public float Unknown6C4;     // offset: 1732, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 1732) = 1069547520;
        public float Unknown6C8;     // offset: 1736, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1736) = 1036831949;
        public float Unknown6CC;     // offset: 1740, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1740) = 1036831949;
        public float Unknown6D0;     // offset: 1744, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1744) = 1065353216;
        public float Unknown6D4;     // offset: 1748, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 1748) = 1092616192;
        public float Unknown6D8;     // offset: 1752, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 1752) = 1097859072;
        public float Unknown6DC;     // offset: 1756, sz: 4, origin: 1039516303, parsed: 0.12        // line:   *(_DWORD *)(v1 + 1756) = 1039516303;
        public float Unknown6E0;     // offset: 1760, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1760) = 1084227584;
        public float Unknown6E4;     // offset: 1764, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1764) = 1053609165;
        public float Unknown6E8;     // offset: 1768, sz: 4, origin: 1128792064, parsed: 200        // line:   *(_DWORD *)(v1 + 1768) = 1128792064;
        public float Unknown6EC;     // offset: 1772, sz: 4, origin: 1117126656, parsed: 75        // line:   *(_DWORD *)(v1 + 1772) = 1117126656;
        public float Unknown6F0;     // offset: 1776, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 1776) = 1065353216;
        public float Unknown6F4;     // offset: 1780, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 1780) = 1097859072;
        public float Unknown6F8;     // offset: 1784, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 1784) = 1097859072;
        public float Unknown6FC;     // offset: 1788, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1788) = 1056964608;
        public float Unknown700;     // offset: 1792, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1792) = 1084227584;
        public float Unknown704;     // offset: 1796, sz: 4, origin: 1099956224, parsed: 18        // line:   *(_DWORD *)(v1 + 1796) = 1099956224;
        public float Unknown708;     // offset: 1800, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 1800) = 1090519040;
        public float Unknown70C;     // offset: 1804, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1804) = 1061997773;
        public float Unknown710;     // offset: 1808, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 1808) = 1120403456;
        public float Unknown714;     // offset: 1812, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1812) = 1061997773;
        public float Unknown718;     // offset: 1816, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1816) = 1053609165;
        public int Unknown71C;     // offset: 1820, sz: 4, origin: 500, parsed: 500        // line:   *(_DWORD *)(v1 + 1820) = 500;
        public int Unknown720;     // offset: 1824, sz: 4, origin: 360, parsed: 360        // line:   *(_DWORD *)(v1 + 1824) = 360;
        public float Unknown724;     // offset: 1828, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 1828) = 1101004800;
        public float Unknown728;     // offset: 1832, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 1832) = 1082130432;
        public float Unknown72C;     // offset: 1836, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 1836) = 1112014848;
        public float Unknown730;     // offset: 1840, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1840) = 1036831949;
        public float Unknown734;     // offset: 1844, sz: 4, origin: -1093874483, parsed: -0.4        // line:   *(_DWORD *)(v1 + 1844) = -1093874483;
        public float Unknown738;     // offset: 1848, sz: 4, origin: -1079613850, parsed: -1.3        // line:   *(_DWORD *)(v1 + 1848) = -1079613850;
        public float Unknown73C;     // offset: 1852, sz: 4, origin: 0x40000000i64, parsed: 2, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown740;     // offset: 1856, sz: 4, origin: 0x40000000i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 1852) = 0x40000000i64;
        public float Unknown744;     // offset: 1860, sz: 4, origin: -1090519040, parsed: -0.5        // line:   *(_DWORD *)(v1 + 1860) = -1090519040;
        public float Unknown748;     // offset: 1864, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 1864) = 1082130432;
        public float Unknown74C;     // offset: 1868, sz: 4, origin: 1140457472, parsed: 500        // line:   *(_DWORD *)(v1 + 1868) = 1140457472;
        public float Unknown750;     // offset: 1872, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1872) = 1084227584;
        public float Unknown754;     // offset: 1876, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1876) = 1056964608;
        public float Unknown758;     // offset: 1880, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 1880) = 0x40000000;
        public float Unknown75C;     // offset: 1884, sz: 4, origin: 1082969293, parsed: 4.4        // line:   *(_DWORD *)(v1 + 1884) = 1082969293;
        public float Unknown760;     // offset: 1888, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 1888) = 1090519040;
        public float Unknown764;     // offset: 1892, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1892) = 1056964608;
        public float Unknown768;     // offset: 1896, sz: 4, origin: 1061997773, parsed: 0.8        // line:   *(_DWORD *)(v1 + 1896) = 1061997773;
        public float Unknown76C;     // offset: 1900, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 1900) = 1086324736;
        public float Unknown770;     // offset: 1904, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1904) = 1084227584;
        public float Unknown774;     // offset: 1908, sz: 4, origin: 1069547520, parsed: 1.5        // line:   *(_DWORD *)(v1 + 1908) = 1069547520;
        public float Unknown778;     // offset: 1912, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 1912) = 1082130432;
        public float Unknown77C;     // offset: 1916, sz: 4, origin: 1083179008, parsed: 4.5        // line:   *(_DWORD *)(v1 + 1916) = 1083179008;
        public float Unknown780;     // offset: 1920, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v1 + 1920) = 1028443341;
        public float Unknown784;     // offset: 1924, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 1924) = 1036831949;
        public float Unknown788;     // offset: 1928, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 1928) = 1112014848;
        public float Unknown78C;     // offset: 1932, sz: 4, origin: 1075838976, parsed: 2.5        // line:   *(_DWORD *)(v1 + 1932) = 1075838976;
        public float Unknown790;     // offset: 1936, sz: 4, origin: 1118961664, parsed: 89        // line:   *(_DWORD *)(v1 + 1936) = 1118961664;
        public float Unknown794;     // offset: 1940, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1940) = 1053609165;
        public float Unknown798;     // offset: 1944, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 1944) = 1045220557;
        public float Unknown79C;     // offset: 1948, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 1948) = 1106247680;
        public float Unknown7A0;     // offset: 1952, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 1952) = 1109393408;
        public float Unknown7A4;     // offset: 1956, sz: 4, origin: 1123024896, parsed: 120        // line:   *(_DWORD *)(v1 + 1956) = 1123024896;
        public float Unknown7A8;     // offset: 1960, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 1960) = 1109393408;
        public float Unknown7AC;     // offset: 1964, sz: 4, origin: 1108082688, parsed: 35        // line:   *(_DWORD *)(v1 + 1964) = 1108082688;
        public float Unknown7B0;     // offset: 1968, sz: 4, origin: 1108082688, parsed: 35        // line:   *(_DWORD *)(v1 + 1968) = 1108082688;
        public float Unknown7B4;     // offset: 1972, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 1972) = 1053609165;
        public float Unknown7B8;     // offset: 1976, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v1 + 1976) = 1028443341;
        public float Unknown7BC;     // offset: 1980, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 1980) = 1097859072;
        public float Unknown7C0;     // offset: 1984, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 1984) = 1056964608;
        public float Unknown7C4;     // offset: 1988, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 1988) = 1084227584;
        public float Unknown7C8;     // offset: 1992, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 1992) = 1106247680;
        public float Unknown7CC;     // offset: 1996, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 1996) = 1106247680;
        public float Unknown7D0;     // offset: 2000, sz: 4, origin: 1114636288, parsed: 60        // line:   *(_DWORD *)(v1 + 2000) = 1114636288;
        public float Unknown7D4;     // offset: 2004, sz: 4, origin: 1053609165, parsed: 0.4        // line:   *(_DWORD *)(v1 + 2004) = 1053609165;
        public float Unknown7D8;     // offset: 2008, sz: 4, origin: 1082130432, parsed: 4        // line:   *(_DWORD *)(v1 + 2008) = 1082130432;
        public float Unknown7DC;     // offset: 2012, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 2012) = 1086324736;
        public float Unknown7E0;     // offset: 2016, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 2016) = 1090519040;
        public float Unknown7E4;     // offset: 2020, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 2020) = 1056964608;
        public float Unknown7E8;     // offset: 2024, sz: 4, origin: 1036831949, parsed: 0.1        // line:   *(_DWORD *)(v1 + 2024) = 1036831949;
        public float Unknown7EC;     // offset: 2028, sz: 4, origin: 1017370378, parsed: 0.02        // line:   *(_DWORD *)(v1 + 2028) = 1017370378;
        public float Unknown7F0;     // offset: 2032, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v1 + 2032) = 1028443341;
        public float Unknown7F4;     // offset: 2036, sz: 4, origin: 1017370378, parsed: 0.02        // line:   *(_DWORD *)(v1 + 2036) = 1017370378;
        public float Unknown7F8;     // offset: 2040, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 2040) = 1045220557;
        public float Unknown7FC;     // offset: 2044, sz: 4, origin: 1035489772, parsed: 0.09        // line:   *(_DWORD *)(v1 + 2044) = 1035489772;
        public float Unknown800;     // offset: 2048, sz: 4, origin: 1120403456, parsed: 100        // line:   *(_DWORD *)(v1 + 2048) = 1120403456;
        public float Unknown804;     // offset: 2052, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 2052) = 1045220557;
        public float Unknown808;     // offset: 2056, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2056) = 1092616192;
        public float Unknown80C;     // offset: 2060, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2060) = 1065353216;
        public float Unknown810;     // offset: 2064, sz: 4, origin: 1028443341, parsed: 0.05        // line:   *(_DWORD *)(v1 + 2064) = 1028443341;
        public float Unknown814;     // offset: 2068, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2068) = 0x40000000;
        public float Unknown818;     // offset: 2072, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 2072) = 1077936128;
        public float Unknown81C;     // offset: 2076, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 2076) = 1106247680;
        public float Unknown820;     // offset: 2080, sz: 4, origin: 1090519040, parsed: 8        // line:   *(_DWORD *)(v1 + 2080) = 1090519040;
        public float Unknown824;     // offset: 2084, sz: 4, origin: 1077936128, parsed: 3        // line:   *(_DWORD *)(v1 + 2084) = 1077936128;
        public float Unknown828;     // offset: 2088, sz: 4, origin: 1064514355, parsed: 0.95        // line:   *(_DWORD *)(v1 + 2088) = 1064514355;
        public float Unknown82C;     // offset: 2092, sz: 4, origin: 1045220557, parsed: 0.2        // line:   *(_DWORD *)(v1 + 2092) = 1045220557;
        public float Unknown830;     // offset: 2096, sz: 4, origin: 1000593162, parsed: 0.005        // line:   *(_DWORD *)(v1 + 2096) = 1000593162;
        public float Unknown834;     // offset: 2100, sz: 4, origin: 1097859072, parsed: 15        // line:   *(_DWORD *)(v1 + 2100) = 1097859072;
        public float Unknown838;     // offset: 2104, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2104) = 1065353216;
        public float Unknown83C;     // offset: 2108, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 2108) = 1084227584;
        public float Unknown840;     // offset: 2112, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2112) = 1065353216;
        public int Unknown844;     // offset: 2116, sz: 4, origin: 5, parsed: 5        // line:   *(_DWORD *)(v1 + 2116) = 5;
        public float Unknown848;     // offset: 2120, sz: 4, origin: 1056964608, parsed: 0.5        // line:   *(_DWORD *)(v1 + 2120) = 1056964608;
        public float Unknown84C;     // offset: 2124, sz: 4, origin: 1084227584, parsed: 5        // line:   *(_DWORD *)(v1 + 2124) = 1084227584;
        public float Unknown850;     // offset: 2128, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2128) = 0x40000000;
        public float Unknown854;     // offset: 2132, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2132) = 1101004800;
        public bool Unknown858;     // offset: 2136, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 2136) = 0;

        // missing 3 bytes at offset 2136
        // does 2136 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding859;        // offset: 2137, sz: 3, comment: auto padding 

        public float Unknown85C;     // offset: 2140, sz: 4, origin: 1072064102, parsed: 1.8        // line:   *(_DWORD *)(v1 + 2140) = 1072064102;
        public float Unknown860;     // offset: 2144, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 2144) = 1086324736;
        public float Unknown864;     // offset: 2148, sz: 4, origin: 1101004800, parsed: 20        // line:   *(_DWORD *)(v1 + 2148) = 1101004800;
        public bool Unknown868;     // offset: 2152, sz: 1, origin: 0, parsed: 0        // line:   *(_BYTE *)(v1 + 2152) = 0;

        // missing 3 bytes at offset 2152
        // does 2152 contain a DWORD?
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding869;        // offset: 2153, sz: 3, comment: auto padding 

        public float Unknown86C;     // offset: 2156, sz: 4, origin: 1072064102, parsed: 1.8        // line:   *(_DWORD *)(v1 + 2156) = 1072064102;
        public float Unknown870;     // offset: 2160, sz: 4, origin: 1086324736, parsed: 6        // line:   *(_DWORD *)(v1 + 2160) = 1086324736;
        public float Unknown874;     // offset: 2164, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 2164) = 1106247680;
        public float Unknown878;     // offset: 2168, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 2168) = 1109393408;
        public float Unknown87C;     // offset: 2172, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2172) = 1065353216;
        public float Unknown880;     // offset: 2176, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2176) = 0x40000000;
        public float Unknown884;     // offset: 2180, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 2180) = 1067030938;
        public float Unknown888;     // offset: 2184, sz: 4, origin: 1135542272, parsed: 350        // line:   *(_DWORD *)(v1 + 2184) = 1135542272;
        public float Unknown88C;     // offset: 2188, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2188) = 1065353216;
        public float Unknown890;     // offset: 2192, sz: 4, origin: 1106247680, parsed: 30        // line:   *(_DWORD *)(v1 + 2192) = 1106247680;
        public float Unknown894;     // offset: 2196, sz: 4, origin: 1109393408, parsed: 40        // line:   *(_DWORD *)(v1 + 2196) = 1109393408;
        public float Unknown898;     // offset: 2200, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2200) = 1065353216;
        public float Unknown89C;     // offset: 2204, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2204) = 0x40000000;
        public float Unknown8A0;     // offset: 2208, sz: 4, origin: 1067030938, parsed: 1.2        // line:   *(_DWORD *)(v1 + 2208) = 1067030938;
        public float Unknown8A4;     // offset: 2212, sz: 4, origin: 1135542272, parsed: 350        // line:   *(_DWORD *)(v1 + 2212) = 1135542272;
        public float Unknown8A8;     // offset: 2216, sz: 4, origin: 1065353216, parsed: 1        // line:   *(_DWORD *)(v1 + 2216) = 1065353216;
        public float Unknown8AC;     // offset: 2220, sz: 4, origin: 1092616192, parsed: 10        // line:   *(_DWORD *)(v1 + 2220) = 1092616192;
        public float Unknown8B0;     // offset: 2224, sz: 4, origin: 1112014848, parsed: 50        // line:   *(_DWORD *)(v1 + 2224) = 1112014848;
        public float Unknown8B4;     // offset: 2228, sz: 4, origin: 1103626240, parsed: 25        // line:   *(_DWORD *)(v1 + 2228) = 1103626240;
        public float Unknown8B8;     // offset: 2232, sz: 4, origin: 0x40000000, parsed: 2        // line:   *(_DWORD *)(v1 + 2232) = 0x40000000;
        public float Unknown8BC;     // offset: 2236, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown8C0;     // offset: 2240, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2236) = 1065353216i64;
        public float Unknown8C4;     // offset: 2244, sz: 4, origin: 1259902591, parsed: 9999999        // line:   *(_DWORD *)(v1 + 2244) = 1259902591;
        public float Unknown8C8;     // offset: 2248, sz: 4, origin: 1091567616, parsed: 9        // line:   *(_DWORD *)(v1 + 2248) = 1091567616;

        // missing 4 bytes at offset 2248
        // could be padding, a undefined subroutine or a pointer accessing larger memory
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding8CC;        // offset: 2252, sz: 4, comment: auto padding 

        public long Unknown8D0;     // offset: 2256, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 2256) = 0i64;
        public float Unknown8D8;     // offset: 2264, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown8DC;     // offset: 2268, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2264) = 1065353216i64;
        public float Unknown8E0;     // offset: 2272, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2272) = 0;
        public float Unknown8E4;     // offset: 2276, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown8E8;     // offset: 2280, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2276) = 1065353216i64; // moved  
        public float Unknown8EC;     // offset: 2284, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2284) = 0;  
        public float Unknown8F0;     // offset: 2288, sz: 4, origin: 1148846080i64, parsed: 1000, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown8F4;     // offset: 2292, sz: 4, origin: 1148846080i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2288) = 1148846080i64;
        public float Unknown8F8;     // offset: 2296, sz: 4, origin: 1148846080i64, parsed: 1000, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown8FC;     // offset: 2300, sz: 4, origin: 1148846080i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2296) = 1148846080i64;
        public long Unknown900;     // offset: 2304, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 2304) = 0i64;
        public float Unknown908;     // offset: 2312, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown90C;     // offset: 2316, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2312) = 1065353216i64;
        public long Unknown910;     // offset: 2320, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 2320) = 0i64;
        public float Unknown918;     // offset: 2328, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown91C;     // offset: 2332, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2328) = 1065353216i64;
        public float Unknown920;     // offset: 2336, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2336) = 0;
        public float Unknown924;     // offset: 2340, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown928;     // offset: 2344, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2340) = 1065353216i64; // moved  
        public float Unknown92C;     // offset: 2348, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2348) = 0;  
        public float Unknown930;     // offset: 2352, sz: 4, origin: 1148846080i64, parsed: 1000, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown934;     // offset: 2356, sz: 4, origin: 1148846080i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2352) = 1148846080i64;
        public float Unknown938;     // offset: 2360, sz: 4, origin: 1148846080i64, parsed: 1000, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown93C;     // offset: 2364, sz: 4, origin: 1148846080i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2360) = 1148846080i64;
        public long Unknown940;     // offset: 2368, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 2368) = 0i64;
        public float Unknown948;     // offset: 2376, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown94C;     // offset: 2380, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2376) = 1065353216i64;
        public long Unknown950;     // offset: 2384, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 2384) = 0i64;
        public float Unknown958;     // offset: 2392, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown95C;     // offset: 2396, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2392) = 1065353216i64;
        public float Unknown960;     // offset: 2400, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2400) = 0;  
        public float Unknown964;     // offset: 2404, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown968;     // offset: 2408, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2404) = 1065353216i64;
        public float Unknown96C;     // offset: 2412, sz: 4, origin: 0, parsed: 0        // line:   *(_DWORD *)(v1 + 2412) = 0; // moved  
        public float Unknown970;     // offset: 2416, sz: 4, origin: 1148846080i64, parsed: 1000, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown974;     // offset: 2420, sz: 4, origin: 1148846080i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2416) = 1148846080i64;
        public float Unknown978;     // offset: 2424, sz: 4, origin: 1148846080i64, parsed: 1000, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown97C;     // offset: 2428, sz: 4, origin: 1148846080i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2424) = 1148846080i64;
        public long Unknown980;     // offset: 2432, sz: 8, origin: 0i64, parsed: 0. comment: aligned to 8 bytes! a long. two floats or two ints?        // line:   *(_QWORD *)(v1 + 2432) = 0i64;
        public float Unknown988;     // offset: 2440, sz: 4, origin: 1065353216i64, parsed: 1, comment: unaligned to 8 bytes! two packed floats in a QWORD?(1)
        public float Unknown98C;     // offset: 2444, sz: 4, origin: 1065353216i64, parsed: 0, comment: unaligned to 8 bytes! two packed floats in a QWORD?(2)        // line:   *(_QWORD *)(v1 + 2440) = 1065353216i64;
        // line:   return result;
        // line: }

        // no end padding needed

        // accumulated template size: 2448 (0x990)
        // number of properties parsed: 531
    }
}
