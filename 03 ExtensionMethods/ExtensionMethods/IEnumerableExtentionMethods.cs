namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Implement a set of extension methods for IEnumerable<T> that implement 
    //the following group functions: sum, product, min, max, average
    public static class IEnumerableExtentionMethods
    {
        public static decimal MySum<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            IfEmptyTrowException<T>(collection);

            var result = collection
                .Select(x => Convert.ToDecimal(x))
                .Sum();

            return result;
        }
                
        private static void IfEmptyTrowException<T>(IEnumerable<T> collection) where T : IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("This collection is Empty");
            }
        }

        public static decimal Product<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            IfEmptyTrowException<T>(collection);

            var decimalCollection = collection
                .Select(x => Convert.ToDecimal(x));

            decimal result = 1;
            foreach (var number in decimalCollection)
            {
                result *= number;                                
            }

            return result;
        }

        public static decimal MyMin<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            IfEmptyTrowException<T>(collection);

            var decimalCollection = collection.Select(x => Convert.ToDecimal(x));

            var result = decimalCollection.FirstOrDefault();

            foreach (var item in decimalCollection)
            {
                if (result > item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static decimal MyMax<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            IfEmptyTrowException(collection);

            //convert collection to decimal
            var decimalCollection = collection.Select(x => Convert.ToDecimal(x));

            decimal result = decimalCollection.FirstOrDefault();
            foreach (var item in decimalCollection)
            {
                if (result < item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static decimal MyAvarage<T>(this IEnumerable<T> collection) where T : IConvertible
        {
            decimal result = collection.MySum() / collection.Count();

            return result;
        }
    }
}
