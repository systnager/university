#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

void findMinElementIndex(int matrix[][100], int rows, int cols, int* minRowIndex, int* minColIndex) {
    int minElement = matrix[0][0];
    *minRowIndex = 0;
    *minColIndex = 0;

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (matrix[i][j] < minElement) {
                minElement = matrix[i][j];
                *minRowIndex = i;
                *minColIndex = j;
            }
        }
    }
}

void compressMatrix(int matrix[][100], int rows, int cols, int minRowIndex, int minColIndex) {
    for (int i = minRowIndex; i < rows - 1; i++) {
        for (int j = 0; j < cols; j++) {
            matrix[i][j] = matrix[i + 1][j];
        }
    }
    rows--;

    for (int j = minColIndex; j < cols - 1; j++) {
        for (int i = 0; i < rows; i++) {
            matrix[i][j] = matrix[i][j + 1];
        }
    }
    cols--;

    printf("\n”щ≥льнена матриц€ п≥сл€ вилученн€ р€дка та стовпц€ з м≥н≥мальним елементом:\n");
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
    }
}

int main() {
    int rows, cols;
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    printf("¬вед≥ть к≥льк≥сть р€дк≥в та стовпц≥в (розд≥лен≥ проб≥лом): ");
    scanf_s("%d %d", &rows, &cols);

    if (rows > 100 || cols > 100) {
        printf("ѕеревищено максимальний розм≥р матриц≥.\n");
        return 1;
    }

    int matrix[100][100];

    srand(time(NULL));
    printf("ѕочаткова матриц€:\n");
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            matrix[i][j] = rand() % 9 + 1;
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
    }

    int minRowIndex, minColIndex;
    findMinElementIndex(matrix, rows, cols, &minRowIndex, &minColIndex);
    compressMatrix(matrix, rows, cols, minRowIndex, minColIndex);

    return 0;
}
