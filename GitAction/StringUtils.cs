using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAction
{
    public static class StringUtils
    {
        // Разворачивает строку задом наперёд
        public static string Reverse(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return new string(input.Reverse().ToArray());
        }

        // Проверяет, является ли строка палиндромом
        public static bool IsPalindrome(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            var reversed = Reverse(input);
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Считает количество гласных в строке
        public static int CountVowels(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            string vowels = "aeiouAEIOUаеёиоуыэюяАЕЁИОУЫЭЮЯ";
            return input.Count(c => vowels.Contains(c));
        }
    }
}
