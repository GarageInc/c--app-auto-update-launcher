using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLworker.Services
{
    // Не стал писать разбор регуляркой - 
    // это неблагодарный труд - сопровождать регулярные выражения, ошибка в которых может привести к сложно тестируемым Side-эффектам
    class FileService
    {

        public static bool IsRequiredFileName(string fileName)
        {
            var withoutExtension = fileName.Split('.')[0];

            string[] parts = withoutExtension.Split('_');

            return parts.Length == 3 && CheckedByRussian(parts[0], 100) && CheckedByDigits(parts[1], 14, 20, new int[] { 1, 10 }) && CheckedByAnySymbols(parts[2], 7); ;
        }

        protected static bool CheckedByRussian(string part, int maxCount)
        {
            if(!String.IsNullOrEmpty(part) && part.Length <= maxCount)
            {

                for (var i = 0; i<part.Length; i++)
                {
                    if (part[i] < 'А' || part[i] > 'я'){
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        // only one iteration
        protected static bool CheckedByDigits(string part, int lengthFrom, int lengthTo, int[] counts)
        {
            var countDigits = part.Count(symbol => symbol >= '0' && symbol <= '9');

            if(countDigits != part.Length)
            {
                return false;
            }

            if((countDigits > lengthFrom && countDigits < lengthTo) || counts.Any(x=>x == countDigits))
            {
                return true;
            } else
            {
                return false;
            }
        }

        protected static bool CheckedByAnySymbols(string part, int length)
        {
            return !String.IsNullOrEmpty(part) && part.Length <= length;
        }
    }
}
