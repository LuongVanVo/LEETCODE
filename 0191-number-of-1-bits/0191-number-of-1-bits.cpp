class Solution {
public:
    int hammingWeight(int n) {
        int count = 0;
        // phương pháp hamming weight O(k) k là số bit 1 của n, mỗi lần sẽ tìm và xóa bit 1 bên phải nhất của số và đếm nó 
        while(n != 0) {
            count++;
            n = n & (n - 1);
        }
        return count;
    }
};