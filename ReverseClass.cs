using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLibrary
{
    public class ReverseClass
    {
        /// <summary>
        /// Разворот строки
        /// </summary>
        /// <param name="text">
        /// Входная строка
        /// </param>
        /// <returns>
        /// Возвращает результат разворота
        /// </returns>
        public string ReverseString(string text)
        {
            ////Второй вариант решения
            //StringBuilder sb = new StringBuilder(text.Length);
            //for (int i = text.Length; i-- != 0;)
            //    sb.Append(text[i]);
            //return sb.ToString();

            text = text.ToLower().Replace(" ", "");
            return new string(text.Reverse().ToArray());
        }
        public static bool IsPalindrome(string textString)
        {
           ReverseClass c=new ReverseClass();
            if (string.IsNullOrEmpty(textString))
            {
                return false;
            }
            if (c.ReverseString(textString)== textString.ToLower().Replace(" ", ""))
            {
                
                return true;
            }
            return false;
        }
    }
}
