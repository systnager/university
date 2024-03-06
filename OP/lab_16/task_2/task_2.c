#include <stdio.h>

int calculate_sum(int arr[], int size) {
    int sum = 0;
    for (int i = 0; i < size; i++) {
        sum += arr[i];
    }
    return sum;
}

int find_max(int arr[], int size) {
    int max = arr[0];
    for (int i = 1; i < size; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}

int find_min(int arr[], int size) {
    int min = arr[0];
    for (int i = 1; i < size; i++) {
        if (arr[i] < min) {
            min = arr[i];
        }
    }
    return min;
}

long long calculate_product(int arr[], int size) {
    long long product = 1;
    for (int i = 0; i < size; i++) {
        product *= arr[i];
    }
    return product;
}

int main() {
    int array[] = { 5, 2, 8, 1, 6, 4 };
    int size = sizeof(array) / sizeof(array[0]);

    int sum = calculate_sum(array, size);
    int max = find_max(array, size);
    int min = find_min(array, size);
    long long product = calculate_product(array, size);

    printf("Sum of elements: %d\n", sum);
    printf("Maximum element: %d\n", max);
    printf("Minimum element: %d\n", min);
    printf("Product of elements: %lld\n", product);

    return 0;
}
