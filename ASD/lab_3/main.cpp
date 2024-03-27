#include <cstdio>
#include <cstdlib>
#include <ctime>

int compare(const void *a, const void *b) {
    return (*(int *)b - *(int *)a);
}

long long int findLargestNumber(int binaryDigits[], int size) {
    qsort(binaryDigits, size, sizeof(int), compare);

    long long int largestNumber = 0;
    for (int i = 0; i < size; i++) {
        largestNumber = largestNumber * 10 + binaryDigits[i];
    }

    return largestNumber;
}

int main() {
    struct timespec start{}, end{};
    double time_spent;

    for (int m = 1; m <= 40; m++) {
        clock_gettime(CLOCK_MONOTONIC, &start);
        int binaryDigits[m];

        srand(time(NULL));
        for (int i = 0; i < m; i++) {
            binaryDigits[i] = rand() % 2;
        }
        long long int result = findLargestNumber(binaryDigits, m);

        clock_gettime(CLOCK_MONOTONIC, &end);
        time_spent = (end.tv_sec - start.tv_sec) + (end.tv_nsec - start.tv_nsec) / 1e9;
        printf("%f\n", time_spent);
    }

    return 0;
}
