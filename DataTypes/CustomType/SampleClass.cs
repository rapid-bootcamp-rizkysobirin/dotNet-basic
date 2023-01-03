﻿using System;
namespace DataTypes.CustomType
{
    // nama class
    public class SampleClass
    {
        public int dataX;
        public int dataY;

        // contructor
        public SampleClass()
        {
        }

        // contructor
        public SampleClass(int x, int y)
        {
            dataX = x;
            dataY = y;
        }

        public override string ToString()
        {
            return "SampleClass [x :" + dataX + ", y: " + dataY + "]";
        }
    }
}
