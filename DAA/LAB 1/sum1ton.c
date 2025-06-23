#include <stdio.h>

int sum_iter(int n) {
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    return sum;
}

int sum_rec(int n) {
    if (n == 0) return 0;
    return n + sum_rec(n - 1);
}

int main() {
    int n;
    printf("Enter n to calculate sum from 1 to n: ");
    scanf("%d", &n);

    printf("Sum (Iterative): %d\n", sum_iter(n));
    printf("Sum (Recursive): %d\n", sum_rec(n));

    return 0;
}
