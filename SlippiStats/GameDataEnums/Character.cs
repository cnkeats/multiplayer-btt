
using SlippiStats.Extensions;
using System.ComponentModel.DataAnnotations;

namespace SlippiStats.GameDataEnums
{
    public enum Character
    {
        [Display(Name = "Captain Falcon")]
        [CSSIndex(7)]
        [TierPlacement(5)]
        [BTTStage(34)]
        [StockIcon("/images/stock_icons/CaptainFalconHeadSSBM.png")]
        CAPTAIN_FALCON = 0,

        [Display(Name = "Donkey Kong")]
        [CSSIndex(6)]
        [TierPlacement(13)]
        [BTTStage(36)]
        [StockIcon("/images/stock_icons/DonkeyKongHeadSSBM.png")]
        DONKEY_KONG = 1,

        [Display(Name = "Fox")]
        [CSSIndex(10)]
        [TierPlacement(0)]
        [BTTStage(39)]
        [StockIcon("/images/stock_icons/FoxHeadSSBM.png")]
        FOX = 2,

        [Display(Name = "Mr. Game & Watch")]
        [CSSIndex(22)]
        [TierPlacement(19)]
        [BTTStage(56)]
        [StockIcon("/images/stock_icons/MrGame&WatchHeadSSBM.png")]
        MR_GAME_AND_WATCH = 3,

        [Display(Name = "Kirby")]
        [CSSIndex(13)]
        [TierPlacement(25)]
        [BTTStage(41)]
        [StockIcon("/images/stock_icons/KirbyHeadSSBM.png")]
        KIRBY = 4,

        [Display(Name = "Bowser")]
        [CSSIndex(3)]
        [TierPlacement(24)]
        [BTTStage(42)]
        [StockIcon("/images/stock_icons/BowserHeadSSBM.png")]
        BOWSER = 5,

        [Display(Name = "Link")]
        [CSSIndex(16)]
        [TierPlacement(16)]
        [BTTStage(43)]
        [StockIcon("/images/stock_icons/LinkHeadSSBM.png")]
        LINK = 6,

        [Display(Name = "Luigi")]
        [CSSIndex(2)]
        [TierPlacement(10)]
        [BTTStage(44)]
        [StockIcon("/images/stock_icons/LuigiHeadSSBM.png")]
        LUIGI = 7,

        [Display(Name = "Mario")]
        [CSSIndex(1)]
        [TierPlacement(14)]
        [BTTStage(33)]
        [StockIcon("/images/stock_icons/MarioHeadSSBM.png")]
        MARIO = 8,

        [Display(Name = "Marth")]
        [CSSIndex(23)]
        [TierPlacement(1)]
        [BTTStage(45)]
        [StockIcon("/images/stock_icons/MarthHeadSSBM.png")]
        MARTH = 9,

        [Display(Name = "Mewtwo")]
        [CSSIndex(21)]
        [TierPlacement(17)]
        [BTTStage(46)]
        [StockIcon("/images/stock_icons/MewtwoHeadSSBM.png")]
        MEWTWO = 10,

        [Display(Name = "Ness")]
        [CSSIndex(11)]
        [TierPlacement(21)]
        [BTTStage(47)]
        [StockIcon("/images/stock_icons/NessHeadSSBM.png")]
        NESS = 11,

        [Display(Name = "Peach")]
        [CSSIndex(4)]
        [TierPlacement(6)]
        [BTTStage(48)]
        [StockIcon("/images/stock_icons/PeachHeadSSBM.png")]
        PEACH = 12,

        [Display(Name = "Pikachu")]
        [CSSIndex(19)]
        [TierPlacement(7)]
        [BTTStage(50)]
        [StockIcon("/images/stock_icons/PikachuHeadSSBM.png")]
        PIKACHU = 13,

        [Display(Name = "Ice Climbers")]
        [CSSIndex(22)]
        [TierPlacement(8)]
        [BTTStage(40)]
        [StockIcon("/images/stock_icons/IceClimbersHeadSSBM.png")]
        ICE_CLIMBERS = 14,

        [Display(Name = "Jigglypuff")]
        [CSSIndex(20)]
        [TierPlacement(4)]
        [BTTStage(51)]
        [StockIcon("/images/stock_icons/JigglypuffHeadSSBM.png")]
        JIGGLYPUFF = 15,

