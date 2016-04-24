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

        internal static void NativeMap(LargeFoo obj1, LargeFoo obj2)
        {
            obj1.Property00 = obj2.Property00;
            obj1.Property01 = obj2.Property01;
            obj1.Property02 = obj2.Property02;
            obj1.Property03 = obj2.Property03;
            obj1.Property04 = obj2.Property04;
            obj1.Property05 = obj2.Property05;
            obj1.Property06 = obj2.Property06;
            obj1.Property07 = obj2.Property07;
            obj1.Property08 = obj2.Property08;
            obj1.Property09 = obj2.Property09;
            obj1.Property10 = obj2.Property10;
            obj1.Property11 = obj2.Property11;
            obj1.Property12 = obj2.Property12;
            obj1.Property13 = obj2.Property13;
            obj1.Property14 = obj2.Property14;
            obj1.Property15 = obj2.Property15;
            obj1.Property16 = obj2.Property16;
            obj1.Property17 = obj2.Property17;
            obj1.Property18 = obj2.Property18;
            obj1.Property19 = obj2.Property19;
            obj1.Property20 = obj2.Property20;
            obj1.Property21 = obj2.Property21;
            obj1.Property22 = obj2.Property22;
            obj1.Property23 = obj2.Property23;
            obj1.Property24 = obj2.Property24;
            obj1.Property25 = obj2.Property25;
            obj1.Property26 = obj2.Property26;
            obj1.Property27 = obj2.Property27;
            obj1.Property28 = obj2.Property28;
            obj1.Property29 = obj2.Property29;
            obj1.Property30 = obj2.Property30;
            obj1.Property31 = obj2.Property31;
            obj1.Property32 = obj2.Property32;
            obj1.Property33 = obj2.Property33;
            obj1.Property34 = obj2.Property34;
            obj1.Property35 = obj2.Property35;
            obj1.Property36 = obj2.Property36;
            obj1.Property37 = obj2.Property37;
            obj1.Property38 = obj2.Property38;
            obj1.Property39 = obj2.Property39;
            obj1.Property40 = obj2.Property40;
            obj1.Property41 = obj2.Property41;
            obj1.Property42 = obj2.Property42;
            obj1.Property43 = obj2.Property43;
            obj1.Property44 = obj2.Property44;
            obj1.Property45 = obj2.Property45;
            obj1.Property46 = obj2.Property46;
            obj1.Property47 = obj2.Property47;
            obj1.Property48 = obj2.Property48;
            obj1.Property49 = obj2.Property49;
            obj1.Property50 = obj2.Property50;
            obj1.Property51 = obj2.Property51;
            obj1.Property52 = obj2.Property52;
            obj1.Property53 = obj2.Property53;
            obj1.Property54 = obj2.Property54;
            obj1.Property55 = obj2.Property55;
            obj1.Property56 = obj2.Property56;
            obj1.Property57 = obj2.Property57;
            obj1.Property58 = obj2.Property58;
            obj1.Property59 = obj2.Property59;
            obj1.Property60 = obj2.Property60;
            obj1.Property61 = obj2.Property61;
            obj1.Property62 = obj2.Property62;
            obj1.Property63 = obj2.Property63;
            obj1.Property64 = obj2.Property64;
            obj1.Property65 = obj2.Property65;
            obj1.Property66 = obj2.Property66;
            obj1.Property67 = obj2.Property67;
            obj1.Property68 = obj2.Property68;
            obj1.Property69 = obj2.Property69;
            obj1.Property70 = obj2.Property70;
            obj1.Property71 = obj2.Property71;
            obj1.Property72 = obj2.Property72;
            obj1.Property73 = obj2.Property73;
            obj1.Property74 = obj2.Property74;
            obj1.Property75 = obj2.Property75;
            obj1.Property76 = obj2.Property76;
            obj1.Property77 = obj2.Property77;
            obj1.Property78 = obj2.Property78;
            obj1.Property79 = obj2.Property79;
            obj1.Property80 = obj2.Property80;
            obj1.Property81 = obj2.Property81;
            obj1.Property82 = obj2.Property82;
            obj1.Property83 = obj2.Property83;
            obj1.Property84 = obj2.Property84;
            obj1.Property85 = obj2.Property85;
            obj1.Property86 = obj2.Property86;
            obj1.Property87 = obj2.Property87;
            obj1.Property88 = obj2.Property88;
            obj1.Property89 = obj2.Property89;
            obj1.Property90 = obj2.Property90;
            obj1.Property91 = obj2.Property91;
            obj1.Property92 = obj2.Property92;
            obj1.Property93 = obj2.Property93;
            obj1.Property94 = obj2.Property94;
            obj1.Property95 = obj2.Property95;
            obj1.Property96 = obj2.Property96;
            obj1.Property97 = obj2.Property97;
            obj1.Property98 = obj2.Property98;
            obj1.Property99 = obj2.Property99;
        }
    }
}