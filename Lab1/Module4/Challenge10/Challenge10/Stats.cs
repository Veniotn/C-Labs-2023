﻿using System;
using System.Collections.Generic;
using System.Text;

//event handling challenge
namespace Challenge10
{
    public class Stats
    {
        public void Start()
        {
            Challenge10.Posted += HasPosted;
        }

        void HasPosted()
        {
            Console.WriteLine("Survey posted, run stats");
        }
    }
}

