#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

char* decimalToBinary(char* decimalString) {
    unsigned int number = atoi(decimalString);
    int bits = sizeof(int) * 8;
    char* binaryString = (char*)malloc(bits + 1);

    if (binaryString == NULL) {
        printf("Помилка виділення пам'яті.\n");
        exit(EXIT_FAILURE);
    }

    binaryString[bits] = '\0';
    for (int i = bits - 1; i >= 0; i--) {
        binaryString[i] = (number & 1) ? '1' : '0';
        number >>= 1;
    }

    return binaryString;
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    char decimalString[50];
    printf("Введіть десяткове число: ");
    scanf_s("%s", decimalString, sizeof(decimalString));

    char* binaryResult = decimalToBinary(decimalString);

    printf("Двійковий запис числа %s: %s\n", decimalString, binaryResult);

    free(binaryResult);

    return 0;
}

