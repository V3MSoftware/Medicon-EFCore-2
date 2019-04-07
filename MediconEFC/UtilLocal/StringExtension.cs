using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Medicon.UtilLocal
{
    static public class StringExtension
    {
        public static DateTime RetornarPropriaDataOuDataAtual(this string data)
        {
            DateTime dataRetorno = new DateTime();
            DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataRetorno);
            if (dataRetorno == DateTime.MinValue) return DateTime.Now.Date;
            return dataRetorno;
        }

        public static string RetirarPontosTracosBarraParenteses(this string texto)
        {
            return texto.Replace(".", "").Replace("-", "").Replace("/", "").Replace(")", "").Replace("(", "");
        }


        /// <summary>
        /// 	Determines whether the specified string is null or empty.
        /// </summary>
        /// <param name = "value">The string value to check.</param>
        public static bool IsEmpty(this string value)
        {
            return ((value == null) || (value.Length == 0));
        }

        /// <summary>
        /// 	Determines whether the specified string is not null or empty.
        /// </summary>
        /// <param name = "value">The string value to check.</param>
        public static bool IsNotEmpty(this string value)
        {
            return (value.IsEmpty() == false);
        }


        /// <summary>
        /// Determines whether [is not null or empty] [the specified input].
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if [is not null or empty] [the specified input]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNotNullOrEmpty(this string input)
        {
            return !String.IsNullOrEmpty(input);
        }

        /// <summary>
        /// 	Trims the text to a provided maximum length.
        /// </summary>
        /// <param name = "value">The input string.</param>
        /// <param name = "maxLength">Maximum length.</param>
        /// <returns></returns>
        /// <remarks>
        /// 	Proposed by Rene Schulte
        /// </remarks>
        public static string TrimToMaxLength(this string value, int maxLength)
        {
            return (value == null || value.Length <= maxLength ? value : value.Substring(0, maxLength));
        }

        /// <summary>
        /// 	Determines whether the comparison value strig is contained within the input value string
        /// </summary>
        /// <param name = "inputValue">The input value.</param>
        /// <param name = "comparisonValue">The comparison value.</param>
        /// <param name = "comparisonType">Type of the comparison to allow case sensitive or insensitive comparison.</param>
        /// <returns>
        /// 	<c>true</c> if input value contains the specified value, otherwise, <c>false</c>.
        /// </returns>
        public static bool Contains(this string inputValue, string comparisonValue, StringComparison comparisonType)
        {
            return (inputValue.IndexOf(comparisonValue, comparisonType) != -1);
        }

        /// <summary>
        /// 	Extracts all digits from a string.
        /// </summary>
        /// <param name = "value">String containing digits to extract</param>
        /// <returns>
        /// 	All digits contained within the input string
        /// </returns>
        /// <remarks>
        /// 	Contributed by Kenneth Scott
        /// </remarks>

        public static string ExtractDigits(this string value)
        {
            return value.Where(Char.IsDigit).Aggregate(new StringBuilder(value.Length), (sb, c) => sb.Append(c)).ToString();
        }

        /// <summary>
        /// 	Tests whether the contents of a string is a numeric value
        /// </summary>
        /// <param name = "value">String to check</param>
        /// <returns>
        /// 	Boolean indicating whether or not the string contents are numeric
        /// </returns>
        /// <remarks>
        /// 	Contributed by Kenneth Scott
        /// </remarks>
        public static bool IsNumeric(this string value)
        {
            float output;
            return float.TryParse(value, out output);
        }

        public static bool IsDecimal(this string _valor)
        {
            decimal output;
            return decimal.TryParse(_valor, out output);
        }

        public static bool IsDecimalDuasCasas(this string _valor)
        {
            return Regex.IsMatch(_valor.Trim(), @"^\d+\,\d{2,2}$");
        }

        public static bool IsDate(this string _valor)
        {
            DateTime output;
            return DateTime.TryParse(_valor, out output);
        }

        public static bool IsByte(this string _valor)
        {
            Byte output;
            return byte.TryParse(_valor, out output);
        }

        public static bool IsUTF8(this String _valor)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(_valor);
            string novoValor = Encoding.UTF8.GetString(bytes);

            return _valor.Equals(novoValor);
        }

        public static string ToIEFormat(this string str)
        {
            if (String.IsNullOrEmpty(str)) return String.Empty;
            if (str.Length != 12) return str;

            UInt64 tmp;
            if (UInt64.TryParse(str, out tmp))
                return tmp.ToString(@"000\.000\.000\.000");
            else
                return str;
        }

        public static string ToCnpjFormat(this string str)
        {
            if (String.IsNullOrEmpty(str)) return String.Empty;
            if (str.Length != 14) return str;

            UInt64 tmp;
            if (UInt64.TryParse(str, out tmp))
                return tmp.ToString(@"00\.000\.000\/0000\-00");
            else
                return str;
        }

        public static string ToCnaeFormat(this string str)
        {
            if (String.IsNullOrEmpty(str)) return String.Empty;
            if (str.Length != 7) return str;

            UInt64 tmp;
            if (UInt64.TryParse(str, out tmp))
                return tmp.ToString(@"0000\-0\/00");
            else
                return str;
        }

        public static string ToPhoneFormat(this string str)
        {
            if (String.IsNullOrEmpty(str))
                return String.Empty;

            if (str.Length < 4)
                return str;

            return str.Insert(str.Length - 4, "-");
        }
    }
}