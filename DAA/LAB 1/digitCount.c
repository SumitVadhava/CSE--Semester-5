#include <stdio.h>

int digit_count_iter(int n) {
    int count = 0;
    if (n == 0) return 1;
    while (n != 0) {
        count++;
        n /= 10;
    }
    return count;
}

int digit_count_rec(int n) {
    if (n == 0) return 0;
    return 1 + digit_count_rec(n / 10);
}

int main() {
    int n;
    printf("Enter a number to count digits: ");
    scanf("%d", &n);

    printf("Digit Count (Iterative): %d\n", digit_count_iter(n));
    printf("Digit Count (Recursive): %d\n", digit_count_rec(n == 0 ? 0 : n));

    return 0;
}
