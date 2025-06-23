#include <stdio.h>

int factorial_iter(int n) {
    int result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

int factorial_rec(int n) {
    if (n == 0) return 1;
    return n * factorial_rec(n - 1);
}

int main() {
    int n;
    printf("Enter n for Factorial: ");
    scanf("%d", &n);

    printf("Factorial (Iterative): %d\n", factorial_iter(n));
    printf("Factorial (Recursive): %d\n", factorial_rec(n));

    return 0;
}
