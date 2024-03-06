#include <stdio.h>
#include <windows.h>

float average(int n);

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int n;
    printf("Введіть кількість чисел у послідовності: ");
    scanf_s("%d", &n);

    if (n <= 0) {
        printf("Кількість чисел повинна бути більше 0.\n");
        return 1;
    }

    float result = average(n);
    printf("Середнє значення послідовності: %.2f\n", result);

    return 0;
}

float average(int n) {
    float sum = 0;
    float num;

    printf("Введіть %d чисел:\n", n);
    for (int i = 0; i < n; ++i) {
        scanf_s("%f", &num);
        sum += num;
    }

    return sum / n;
}
