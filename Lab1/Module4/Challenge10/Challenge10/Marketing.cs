using System;
using System.Collections.Generic;
using System.Text;
//event handling challenge

namespace Challenge10
{
    public class Marketing
    {
        public void Start()
        {
            Challenge10.Posted += Subscribed;
        }

        void Subscribed()
        {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    }
    
}

