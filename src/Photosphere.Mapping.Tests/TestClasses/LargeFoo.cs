using System;
// ReSharper disable MemberCanBePrivate.Global

namespace Photosphere.Mapping.Tests.TestClasses
{
    internal class LargeFoo
    {
        public int Property00 { get; set; }
        public int Property01 { get; set; }
        public int Property02 { get; set; }
        public int Property03 { get; set; }
        public int Property04 { get; set; }
        public int Property05 { get; set; }
        public int Property06 { get; set; }
        public int Property07 { get; set; }
        public int Property08 { get; set; }
        public int Property09 { get; set; }
        public int Property10 { get; set; }
        public int Property11 { get; set; }
        public int Property12 { get; set; }
        public int Property13 { get; set; }
        public int Property14 { get; set; }
        public int Property15 { get; set; }
        public int Property16 { get; set; }
        public int Property17 { get; set; }
        public int Property18 { get; set; }
        public int Property19 { get; set; }
        public int Property20 { get; set; }
        public int Property21 { get; set; }
        public int Property22 { get; set; }
        public int Property23 { get; set; }
        public int Property24 { get; set; }
        public int Property25 { get; set; }
        public int Property26 { get; set; }
        public int Property27 { get; set; }
        public int Property28 { get; set; }
        public int Property29 { get; set; }
        public int Property30 { get; set; }
        public int Property31 { get; set; }
        public int Property32 { get; set; }
        public int Property33 { get; set; }
        public int Property34 { get; set; }
        public int Property35 { get; set; }
        public int Property36 { get; set; }
        public int Property37 { get; set; }
        public int Property38 { get; set; }
        public int Property39 { get; set; }
        public int Property40 { get; set; }
        public int Property41 { get; set; }
        public int Property42 { get; set; }
        public int Property43 { get; set; }
        public int Property44 { get; set; }
        public int Property45 { get; set; }
        public int Property46 { get; set; }
        public int Property47 { get; set; }
        public int Property48 { get; set; }
        public int Property49 { get; set; }
        public int Property50 { get; set; }
        public int Property51 { get; set; }
        public int Property52 { get; set; }
        public int Property53 { get; set; }
        public int Property54 { get; set; }
        public int Property55 { get; set; }
        public int Property56 { get; set; }
        public int Property57 { get; set; }
        public int Property58 { get; set; }
        public int Property59 { get; set; }
        public int Property60 { get; set; }
        public int Property61 { get; set; }
        public int Property62 { get; set; }
        public int Property63 { get; set; }
        public int Property64 { get; set; }
        public int Property65 { get; set; }
        public int Property66 { get; set; }
        public int Property67 { get; set; }
        public int Property68 { get; set; }
        public int Property69 { get; set; }
        public int Property70 { get; set; }
        public int Property71 { get; set; }
        public int Property72 { get; set; }
        public int Property73 { get; set; }
        public int Property74 { get; set; }
        public int Property75 { get; set; }
        public int Property76 { get; set; }
        public int Property77 { get; set; }
        public int Property78 { get; set; }
        public int Property79 { get; set; }
        public int Property80 { get; set; }
        public int Property81 { get; set; }
        public int Property82 { get; set; }
        public int Property83 { get; set; }
        public int Property84 { get; set; }
        public int Property85 { get; set; }
        public int Property86 { get; set; }
        public int Property87 { get; set; }
        public int Property88 { get; set; }
        public int Property89 { get; set; }
        public int Property90 { get; set; }
        public int Property91 { get; set; }
        public int Property92 { get; set; }
        public int Property93 { get; set; }
        public int Property94 { get; set; }
        public int Property95 { get; set; }
        public int Property96 { get; set; }
        public int Property97 { get; set; }
        public int Property98 { get; set; }
        public int Property99 { get; set; }

        internal static LargeFoo GetRandomNew()
        {
            var instance = new LargeFoo();
            var radom = new Random();
            foreach (var property in instance.GetType().GetProperties())
            {
                property.SetValue(instance, radom.Next());
            }
            return instance;
        }

