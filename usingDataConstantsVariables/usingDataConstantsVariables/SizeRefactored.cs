using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace usingDataConstantsVariables
{
    class SizeRefactored
    {

        static void Main(string[] args)
        {
        }

        public static Size GetRotatedSize(Size initialSize, double angleOfRotating)
        {
            double newCosWidthSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.width;
            double newSinHeightSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.height;
            double newSinWidthSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.width;
            double newCosHeightSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.height;
            double fullWidthSize = newCosWidthSize + newSinWidthSize;
            double fullHeightSize = newCosHeightSize + newSinHeightSize;
            Size newSize = new Size(fullWidthSize, fullHeightSize);
            return newSize;
        }
    }
}
