using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParolClass
{
    public class ParolValidator
    {
        public int[] ValidatePassword(string password)
        {
            int score = 0;
            int[] testScores = new int[5];

            // 1. Проверка наличия цифр
            if (Regex.IsMatch(password, @"\d"))
            {
                score++;
                testScores[0]++;
            }

            // 2. Проверка наличия строчных букв
            if (Regex.IsMatch(password, "[a-z]"))
            {
                score++;
                testScores[1]++;
            }

            // 3. Проверка наличия заглавных букв
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                score++;
                testScores[2]++;
            }

            // 4. Проверка наличия специальных символов
            if (Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
            {
                score++;
                testScores[3]++;
            }

            // 5. Проверка на длину более 7 символов
            if (password.Length > 7)
            {
                score++;
                testScores[4]++;
            }

            // Возвращаем массив с результатами
            int[] results = new int[6];
            results[5] = score;
            Array.Copy(testScores, 0, results, 0, 5);
            return results;
        }
    }
}

