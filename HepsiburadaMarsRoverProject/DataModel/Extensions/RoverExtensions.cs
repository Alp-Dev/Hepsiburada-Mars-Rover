using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Extensions
{
    public static class RoverExtensions
    {
        public static string FormatRoversInformationAsString(this IEnumerable<IRover> rovers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var rover in rovers)
            {
                stringBuilder.Append(rover.XDimension.Value);
                stringBuilder.Append(" ");
                stringBuilder.Append(rover.YDimension.Value);
                stringBuilder.Append(" ");
                stringBuilder.Append(rover.CardinalDirection.ToString());
                stringBuilder.Append(Environment.NewLine);
            }
            stringBuilder.Length--;
            return stringBuilder.ToString();
        }
    }
}
