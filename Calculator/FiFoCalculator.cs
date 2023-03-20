namespace Calculator
{
    public class FiFoCalculator
    {
        private static bool empty = true;
        private static int head = 0;
        private static int tail = 0;
        public static bool isEmpty(Array[] array)
        {
            if(tail == head)
            {
                empty = true;
            }
            else
            {
                empty = false;
            }
            return empty;
        }

        public static Array[] pull(Array[] array)
        {
            if (head > 0)
            {
                
                head = head - 1;
            }
            return array;
        }

        public static Array[] push(int v, Array[] array)
        {
            if (tail < array.Length)
            {
                tail = tail + 1;
                //array.SetValue(v, tail);
                
            }
            return array;
        }






        /*public bool isEmpty()
{
   return true;
}*/
        public int[] populateArray(int[] array)
        {
           
            /*for (int i = 0; i <= array.Length; i++) 
            {
                array[i] = i;
            }*/

            return array;
        }
    }
}