        internal static void NativeMap(LargeFoo source, LargeFoo target)
        {
            target.Property00 = source.Property00;
            target.Property01 = source.Property01;
            target.Property02 = source.Property02;
            target.Property03 = source.Property03;
            target.Property04 = source.Property04;
            target.Property05 = source.Property05;
            target.Property06 = source.Property06;
            target.Property07 = source.Property07;
            target.Property08 = source.Property08;
            target.Property09 = source.Property09;
            target.Property10 = source.Property10;
            target.Property11 = source.Property11;
            target.Property12 = source.Property12;
            target.Property13 = source.Property13;
            target.Property14 = source.Property14;
            target.Property15 = source.Property15;
            target.Property16 = source.Property16;
            target.Property17 = source.Property17;
            target.Property18 = source.Property18;
            target.Property19 = source.Property19;
            target.Property20 = source.Property20;
            target.Property21 = source.Property21;
            target.Property22 = source.Property22;
            target.Property23 = source.Property23;
            target.Property24 = source.Property24;
            target.Property25 = source.Property25;
            target.Property26 = source.Property26;
            target.Property27 = source.Property27;
            target.Property28 = source.Property28;
            target.Property29 = source.Property29;
            target.Property30 = source.Property30;
            target.Property31 = source.Property31;
            target.Property32 = source.Property32;
            target.Property33 = source.Property33;
            target.Property34 = source.Property34;
            target.Property35 = source.Property35;
            target.Property36 = source.Property36;
            target.Property37 = source.Property37;
            target.Property38 = source.Property38;
            target.Property39 = source.Property39;
            target.Property40 = source.Property40;
            target.Property41 = source.Property41;
            target.Property42 = source.Property42;
            target.Property43 = source.Property43;
            target.Property44 = source.Property44;
            target.Property45 = source.Property45;
            target.Property46 = source.Property46;
            target.Property47 = source.Property47;
            target.Property48 = source.Property48;
            target.Property49 = source.Property49;
            target.Property50 = source.Property50;
            target.Property51 = source.Property51;
            target.Property52 = source.Property52;
            target.Property53 = source.Property53;
            target.Property54 = source.Property54;
            target.Property55 = source.Property55;
            target.Property56 = source.Property56;
            target.Property57 = source.Property57;
            target.Property58 = source.Property58;
            target.Property59 = source.Property59;
            target.Property60 = source.Property60;
            target.Property61 = source.Property61;
            target.Property62 = source.Property62;
            target.Property63 = source.Property63;
            target.Property64 = source.Property64;
            target.Property65 = source.Property65;
            target.Property66 = source.Property66;
            target.Property67 = source.Property67;
            target.Property68 = source.Property68;
            target.Property69 = source.Property69;
            target.Property70 = source.Property70;
            target.Property71 = source.Property71;
            target.Property72 = source.Property72;
            target.Property73 = source.Property73;
            target.Property74 = source.Property74;
            target.Property75 = source.Property75;
            target.Property76 = source.Property76;
            target.Property77 = source.Property77;
            target.Property78 = source.Property78;
            target.Property79 = source.Property79;
            target.Property80 = source.Property80;
            target.Property81 = source.Property81;
            target.Property82 = source.Property82;
            target.Property83 = source.Property83;
            target.Property84 = source.Property84;
            target.Property85 = source.Property85;
            target.Property86 = source.Property86;
            target.Property87 = source.Property87;
            target.Property88 = source.Property88;
            target.Property89 = source.Property89;
            target.Property90 = source.Property90;
            target.Property91 = source.Property91;
            target.Property92 = source.Property92;
            target.Property93 = source.Property93;
            target.Property94 = source.Property94;
            target.Property95 = source.Property95;
            target.Property96 = source.Property96;
            target.Property97 = source.Property97;
            target.Property98 = source.Property98;
            target.Property99 = source.Property99;
        }
    }
}