namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    //Implement an extension method Substring(int index, int length) 
        //for the class StringBuilder that returns new StringBuilder
        //and has the same functionality as Substring in the class String.

    public static class StringBuilderExtention
    {
        
        public static StringBuilder Substring(this StringBuilder stringbuilder, int index, int length)
        {
            var output = new StringBuilder(stringbuilder.ToString().Substring(index, length));
            return output;
        }
        
        public static StringBuilder Substring(this StringBuilder stringbuilder, int index)
        {
            var output = new StringBuilder(stringbuilder.ToString().Substring(index));
            return output;
        }

        public static StringBuilder Substring2(this StringBuilder stringbuilder, int startIndex, int length)
        {
            //нов Stringbuilder, simbolCount, for цикъл от startindex, do lenght
            //Append symbol, count ++, return result
            var result = new StringBuilder();
            int count = 0;

            for (int i = startIndex; count < length; i++)
            {
                result.Append(stringbuilder[i]);
                count++;                
            }

            return result;
        }
    }
}
