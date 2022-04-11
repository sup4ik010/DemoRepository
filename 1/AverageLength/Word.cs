using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLength
{
    /// <summary>
    /// Содержит методы для подсчета средней длины слова.
    /// </summary>
    internal class Word
    {
        /// <summary>
        /// Разделит текст на слова.
        /// </summary>
        /// <param name="text">Текст, который нужно разделить на слова.</param>
        /// <returns>Массив со словами.</returns>
        public string[] SplitWords(string text)
        {
            var words = new List<string>();
            var wordLength = 0;
            int i;

            for (i = 0; i < text.Length; i++)
            {
                if (wordLength != 0)
                {
                    if (Char.IsPunctuation(text[i]))
                    {
                        words.Add(text.Substring(i - wordLength, wordLength));
                        wordLength = 0;
                        i++;
                    }
                    else if (Char.IsWhiteSpace(text[i]))
                    {
                        words.Add(text.Substring(i - wordLength, wordLength));
                        wordLength = 0;
                    }
                    else
                    {
                        wordLength++;
                    }
                }
                else if (!Char.IsWhiteSpace(text[i]) && !Char.IsPunctuation(text[i]))
                {
                    wordLength++;
                }
            }

            if (!Char.IsPunctuation(text[text.Length - 1]))
            {
                words.Add(text.Substring(i - wordLength, wordLength));
            }

            return words.ToArray();
        }

        /// <summary>
        /// Вернет среднюю длину слова в массиве.
        /// </summary>
        /// <param name="words">Массив со словами</param>
        /// <returns>Средняя длина слова.</returns>
        public double FindAverage(string[] words)
        {
            var sum = 0.0;

            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }

            return sum / words.Length;
        }
    }
}