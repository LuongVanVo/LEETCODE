using System.Text;

public class Solution {
    public string AddStrings(string num1, string num2) {
        StringBuilder res = new StringBuilder();

        int carry = 0;

        int i = num1.Length - 1; int j = num2.Length - 1;

        while (i >= 0 || j >= 0 || carry != 0)
        {
            int digit1 = (i >= 0) ? num1[i] - '0' : 0;
            int digit2 = (j >= 0) ? num2[j] - '0' : 0;

            int total = digit1 + digit2 + carry;
            carry = total / 10;
            res.Append(total % 10);

            i--; j--;
        }

        char[] resArray = res.ToString().ToCharArray();
        Array.Reverse(resArray);

        string result = new string(resArray);
        return result;
    }
}