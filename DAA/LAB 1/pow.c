#include <stdio.h>

int power_iter(int a, int b) {
    int result = 1;
    for (int i = 0; i < b; i++)
        result *= a;
    return result;
}

int power_rec(int a, int b) {
    if (b == 0) return 1;
    return a * power_rec(a, b - 1);
}

int main() {
    int a, b;
    printf("Enter base and exponent (a^b): ");
    scanf("%d %d", &a, &b);

    printf("Power (Iterative): %d\n", power_iter(a, b));
    printf("Power (Recursive): %d\n", power_rec(a, b));

    return 0;
}
