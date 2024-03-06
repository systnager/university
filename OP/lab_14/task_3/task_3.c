#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

#define N 5
#define M 5

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int nim_n, nim_m;
    do {
        printf("Введіть кількість рядків (n < %d): ", N);
        scanf_s("%d", &nim_n);
    } while (nim_n <= 0 || nim_n >= N);

    do {
        printf("Введіть кількість стовпців (m < %d): ", M);
        scanf_s("%d", &nim_m);
    } while (nim_m <= 0 || nim_m >= M);

    int array[N][M];
    int a, b;
    printf("Введіть інтервал [a, b] для генерації випадкових чисел (a < b):\n");
    printf("a: ");
    scanf_s("%d", &a);
    printf("b: ");
    scanf_s("%d", &b);
    srand(time(NULL));
    printf("\nПочатковий масив:\n");
    for (int i = 0; i < nim_n; i++) {
        for (int j = 0; j < nim_m; j++) {
            array[i][j] = rand() % (b - a + 1) + a;
            printf("%3d ", array[i][j]);
        }
        printf("\n");
    }
    int max_sum_row = 0;
    int max_sum = 0;

    for (int i = 0; i < nim_n; i++) {
        int sum = 0;
        for (int j = 0; j < nim_m; j++) {
            sum += abs(array[i][j]);
        }
        if (sum > max_sum) {
            max_sum = sum;
            max_sum_row = i;
        }
    }

    printf("\nНомер рядка з максимальною за модулем сумою елементів: %d\n", max_sum_row + 1);

    return 0;
}
