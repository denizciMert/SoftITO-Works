namespace SoftITO_Works
{
    internal class ManualSum
    {
        private static string ManualSummary(int number1, int number2)
        {
            List<string> resultList = new List<string>();
            string number1Chars = number1.ToString();
            string number2Chars = number2.ToString();
            if (number1Chars.Length > number2Chars.Length)
            {
                number2Chars = number2Chars.PadLeft(number1Chars.Length, '0');
            }
            else if (number2Chars.Length > number1Chars.Length)
            {
                number1Chars = number1Chars.PadLeft(number2Chars.Length, '0');
            }

            int carry = 0;
            for (int i = number1Chars.Length - 1; i >= 0; i--)
            {
                int x1 = number1Chars[i] - '0';
                int x2 = number2Chars[i] - '0';
                int miniSum = x1 + x2 + carry;

                if (miniSum > 9)
                {
                    string miniSumString = miniSum.ToString();
                    string sumPart = miniSumString.Substring(miniSumString.Length - 1, 1);
                    //resultList.Add(sumPart);
                    //carry = miniSum / 10;
                    string carryPart = miniSumString.Substring(0, miniSumString.Length - 1);
                    resultList.Add(sumPart);
                    carry = Convert.ToInt32(carryPart);
                }
                else
                {
                    resultList.Add(miniSum.ToString());
                }
            }

            if (carry > 0)
            {
                resultList.Add(carry.ToString());
            }

            resultList.Reverse();
            string result = string.Join("", resultList);
            return result;
        }
    }
}