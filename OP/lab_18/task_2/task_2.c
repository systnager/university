#include <stdio.h>

void convertToBase(int num, int base) {
    if (num == 0) {
        return;
    }
    convertToBase(num / base, base);
    printf("%d", num % base);
}

int main() {
    int number, radix;

    printf("Enter a number: ");
    scanf_s("%d", &number);

    do {
        printf("Enter the radix (between 2 and 8): ");
        scanf_s("%d", &radix);
    } while (radix < 2 || radix > 8);

    printf("Number %d in base-%d: ", number, radix);
    if (number == 0) {
        printf("0");
    }
    else {
        convertToBase(number, radix);
    }
    printf("\n");
    printf("########################################");
    printf("\n");

    int temp, i = 0;
    int result[100];

    printf("Enter a number: ");
    scanf_s("%d", &number);

    do {
        printf("Enter the radix (between 2 and 8): ");
        scanf_s("%d", &radix);
    } while (radix < 2 || radix > 8);

    temp = number;
    if (number == 0) {
        printf("Number 0 in base-%d: 0\n", radix);
        return 0;
    }

    while (temp != 0) {
        result[i++] = temp % radix;
        temp /= radix;
    }

    printf("Number %d in base-%d: ", number, radix);
    for (int j = i - 1; j >= 0; j--) {
        printf("%d", result[j]);
    }
    printf("\n");


    return 0;
}

