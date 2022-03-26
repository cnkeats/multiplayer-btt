using SlippiStats.GameDataEnums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace SlippiStats.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum @enum)
        {
            DisplayAttribute attribute = GetDisplayAttribute(@enum);

            return attribute?.Name ?? @enum.ToString();
        }

        public static string GetDescription(this Enum @enum)
        {
            var attribute = GetDisplayAttribute(@enum);

            return attribute?.Description ?? @enum.ToString();
        }
        public static string GetStockIconPath(this Enum @enum)
        {
            var attribute = GetAttribute<StockIconAttribute>(@enum);

            return attribute?.StockIcon;
        }

        public static string GetStageIconPath(this Enum @enum)
        {
            var attribute = GetAttribute<StageIconAttribute>(@enum);

            return attribute?.StageIcon;
        }

        public static string GetStageImagePath(this Enum @enum)
        {
            var attribute = GetAttribute<StageImageAttribute>(@enum);

            return attribute?.StageImage;
        }

        public static int GetTierPlacement(this Enum @enum)
        {
            var attribute = GetAttribute<TierPlacementAttribute>(@enum);

            return attribute?.TierPlacement ?? 999;
        }

        public static bool GetTournamentLegality(this Enum @enum)
        {
            var attribute = GetAttribute<TournamentLegalAttribute>(@enum);

            if (attribute == null)
            {
                return true;
            }

            return attribute.TournamentLegal;
        }

        public static int GetBTTStage(this Enum @enum)
        {
            var attribute = GetAttribute<BTTStageAttribute>(@enum);

            if (attribute == null)
            {
                return -1;
            }

            return attribute.BTTStageId;
        }

        public static int GetCSSIndex(this Enum @enum)
        {
            var attribute = GetAttribute<CSSIndexAttribute>(@enum);

            if (attribute == null)
            {
                return -1;
            }

            return attribute.CSSIndex;
        }

        public static Character GetStageCharacterAttribute(this Enum @enum)
        {
            var attribute = GetAttribute<StageCharacterAttribute>(@enum);

            if (attribute == null)
            {
                return Character.SANDBAG;
            }

            return attribute.Character;
        }
        

        private static DisplayAttribute GetDisplayAttribute(object value)
        {
            if (value == null)
            {
                return null;
            }

            Type type = value.GetType();

            if (!type.IsEnum)
            {
                throw new ArgumentException($"Type {type} is not an enum.");
            }

            FieldInfo fieldInfo = type.GetField(value.ToString());

            return fieldInfo?.GetCustomAttribute<DisplayAttribute>();
        }

        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);
            return enumType.GetField(name).GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
        }

    }

    class StockIconAttribute : Attribute
    {
        public string StockIcon { get; private set; }

        public StockIconAttribute(string path)
        {
            this.StockIcon = path;
        }
    }

    class StageIconAttribute : Attribute
    {
        public string StageIcon { get; private set; }

        public StageIconAttribute(string path)
        {
            this.StageIcon = path;
        }
    }

    class StageImageAttribute : Attribute
    {
        public string StageImage { get; private set; }

        public StageImageAttribute(string path)
        {
            this.StageImage = path;
        }
    }

    class TournamentLegalAttribute : Attribute
    {
        public bool TournamentLegal { get; private set; }

        public TournamentLegalAttribute(bool legality)
        {
            this.TournamentLegal = legality;
        }
    }

    class TierPlacementAttribute : Attribute
    {
        public int TierPlacement { get; private set; }

        public TierPlacementAttribute(int index)
        {
            this.TierPlacement = index;
        }
    }

    class BTTStageAttribute : Attribute
    {
        public int BTTStageId { get; private set; }

        public BTTStageAttribute(int index)
        {
            this.BTTStageId = index;
        }
    }

    class CSSIndexAttribute : Attribute
    {
        public int CSSIndex { get; private set; }

        public CSSIndexAttribute(int index)
        {
            this.CSSIndex = index;
        }
    }

    class StageCharacterAttribute : Attribute
    {
        public Character Character { get; private set; }

        public StageCharacterAttribute(Character character)
        {
            this.Character = character;
        }
    }
}