
using SlippiStats.Extensions;
using System.ComponentModel.DataAnnotations;

namespace SlippiStats.GameDataEnums
{
    public enum Stage
    {
        [StageIcon("")]
        [StageImage("")]
        [Display(Name = "Dummy")]
        DUMMY = 0,
        [StageIcon("")]
        [StageImage("")]
        [Display(Name = "Test")]
        TEST = 1,
        [StageIcon("/images/stage_icons/FountainOfDreamsIconSSBM.png")]
        [StageImage("/images/stage_images/Fountain of Dreams.png")]
        [Display(Name = "Fountain of Dreams")]
        FOUNTAIN_OF_DREAMS = 2,
        [StageIcon("/images/stage_icons/PokemonStadiumIconSSBm.png")]
        [StageImage("/images/stage_images/Pokemon Stadium.png")]
        [Display(Name = "Pokémon Stadium")]
        POKEMON_STADIUM = 3,
        [StageIcon("/images/stage_icons/PrincessPeachsCastleIconSSBM.png")]
        [StageImage("/images/stage_images/Peach's Castle")]
        [Display(Name = "Princess Peach's Castle.png")]
        PRINCESS_PEACHS_CASTLE = 4,
        [StageIcon("/images/stage_icons/KongoJungleIconSSBM.png")]
        [StageImage("/images/stage_images/Kongo Jungle.png")]
        [Display(Name = "Kongo Jungle")]
        KONGO_JUNGLE = 5,
        [StageIcon("/images/stage_icons/BrinstarIconSSBM.png")]
        [StageImage("/images/stage_images/Brinstar.png")]
        [Display(Name = "Brinstar")]
        BRINSTAR = 6,
        [StageIcon("/images/stage_icons/CorneriaIconSSBM.png")]
        [StageImage("/images/stage_images/Corneria.png")]
        [Display(Name = "Corneria")]
        CORNERIA = 7,
        [StageIcon("/images/stage_icons/YoshisStoryIconSSBM.png")]
        [StageImage("/images/stage_images/Yoshi's Story.png")]
        [Display(Name = "Yoshi's Story")]
        YOSHIS_STORY = 8,
        [StageIcon("/images/stage_icons/OnettIconSSBM.png")]
        [StageImage("/images/stage_images/Onett.png")]
        [Display(Name = "Onett")]
        ONETT = 9,
        [StageIcon("/images/stage_icons/MuteCityIconSSBM.png")]
        [StageImage("/images/stage_images/Mute City.png")]
        [Display(Name = "Mute City")]
        MUTE_CITY = 10,
        [StageIcon("/images/stage_icons/RainbowCruiseIconSSBM.png")]
        [StageImage("/images/stage_images/Rainbow Cruise.png")]
        [Display(Name = "Rainbow Cruise")]
        RAINBOW_CRUISE = 11,
        [StageIcon("/images/stage_icons/JungleJapesIconSSBM.png")]
        [StageImage("/images/stage_images/Jungle Japes.png")]
        [Display(Name = "Jungle Japes")]
        JUNGLE_JAPES = 12,
        [StageIcon("/images/stage_icons/GreenBayIconSSBM.png")]
        [StageImage("/images/stage_images/Green Bay.png")]
        [Display(Name = "Green Bay")]
        GREEN_BAY = 13,
        [StageIcon("/images/stage_icons/TempleIconSSBM.png")]
        [StageImage("/images/stage_images/Temple.png")]
        [Display(Name = "Hyrule Temple")]
        HYRULE_TEMPLE = 14,
        [StageIcon("/images/stage_icons/BrinstarDepthsIconSSBM.png")]
        [StageImage("/images/stage_images/Brinstar Depths.png")]
        [Display(Name = "Brinstar Depths")]
        BRINSTAR_DEPTHS = 15,
        [StageIcon("/images/stage_icons/YoshisIslandIconSSBM.png")]
        [StageImage("/images/stage_images/Yoshi's Island.png")]
        [Display(Name = "Yoshi's Island")]
        YOSHIS_ISLAND = 16,
        [StageIcon("/images/stage_icons/GreenGreensIconSSBM.png")]
        [StageImage("/images/stage_images/Green Greens.png")]
        [Display(Name = "Green Greens")]
        GREEN_GREENS = 17,
        [StageIcon("/images/stage_icons/FoursideIconSSBM.png")]
        [StageImage("/images/stage_images/Fourside.png")]
        [Display(Name = "Fourside")]
        FOURSIDE = 18,
        [StageIcon("/images/stage_icons/MushroomKingdomIconSSBM.png")]
        [StageImage("/images/stage_images/Mushroom Kingdom.png")]
        [Display(Name = "Mushroom Kingdom I")]
        MUSHROOM_KINGDOM_I = 19,
        [StageIcon("/images/stage_icons/MushroomKingdomIIIconSSBM.png")]
        [StageImage("/images/stage_images/Mushroom Kingdom II.png")]
        [Display(Name = "Mushroom Kingdom II")]
        MUSHROOM_KINGDOM_II = 20,
        // Deleted stage
        //[StageIcon("")]
        //[StageImage("")]
        //[Display(Name = "Akaneia")]
        //AKANEIA = 21,
        [StageIcon("/images/stage_icons/VenomIconSSBM.png")]
        [StageImage("/images/stage_images/Venom.png")]
        [Display(Name = "Venom")]
        VENOM = 22,
        [StageIcon("/images/stage_icons/PokeFloatsIconSSBM.png")]
        [StageImage("/images/stage_images/PokeFloats.png")]
        [Display(Name = "Poké Floats")]
        POKE_FLOATS = 23,
        [StageIcon("/images/stage_icons/BigBlueIconSSBM.png")]
        [StageImage("/images/stage_images/Big Blue.png")]
        [Display(Name = "Big Blue")]
        BIG_BLUE = 24,
        [StageIcon("/images/stage_icons/IcicleMountainIconSSBM.png")]
        [StageImage("/images/stage_images/Icicle Mountain.png")]
        [Display(Name = "Icile Mountain")]
        ICICLE_MOUNTAIN = 25,
        // Debug-only stage
        [StageIcon("")]
        [StageImage("")]
        [Display(Name = "Icetop")]
        ICETOP = 26,
        [StageIcon("/images/stage_icons/FlatZoneIconSSBM.png")]
        [StageImage("/images/stage_images/Flat Zone.png")]
        [Display(Name = "Flat Zone")]
        FLAT_ZONE = 27,
        [StageIcon("/images/stage_icons/PastDreamLandIconSSBM.png")]
        [StageImage("/images/stage_images/Dream Land.png")]
        [Display(Name = "Dream Land 64")]
        DREAM_LAND_N64 = 28,
        [StageIcon("/images/stage_icons/PastYoshisIslandIconSSBM.png")]
        [StageImage("/images/stage_images/Yoshi's Island (N64).png")]
        [Display(Name = "Yoshi's Island 64")]
        YOSHIS_ISLAND_N64 = 29,
        [StageIcon("/images/stage_icons/PastKongoJungleIconSSBM.png")]
        [StageImage("/images/stage_images/Kongo Jungle (N64).png")]
        [Display(Name = "Kongo Jungle 64")]
        KONGO_JUNGLE_N64 = 30,
        [StageIcon("/images/stage_icons/BattlefieldIconSSBM.png")]
        [StageImage("/images/stage_images/Battlefield.png")]
        [Display(Name = "Battlefield")]
        BATTLEFIELD = 31,
        [StageIcon("/images/stage_icons/FinalDestinationIconSSBM.png")]
        [StageImage("/images/stage_images/Final Destination.png")]
        [Display(Name = "Final Destination")]
        FINAL_DESTINATION = 32,
        [Display(Name = "Mario BTT")]
        [StageCharacter(Character.MARIO)]
        TARGET_TEST_MARIO = 33,
        [Display(Name = "Captain Falcon BTT")]
        [StageCharacter(Character.CAPTAIN_FALCON)]
        TARGET_TEST_CAPTAIN_FALCON = 34,
        [Display(Name = "Young Link BTT")]
        [StageCharacter(Character.YOUNG_LINK)]
        TARGET_TEST_YOUNG_LINK = 35,
        [Display(Name = "Donkey Kong BTT")]
        [StageCharacter(Character.DONKEY_KONG)]
        TARGET_TEST_DONKEY_KONG = 36,
        [Display(Name = "Dr. Mario BTT")]
        [StageCharacter(Character.DR_MARIO)]
        TARGET_TEST_DOCTOR_MARIO = 37,
        [Display(Name = "Falco BTT")]
        [StageCharacter(Character.FALCO)]
        TARGET_TEST_FALCO = 38,
        [Display(Name = "Fox BTT")]
        [StageCharacter(Character.FOX)]
        TARGET_TEST_FOX = 39,
        [Display(Name = "Ice Climbers BTT")]
        [StageCharacter(Character.ICE_CLIMBERS)]
        TARGET_TEST_ICE_CLIMBERS = 40,
        [Display(Name = "Kirby BTT")]
        [StageCharacter(Character.KIRBY)]
        TARGET_TEST_KIRBY = 41,
        [Display(Name = "Bowser BTT")]
        [StageCharacter(Character.BOWSER)]
        TARGET_TEST_BOWSER = 42,
        [Display(Name = "Link BTT")]
        [StageCharacter(Character.LINK)]
        TARGET_TEST_LINK = 43,
        [Display(Name = "Luigi BTT")]
        [StageCharacter(Character.LUIGI)]
        TARGET_TEST_LUIGI = 44,
        [Display(Name = "Marth BTT")]
        [StageCharacter(Character.MARTH)]
        TARGET_TEST_MARTH = 45,
        [Display(Name = "Mewtwo BTT")]
        [StageCharacter(Character.MEWTWO)]
        TARGET_TEST_MEWTWO = 46,
        [Display(Name = "Ness BTT")]
        [StageCharacter(Character.NESS)]
        TARGET_TEST_NESS = 47,
        [Display(Name = "Peach BTT")]
        [StageCharacter(Character.PEACH)]
        TARGET_TEST_PEACH = 48,
        [Display(Name = "Pichu BTT")]
        [StageCharacter(Character.PICHU)]
        TARGET_TEST_PICHU = 49,
        [Display(Name = "Pikachu BTT")]
        [StageCharacter(Character.PIKACHU)]
        TARGET_TEST_PIKACHU = 50,
        [Display(Name = "Jigglypuff BTT")]
        [StageCharacter(Character.JIGGLYPUFF)]
        TARGET_TEST_JIGGLYPUFF = 51,
        [Display(Name = "Samus BTT")]
        [StageCharacter(Character.SAMUS)]
        TARGET_TEST_SAMUS = 52,
        [Display(Name = "Sheik BTT")]
        [StageCharacter(Character.SHEIK)]
        TARGET_TEST_SHEIK = 53,
        [Display(Name = "Yoshi BTT")]
        [StageCharacter(Character.YOSHI)]
        TARGET_TEST_YOSHI = 54,
        [Display(Name = "Zelda BTT")]
        [StageCharacter(Character.ZELDA)]
        TARGET_TEST_ZELDA = 55,
        [Display(Name = "Mr. Game & Watch BTT")]
        [StageCharacter(Character.MR_GAME_AND_WATCH)]
        TARGET_TEST_MR_GAME_AND_WATCH = 56,
        [Display(Name = "Roy BTT")]
        [StageCharacter(Character.ROY)]
        TARGET_TEST_ROY = 57,
        [Display(Name = "Ganondorf BTT")]
        [StageCharacter(Character.GANONDORF)]
        TARGET_TEST_GANONDORF = 58,
        
    }
}