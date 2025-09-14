class Solution {
public:
    int climbStairs(int n) {
        // quy hoach dong
        if (n == 0) {
            return 0;
        }
        int F[100];
        F[0] = 0; F[1] = 1; F[2] = 2;
        for (int i = 3; i <= n; i++) {
            F[i] = F[i - 1] + F[i - 2];
        }
        return F[n];
    }
};