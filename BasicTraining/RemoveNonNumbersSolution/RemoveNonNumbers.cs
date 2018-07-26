using System;
using System.Text;

namespace RemoveNonNumbersSolution
{
    public static class RemoveNonNumbers
    {
        public static int Remove(string removeFrom)
        {
            if(removeFrom == null)
            {
                throw new ArgumentNullException();
            }


            StringBuilder sb = new StringBuilder();

            foreach(char c in removeFrom)
            {
                if (char.IsNumber(c))
                {
                    sb.Append(c.ToString());
                }
            }

            if(sb.Length == 0)
            {
                throw new InvalidCastException();
            }

            try
            {
                return Convert.ToInt32(sb.ToString());
            } catch (OverflowException)
            {
                throw new InvalidCastException();
            }

            
        }
    }
}
