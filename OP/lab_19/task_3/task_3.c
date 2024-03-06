#include <stdio.h>
#include <stdlib.h>
#include <time.h>
int K = 3;

void deleteElement(int** arr, int* size, int position) {
    if (position >= 0 && position < *size) {
        int* temp = *arr;
        for (int i = position; i < *size - 1; ++i) {
            *(temp + i) = *(temp + i + 1);
        }
        (*size)--;
    }
    else {
        printf("Invalid position to delete.\n");
    }
}

void addZeroAfterEven(int** arr, int* size) {
    int* new_arr = (int*)malloc(*size * sizeof(int) * 2);
    int zero_count = 0;
    for (int i = 0; i < *size; i++) {
        *(new_arr + i + zero_count) = *(*arr + i);
        if (*(*arr + i) % 2 == 0) {
            *(new_arr + i + ++zero_count) = 0;
        }
    }
    printf("\nArray after deleting element at position %d and adding 0 after each even element:\n", K);
    for (int i = 0; i < *size + zero_count; i++) {
        printf("%d ", *(new_arr + i ));
    }
}

int main() {
    srand(time(NULL));

    int size = 10;
    int* arr = (int*)malloc(size * sizeof(int));
    if (arr == NULL) {
        printf("Memory allocation failed.\n");
        return -1;
    }

    int* ptr = arr;
    for (int i = 0; i < size; ++i) {
        *ptr = rand() % 10;
        printf("%d ", *ptr);
        ++ptr;
    }
    deleteElement(&arr, &size, K);
    addZeroAfterEven(&arr, &size);
    return 0;
}
