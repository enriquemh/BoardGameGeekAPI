using System;
using System.Collections.Generic;
using System.Linq;
using BoardGameGeekAPI.BGGObjects;

namespace BoardGameGeekAPI.ExtendedMethods
{
    public static class CollectionExtensionMethods
    {
        public static ICollection<itemsItem> GetUniqueItems(this Items items)
        {
            if (items?.Item == null)
                return new itemsItem[] { };

            // Removing duplicated games in the query.
            return items.Item.Distinct()
                .GroupBy(item => item.objectid)
                .Select(n => n.First())
                .ToList();
        }

        public static double GetGameRating(this itemsItem item)
        {
            var value = item.GetRating()?.value;

            if (value == null)
                return default(double);

            return SafeDoubleSeparator(double.Parse(value));
        }

        public static double GetUsersRated(this itemsItem items)
        {
            var value = items.GetRating()?.usersrated?.FirstOrDefault()?.value;
            if (value == null)
                return default(double);

            return Double.Parse(value);
        }

        public static double GetAverage(this itemsItem items)
        {
            var value = items.GetRating()?.average?.FirstOrDefault()?.value;
            if (value == null)
                return default(double);

            return SafeDoubleSeparator(Double.Parse(value));
        }

        public static double GetBayesAverage(this itemsItem items)
        {
            var value = items.GetRating()?.bayesaverage?.FirstOrDefault()?.value;
            if (value == null)
                return default(double);

            return SafeDoubleSeparator(Double.Parse(value));
        }

        public static double GetMedian(this itemsItem items)
        {
            var value = items.GetRating()?.median?.FirstOrDefault()?.value;
            if (value == null)
                return default(double);

            return SafeDoubleSeparator(Double.Parse(value));
        }

        public static double GetStandardDeviation(this itemsItem items)
        {
            var value = items.GetRating()?.stddev?.FirstOrDefault()?.value;
            if (value == null)
                return default(double);

            return SafeDoubleSeparator(Double.Parse(value));
        }

        public static itemsItemStatsRating GetRating(this itemsItem items)
        {
            return items.stats?.FirstOrDefault()?.rating?.FirstOrDefault();
        }

        private static double SafeDoubleSeparator(double value)
        {
            while (value > 10)
                value /= 10;
            
            return value;
        }
    }
}
