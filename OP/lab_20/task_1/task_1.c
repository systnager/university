#include <stdio.h>
#include <windows.h>

#define ROWS 4
#define COLS 4

void findZeroElements(int matrix[ROWS][COLS]) {
    int* ptr = (int*)matrix;

    printf("Адреси елементів матриці, що дорівнюють 0:\n");

    for (int i = 0; i < ROWS * COLS; i++) {
        if (*(ptr + i) == 0) {
            int row = i / COLS;
            int col = i % COLS;
            printf("Елемент [%d][%d]: Адреса - %p\n", row, col, (void*)(ptr + i));
        }
    }
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int matrix[ROWS][COLS] = {
        {1, 0, 3, 4},
        {0, 6, 7, 8},
        {9, 10, 0, 12},
        {13, 14, 15, 0}
    };

    findZeroElements(matrix);

    return 0;
}
