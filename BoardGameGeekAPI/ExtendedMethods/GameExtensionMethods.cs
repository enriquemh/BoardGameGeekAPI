﻿using System;
using System.Collections.Generic;
using System.Linq;
using BoardGameGeekAPI.BGGObjects.Game;
using Game = BoardGameGeekAPI.BGGObjects.Game.Game;

namespace BoardGameGeekAPI.ExtendedMethods
{
    public static class GameExtensionMethods
    {
        private static readonly string PRIMARY_NAME = "primary";
        private static readonly string BOARDGAME_CATEGORY = "boardgamecategory";
        private static readonly string BOARDGAME_MECHANIC = "boardgamemechanic";
        private static readonly string BOARDGAME_FAMILY   = "boardgamefamily";
        private static readonly string ADMIN_NOT_TO_ADD = "Admin: Better Description Needed!";

        #region Game Property

        public static int GetId(this Game game)
        {
            var item = game.GetGameItem();
            if (item == null)
                throw new NullReferenceException("Game item returned null");

            return int.Parse(item.Id);
        }

        public static string GetName(this Game game)
        {
            return game.GetGameItem()?.Name.FirstOrDefault(name => string.Equals(name.Type, PRIMARY_NAME))?.Value;
        }

        public static double GetYearPublished(this Game game)
        {
            return SafeGetValue(game.GetValue("Yearpublished"));
        }

        public static double GetMinPlayers(this Game game)
        {
            return SafeGetValue(game.GetValue("Minplayers"));
        }

        public static double GetMaxPlayers(this Game game)
        {
            return SafeGetValue(game.GetValue("Maxplayers"));
        }

        public static double GetPlayingTime(this Game game)
        {
            return SafeGetValue(game.GetValue("Playingtime"), double.MaxValue);
        }

        public static double GetMinPlayTime(this Game game)
        {
            return SafeGetValue(game.GetValue("Minplaytime"));
        }

        public static double GetMaxPlayTime(this Game game)
        {
            return SafeGetValue(game.GetValue("Maxplaytime"), double.MaxValue);
        }

        public static double GetMinAge(this Game game)
        {
            return SafeGetValue(game.GetValue("Minage"));
        }

        private static double SafeGetValue(string value, double defaultValue = double.MinValue)
        {
            if (string.IsNullOrEmpty(value))
                return defaultValue;

            return Double.Parse(value);
        }

        public static double GetAverageWeight(this Game game)
        {
            return SafeDoubleSeparator(game.GetStatistics().Averageweight.Value);
        }

        public static double GetNumComments(this Game game)
        {
            return double.Parse(game.GetStatistics().Numcomments.Value);
        }

        public static double GetOwned(this Game game)
        {
            return Double.Parse(game.GetStatistics().Owned.Value);
        }

        public static double GetNumWeights(this Game game)
        {
            return Double.Parse(game.GetStatistics().Numweights.Value);
        }

        public static double GetTrading(this Game game)
        {
            return Double.Parse(game.GetStatistics().Trading.Value);
        }

        public static double GetUsersRated(this Game game)
        {
            return Double.Parse(game.GetStatistics().Usersrated.Value);
        }

        public static double GetWanting(this Game game)
        {
            return Double.Parse(game.GetStatistics().Wanting.Value);
        }

        public static double GetWishing(this Game game)
        {
            return Double.Parse(game.GetStatistics().Wishing.Value);
        }

        public static List<Link> GetGameCategories(this Game game)
        {
            return game.GetGameItem().Link.Where(link => string.Equals(link.Type, BOARDGAME_CATEGORY)).ToList();
        }

        public static List<Link> GetGameMechanics(this Game game)
        {
            return game.GetGameItem().Link.Where(link => string.Equals(link.Type, BOARDGAME_MECHANIC)).ToList();
        }

        public static List<Link> GetGameFamilies(this Game game)
        {
            return game
                .GetGameItem()
                .Link
                .Where(link =>
                    string.Equals(link.Type, BOARDGAME_FAMILY)
                    && !string.Equals(link.Value, ADMIN_NOT_TO_ADD))
                .ToList();
        }

        // Methods to get internal objects / properties
        private static string GetValue(this Game game, string propName)
        {
            var gameItem = game.GetGameItem();

            var obj = gameItem
                .GetType()
                .GetProperty(propName)
                ?.GetValue(gameItem, null);

            return obj?
                .GetType()
                .GetProperty("Value")
                ?.GetValue(obj, null) as string;
        }

        private static Item GetGameItem(this Game game)
        {
            return game.Item;
        }

        private static Ratings GetStatistics(this Game game)
        {
            return game.GetGameItem().Statistics.Ratings;
        }

        private static double SafeDoubleSeparator(string value)
        {
            var doubleValue = double.Parse(value);

            while (doubleValue > 10)
                doubleValue /= 10;

            return doubleValue;
        }
        #endregion

    }
}
