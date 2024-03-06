#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#define n 5

void sortDescending(int arr[]) {
    int temp;
    for (int i = 0; i < n - 1; i++) {
        for (int j = i + 1; j < n; j++) {
            if (arr[i] < arr[j]) {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int matrix[n][n];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            matrix[i][j] = rand() % 10;
        }
    }

    printf("Початкова матриця:\n");
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
    }

    int columns_to_sort[] = { 0, 1, 2, 3, 4 };

    for (int k = 0; k < sizeof(columns_to_sort) / sizeof(columns_to_sort[0]); k++) {
        int col_index = columns_to_sort[k];
        int column_values[n];

        for (int i = 0; i < n; i++) {
            column_values[i] = matrix[i][col_index];
        }

        sortDescending(column_values, n);

        for (int i = 0; i < n; i++) {
            matrix[i][col_index] = column_values[i];
        }
    }

    printf("\nМатриця після сортування вказаних стовпців у порядку спадання:\n");
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
    }

    return 0;
}
