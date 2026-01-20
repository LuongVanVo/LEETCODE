class Solution {
public:
    string intToRoman(int num) {
        // 1 <= num <= 3999 => Có tối đa 4 chữ số
        string Roman[4][10] = {
            {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
            {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
            {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
            {"", "M", "MM", "MMM"}
        };
        return Roman[3][num/1000] + Roman[2][(num%1000) / 100] + Roman[1][(num%100) / 10] + Roman[0][num%10];
    }
};