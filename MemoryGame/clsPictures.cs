using System;

namespace MemoryGame
{
    class clsPictures
    {
        Random random; 

        public clsPictures()
        {
            random = new Random(); 
        }

        
        internal string[] shuffleArray(string[] items)
        {
            int number; 
            string temp; 

            for (int y = 0; y < items.Length; y++)
            {
                number = random.Next(23); 

                temp = items[y];
                items[y] = items[number];
                items[number] = temp;
            }

            return items;
        }
    }
}
