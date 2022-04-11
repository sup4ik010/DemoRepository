using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    /// <summary>
    /// Содержит методы для подсчета слов в тексте.
    /// </summary>
    internal class WordCounter
    {
        #region Методы

        /// <summary>
        /// Разделит текст на слова.
        /// </summary>
        /// <param name="text">Текст, который нужно разделить на слова.</param>
        /// <returns>Массив со словами.</returns>
        public string[] SplitWords(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Параметр не может быть null.", nameof(text));
            }

            var words = new List<string>();
            var wordLength = 0;
            var i = 0;

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
        /// Считает частоту слов в массиве.
        /// </summary>
        /// <param name="allWords">Массив со словами.</param>
        /// <returns>Массив со словами и частотами.</returns>
        public Dictionary<string,int> CountWords(string[] allWords)
        {
            if (allWords == null)
            {
                throw new ArgumentNullException("Параметр не может быть null.", nameof(allWords));
            }

            var words = new Dictionary<string, int>();
            var isThereWord = new bool[allWords.Length];

            for (var i = 0; i < allWords.Length; i++)
            {
                if (!isThereWord[i])
                {
                    words.Add(allWords[i], 1);
                    isThereWord[i] = true;

                    for (var j = i; j < allWords.Length; j++)
                    {
                        if (!isThereWord[j] && words.ElementAt(words.Count() - 1).Key.ToLower() == allWords[j].ToLower())
                        {
                            words[words.ElementAt(i).Key] ++;
                            isThereWord[j] = true;
                        }
                    }
                }
            }

            return words;
        }

        #endregion
    }
}