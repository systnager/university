#include <stdio.h>
#include <windows.h>

void bubbleSort(int arr[], int n) {
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] < arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

void insertionSort(int arr[], int n) {
    int i, key, j;
    for (i = 1; i < n; i++) {
        key = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] < key) {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

void printArray(int arr[], int n) {
    for (int i = 0; i < n; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int rows, cols;

    printf("Введіть кількість рядків та стовпців (розділені пробілом): ");
    scanf_s("%d %d", &rows, &cols);

    int matrix[100][100];

    printf("Введіть елементи матриці:\n");
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            scanf_s("%d", &matrix[i][j]);
        }
    }

    printf("Початкова матриця:\n");
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            printf("%d ", matrix[i][j]);
        }
        printf("\n");
    }

    int tempArray[100 * 100];
    int index = 0;

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            tempArray[index++] = matrix[i][j];
        }
    }

    bubbleSort(tempArray, rows * cols);

    printf("\nВідсортований методом обміну за спаданням:\n");
    printArray(tempArray, rows * cols);

    insertionSort(tempArray, rows * cols);

    printf("\nВідсортований методом вставок за спаданням:\n");
    printArray(tempArray, rows * cols);

    return 0;
}
