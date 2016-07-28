using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    public static class SchemaConstants
    {
        public enum EvolutionLevel : byte
        {
            Base = 0,
            Plus = 1,
            PlusPlus = 2
        }

        public enum EventType : byte
        {
            DailyDungeon = 1,
            Challenge = 2,
            Survival = 3,
            Coliseum = 4
        }

        // These correspond to values the game sends us.  We can just cast an
        // equipment category directly from the game to this type and it will
        // match.
        public enum ItemType : byte
        {
            Weapon = 1,
            Armor = 2,
            Accessory = 3,
            UpgradeMaterial = 4,
            Orb = 5,
            GrowthEgg = 6
        }

        public enum EquipmentCategory : byte
        {
            Dagger = 1,
            Sword = 2,
            Katana = 3,
            Axe = 4,
            Hammer = 5,
            Spear = 6,
            Fist = 7,
            Rod = 8,
            Staff = 9,
            Bow = 10,
            Instrument = 11,
            Whip = 12,
            Thrown = 13,
            Book = 14,
            Gun = 15,
            Ball = 30,
            Hairpin = 31,
            GunArm = 32,
            Gambling = 33,
            Doll = 34,
            Shield = 50,
            Hat = 51,
            Helm = 52,
            LightArmor = 53,
            Armor = 54,
            Robe = 55,
            Bracer = 56,
            Accessory = 80,
            AugmentItem = 97,
            WeaponUpgrade = 98,
            ArmorUpgrade = 99
        }

        public enum AbilityCategory
        {
            BlackMagic = 1,
            WhiteMagic = 2,
            Summoning = 3,
            Spellblade = 4,
            Combat = 5,
            Support = 6,
            Celerity = 7,
            Dragoon = 8,
            Monk = 9,
            Thief = 10,
            Knight = 11,
            Samurai = 12,
            Ninja = 13,
            Bard = 14,
            Dancer = 15,
            Machinist = 16,
            Darkness = 17,
            Sniper = 18,
            None = -1
        };

        public enum PartyFormation : byte
        {
            Front = 1,
            Back = 2
        }

        public enum Rarity : byte
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7
        }

        // Similar to ItemType, the values here are application-defined, but should
        // remain consistent.
        public enum OrbType : byte
        {
            Power = 0,
            White = 1,
            Black = 2,
            NonElemental = 3,
            Fire = 4,
            Ice = 5,
            Lightning = 6,
            Earth = 7,
            Wind = 8,
            Holy = 9,
            Dark = 10,
            Summon = 11,
            Blue = 12      // This isn't in the game, but it's in the data files.  Hmm...
        }

        public enum WorldType : ushort
        {
            Normal = 1,
            Event = 2
        }

        public enum DungeonType : byte
        {
            Normal = 1,
            Elite = 2
        }

        public enum ElementID : ushort
        {
            None = 0,
            Fire = 100,
            Ice = 101,
            Lightning = 102,
            Earth = 103,
            Wind = 104,
            Water = 105,
            Holy = 106,
            Dark = 107,
            Poison = 108,
            Nothing = 199
        }

        public enum ElementVulnerability : ushort
        {
            Vulnerable = 1,
            Resist = 6,
            Null = 11,
            Absorb = 21
        }

        public enum StatusID : ushort
        {
            Poison = 200,
            Silence = 201,
            Paralyze = 202,
            Confuse = 203,
            Haste = 204,
            Slow = 205,
            Stop = 206,
            Protect = 207,
            Shell = 208,
            Reflect = 209,
            Blind = 210,
            Sleep = 211,
            Petrify = 212,
            Doom = 213,
            Instant_KO = 214,
            Beserk = 215,
            Regen = 216,
            Reraise = 217,
            Float = 218,
            Weak = 219,
            Zombie = 220,
            Mini = 221,
            Toad = 222,
            Curse = 223,
            Slownumb = 224,
            Blink = 225,
            Sap = 229,
            Stun = 242
        }

        public enum StatusVulnerability : ushort
        {
            Immune = 1
        }

        public enum Formulas { Healing, Magical, None, Physical };

        public enum BuddyID : uint
        {
            DESHI = 10000200,
            WARRIOR = 10000300,
            KNIGHT = 10000400,
            MONK = 10000600,
            RED_MAGE = 10000900,
            BLACK_MAGE = 10001100,
            WHITE_MAGE = 10001400,
            SUMMONER = 10001700,
            SAMURAI = 10001900,
            DRAGOON = 10002000,
            MAGIC_KNIGHT = 10002100,
            DARK_KNIGHT = 10002200,
            VIKING = 10002400,
            BERSERKER = 10002500,
            RANGER = 10002600,
            THIEF = 10002700,
            BARD = 10002800,
            NINJA = 10003000,
            GLADIATOR = 10003300,
            WOL = 10100100,
            FRIONIEL = 10200100,
            MARIA = 10200200,
            LEON = 10200400,
            MINWU = 10200500,
            GORDON = 10200600,
            LEILA = 10200700,
            RICHARD = 10200800,
            JOSEF = 10200900,
            LUNETH = 10300100,
            ARC = 10300200,
            REFIA = 10300300,
            INGUS = 10300400,
            DESCH = 10300500,
            DARK_CECIL = 10400100,
            PALADIN_CECIL = 10400200,
            CAIN = 10400300,
            RYDIA = 10400400,
            ROSA = 10400600,
            GILBERT = 10400700,
            PALOM = 10400800,
            POROM = 10400900,
            YANG = 10401000,
            TELLAH = 10401100,
            EDGE = 10401200,
            FUSOYA = 10401300,
            GOLBEZ = 10401400,
            BUTS = 10500800,
            LENNA = 10500200,
            GALUF = 10500500,
            GILGAMESH = 10500700,
            FARIS = 10500900,
            KRILE = 10501200,
            FREELANCER_BUTS = 10500800,
            EXDEATH = 10501100,
            FREELANCER_KRILE = 10501200,
            TINA = 10600100,
            LOCK = 10600300,
            CELES = 10600400,
            MOG = 10600500,
            EDGAR = 10600600,
            MASH = 10600700,
            SHADOW = 10600800,
            CAYENNE = 10600900,
            GAU = 10601000,
            SETZER = 10601100,
            STRAGUS = 10601200,
            RELM = 10601300,
            KEFKA = 10601600,
            CLOUD = 10700100,
            BARRET = 10700200,
            TIFA = 10700300,
            AERITH = 10700400,
            RED_XIII = 10700500,
            YUFFIE = 10700600,
            CAITSITH = 10700700,
            VINCENT = 10700800,
            ZACK = 10700900,
            SEPHIROTH = 10701000,
            CID = 10701100,
            RENO = 10701200,
            SQUALL = 10800100,
            RINOA = 10800200,
            QUISTIS = 10800300,
            ZELL = 10800400,
            SELPHIE = 10800500,
            IRVINE = 10800600,
            SEIFER = 10800700,
            EDEA = 10800800,
            LAGUNA = 10800900,
            ZIDANE = 10900100,
            GARNET = 10900200,
            VIVI = 10900300,
            STEINER = 10900400,
            FREYA = 10900500,
            QUINA = 10900600,
            EIKO = 10900700,
            AMARANT = 10900800,
            BEATRIX = 10900900,
            KUJA = 10901000,
            TIDUS = 11000100,
            YUNA = 11000200,
            WAKKA = 11000300,
            LULU = 11000400,
            KIMAHRI = 11000500,
            RIKKU = 11000600,
            AURON = 11000700,
            JECHT = 11001000,
            BRASKA = 11001200,
            VAAN = 11200100,
            BALFLEAR = 11200200,
            FRAN = 11200300,
            BASCH = 11200400,
            ASHE = 11200500,
            PENELO = 11200600,
            LIGHTNING = 11300100,
            SNOW = 11300200,
            VANILLE = 11300300,
            SAZH = 11300400,
            HOPE = 11300500,
            FANG = 11300600,
            SERAH = 11300700,
            NOEL = 11300800,
            YSHTOLA = 11400100,
            THANCRED = 11400200,
            YDA = 11400300,
            PAPALYMO = 11400500,
            RAMZA = 15000100,
            AGRIAS = 15000200
        }
    }
}
