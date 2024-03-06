#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

void findMaxElement(int** array, int rows, int cols, int* max_row, int* max_col) {
    int max = array[0][0];
    *max_row = 0;
    *max_col = 0;

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (array[i][j] > max) {
                max = array[i][j];
                *max_row = i;
                *max_col = j;
            }
        }
    }
}

void deleteRowAndColumn(int*** array, int rows, int cols, int row, int col) {
    for (int i = row; i < rows - 1; i++) {
        (*array)[i] = (*array)[i + 1];
    }
    (*array) = (int**)realloc((*array), (rows - 1) * sizeof(int*));

    for (int i = 0; i < rows - 1; i++) {
        for (int j = col; j < cols - 1; j++) {
            (*array)[i][j] = (*array)[i][j + 1];
        }
        (*array)[i] = (int*)realloc((*array)[i], (cols - 1) * sizeof(int));
    }
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int rows, cols;
    printf("¬вед≥ть к≥льк≥сть р€дк≥в ≥ стовпц≥в: ");
    scanf_s("%d %d", &rows, &cols);

    int** array = (int**)malloc(rows * sizeof(int*));
    for (int i = 0; i < rows; i++) {
        array[i] = (int*)malloc(cols * sizeof(int));
    }

    printf("¬вед≥ть елементи масиву:\n");
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            scanf_s("%d", &array[i][j]);
        }
    }

    int max_row, max_col;
    findMaxElement(array, rows, cols, &max_row, &max_col);

    printf("ћаксимальний елемент: %d\n", array[max_row][max_col]);
    deleteRowAndColumn(&array, rows, cols, max_row, max_col);
    printf("«м≥нений масив п≥сл€ видаленн€ р€дка та стовпц€:\n");
    for (int i = 0; i < rows - 1; i++) {
        for (int j = 0; j < cols - 1; j++) {
            printf("%d ", array[i][j]);
        }
        printf("\n");
    }

    for (int i = 0; i < rows - 1; i++) {
        free(array[i]);
    }
    free(array);

    return 0;
}
