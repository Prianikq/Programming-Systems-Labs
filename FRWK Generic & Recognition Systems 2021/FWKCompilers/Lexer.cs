using System;
using System.Collections.Generic;
using System.Collections;

namespace Translator
{
     
    /// Абстрактный класс лексического анализатора
 /*   
    abstract class Lexer
    {
        /// Парсинг строки в список токенов
        public abstract List<SDTSymbol> Parse(string _);
    }

    /// Простой лексический анализатор
    
     //  Токен создается для каждого символа строки
     
    class SimpleLexer : Lexer
    {
        public override List<SDTSymbol> Parse(string str)
        {
            List<SDTSymbol> result = new List<SDTSymbol>();
            foreach (char c in str)
            {
                result.Add(new SDTSymbol(c.ToString()));
            }
            return result;
        }
    }

    /// Лексический анализатор для арифметических выражений c положительными целыми числами
    
     //  Числа преобразуются в токен с именем number и атрибутом value, который содержит числовое значение.
     // Для остальных символов создаются токены со значением в один символ и без атрибутов.
     
    class ArithmLexer : Lexer
    {
        public override List<SDTSymbol> Parse(string str)
        {
            List<SDTSymbol> result = new List<SDTSymbol>();
            for (int i = 0; i < str.Length; ++i)
            {
                if (Char.IsDigit(str[i]))
                {
                    int value = 0;
                    while (i < str.Length && Char.IsDigit(str[i]))
                    {
                        value = value * 10 + str[i] - '0';
                        ++i;
                    }
                    result.Add(new Dictionary<string, object>() { ["NAME"] = "number", ["value"] = value });
                }
                if (i < str.Length)
                {
                    result.Add(new SDTSymbol(str[i].ToString()));
                }
            }
            return result;
        }
    }
  */
}