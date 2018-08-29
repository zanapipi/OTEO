using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

namespace OteoModel.Classes
{
    public static class DataReaderExtension
    {

        public static bool Fetch(this DbDataReader idr)
        {
            return idr != null && idr.HasRows && idr.Read();
        }

        public static object GetValue(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetValue(ordinal) : null;
        }

        public static string GetString(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetString(ordinal) : string.Empty;
        }

        public static short GetShort(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetInt16(ordinal) : short.MinValue;
        }

        public static short? GetNullableShort(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetInt16(ordinal);
            }
            return null;
        }

        public static int GetInt(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetInt32(ordinal) : int.MinValue;
        }

        public static int? GetNullableInt(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetInt32(ordinal);
            }
            return null;
        }

        public static long GetLong(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetInt64(ordinal) : long.MinValue;
        }

        public static long? GetNullableLong(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetInt64(ordinal);
            }
            return null;
        }

        public static float GetFloat(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetFloat(ordinal) : float.MinValue;
        }

        public static float? GetNullableFloat(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetFloat(ordinal);
            }
            return null;
        }

        public static double GetDouble(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetDouble(ordinal) : double.MinValue;
        }

        public static double? GetNullableDouble(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetDouble(ordinal);
            }
            return null;
        }

        public static decimal GetDecimal(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetDecimal(ordinal) : decimal.MinValue;
        }

        public static decimal? GetNullableDecimal(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetDecimal(ordinal);
            }
            return null;
        }

        public static bool GetBool(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) && Convert.ToBoolean(idr.GetBoolean(ordinal));
        }

        public static bool? GetNullableBool(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return Convert.ToBoolean(idr.GetBoolean(ordinal));
            }
            return null;
        }

        public static DateTime GetDateTime(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? idr.GetDateTime(ordinal) : DateTime.MinValue;
        }

        public static DateTime? GetNullableDateTime(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            if (!idr.IsDBNull(ordinal))
            {
                return idr.GetDateTime(ordinal);
            }
            return null;
        }

        public static byte[] GetBlob(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? (byte[])idr[param] : new byte[0];
        }

        public static byte[] GetNullableBlob(this IDataReader idr, string param)
        {
            var ordinal = idr.GetOrdinal(param);
            return !idr.IsDBNull(ordinal) ? (byte[])idr[param] : null;
        }

    }

}