        [Display(Name = "Samus")]
        [CSSIndex(14)]
        [TierPlacement(9)]
        [BTTStage(52)]
        [StockIcon("/images/stock_icons/SamusHeadSSBM.png")]
        SAMUS = 16,

        [Display(Name = "Yoshi")]
        [CSSIndex(5)]
        [TierPlacement(11)]
        [BTTStage(54)]
        [StockIcon("/images/stock_icons/YoshiHeadSSBM.png")]
        YOSHI = 17,

        [Display(Name = "Zelda")]
        [CSSIndex(15)]
        [TierPlacement(20)]
        [BTTStage(55)]
        [StockIcon("/images/stock_icons/ZeldaHeadSSBM.png")]
        ZELDA = 18,

        [Display(Name = "Sheik")]
        [CSSIndex(15)]
        [TierPlacement(3)]
        [BTTStage(53)]
        [StockIcon("/images/stock_icons/SheikHeadSSBM.png")]
        SHEIK = 19,

        [Display(Name = "Falco")]
        [CSSIndex(9)]
        [TierPlacement(2)]
        [BTTStage(38)]
        [StockIcon("/images/stock_icons/FalcoHeadSSBM.png")]
        FALCO = 20,

        [Display(Name = "Young Link")]
        [CSSIndex(17)]
        [TierPlacement(15)]
        [BTTStage(35)]
        [StockIcon("/images/stock_icons/YoungLinkHeadSSBM.png")]
        YOUNG_LINK = 21,

        [Display(Name = "Dr. Mario")]
        [CSSIndex(0)]
        [TierPlacement(12)]
        [BTTStage(37)]
        [StockIcon("/images/stock_icons/DrMarioHeadSSBM.png")]
        DR_MARIO = 22,

        [Display(Name = "Roy")]
        [CSSIndex(24)]
        [TierPlacement(18)]
        [BTTStage(57)]
        [StockIcon("/images/stock_icons/RoyHeadSSBM.png")]
        ROY = 23,

        [Display(Name = "Pichu")]
        [CSSIndex(18)]
        [TierPlacement(23)]
        [BTTStage(49)]
        [StockIcon("/images/stock_icons/PichuHeadSSBM.png")]
        PICHU = 24,

        [Display(Name = "Ganondorf")]
        [CSSIndex(8)]
        [TierPlacement(13)]
        [BTTStage(58)]
        [StockIcon("/images/stock_icons/GanondorfHeadSSBM.png")]
        GANONDORF = 25,

        [Display(Name = "Master Hand")]
        [TournamentLegal(false)]
        [CSSIndex(50)]
        [StockIcon("/images/stock_icons/MasterHandHeadSSBM.png")]
        MASTER_HAND = 26,

        [Display(Name = "Male Wireframe")]
        [TournamentLegal(false)]
        [CSSIndex(51)]
        [StockIcon("/images/stock_icons/FightingWireFramesHeadSSBM.png")]
        WIREFRAME_MALE = 27,

        [Display(Name = "Female Wireframe")]
        [TournamentLegal(false)]
        [CSSIndex(52)]
        [StockIcon("/images/stock_icons/FightingWireFramesHeadSSBM.png")]
        WIREFRAME_FEMALE = 28,

        [Display(Name = "Giga Bowser")]
        [TournamentLegal(false)]
        [CSSIndex(53)]
        [StockIcon("/images/stock_icons/GigaBowserHeadSSBM.png")]
        GIGA_BOWSER = 29,

        [Display(Name = "Crazy Hand")]
        [TournamentLegal(false)]
        [CSSIndex(54)]
        [StockIcon("/images/stock_icons/CrazyHandHeadSSBM.png")]
        CRAZY_HAND = 30,

        [Display(Name = "Sandbag")]
        [TournamentLegal(false)]
        [CSSIndex(55)]
        [StockIcon("/images/stock_icons/SandbagHeadSSBM.png")]
        SANDBAG = 31,

        [Display(Name = "Popo")]
        [TournamentLegal(false)]
        [CSSIndex(56)]
        [StockIcon("/images/stock_icons/IceClimbersHeadSSBM.png")]
        POPO = 32
    }
}