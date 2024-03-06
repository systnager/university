#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

#define ROWS 5
#define COLS 5

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int array[ROWS][COLS];
    int sum = 0;
    srand(time(NULL));
    printf("Згенерований масив 5x5 випадкових чисел від 1 до 9:\n");
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            array[i][j] = rand() % 9 + 1;
            printf("%d ", array[i][j]);
        }
        printf("\n");
    }

    sum += array[0][4] + array[1][4] + array[1][3] + array[2][0] + array[2][1] + array[2][2] + array[2][3] + array[2][4] + array[3][0] + array[3][1] + array[4][0];

    printf("\nСума елементів: %d\n", sum);

    return 0;
}
