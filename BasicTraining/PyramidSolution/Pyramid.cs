using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace PyramidSolution
{
    public class Pyramid
    {
        public const char PyramidBlock = '□';

        public static string Build(int rows)
        {
            if(rows < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int row = 1;
            int width = rows + (rows - 1);
            StringBuilder returnString = new StringBuilder();
            StringBuilder previousRow = new StringBuilder();

            previousRow.Append(PyramidBlock);

            addWhiteSpace(returnString, (width - 1) / 2);
            returnString.Append(PyramidBlock);
            addWhiteSpace(returnString, (width - 1) / 2);

            if (rows == 1)
            {
                return previousRow.ToString();
            } else if(rows == 0)
            {
                return "";
            }

            for(int i = 2; i <= rows; i++)
            {
                int whitespace = (width - (i+(i-1))) / 2;

                previousRow.Append(new string(PyramidBlock, 2));

                returnString.Append(Environment.NewLine);

                addWhiteSpace(returnString, whitespace);
                returnString.Append(previousRow);
                addWhiteSpace(returnString, whitespace);
            }
            
            return returnString.ToString();
        }

        private static StringBuilder addWhiteSpace(StringBuilder stringToPad, int padding)
        {
            for(int i = 1; i <= padding; i++)
            {
                stringToPad.Append(' ');
            }

            return stringToPad;
        }
    }
}
