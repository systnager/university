#include <stdio.h>
#include <windows.h>

#define ROWS 5
#define COLS 5

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int matrix[ROWS][COLS];

    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            matrix[i][j] = 2 * i * j - i;
        }
    }

    printf("Згенерований двовимірний масив:\n");
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            printf("%4d ", matrix[i][j]);
        }
        printf("\n");
    }

    int product = 1;
    for (int j = 0; j < COLS; j++) {
        product *= matrix[4][j];
    }

    printf("\nДобуток елементів п'ятого рядка: %d\n", product);

    return 0;
}
