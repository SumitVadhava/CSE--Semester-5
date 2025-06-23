#include <stdio.h>

int fibonacci_iter(int n) {
    if (n == 0) return 0;
    int a = 0, b = 1, temp;
    for (int i = 2; i <= n; i++) {
        temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}

int fibonacci_rec(int n) {
    if (n == 0) return 0;
    if (n == 1) return 1;
    return fibonacci_rec(n - 1) + fibonacci_rec(n - 2);
}

int main() {
    int n;
    printf("Enter n for Fibonacci: ");
    scanf("%d", &n);

    printf("Fibonacci (Iterative): %d\n", fibonacci_iter(n));
    printf("Fibonacci (Recursive): %d\n", fibonacci_rec(n));

    return 0;
}
