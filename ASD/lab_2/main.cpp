#include <cstdio>
#include <cmath>

#define A 48271
#define C 0
#define M (2147483647) // 2**31 - 1

int pseudo_random(int *seed) {
    *seed = (A * (*seed) + C) % M;
    return *seed;
}

int main() {
    int n = 100;
    int K = 10000;
    int seed = 1;

    int frequencies[n];
    for (int i = 0; i < n; i++) {
        frequencies[i] = 0;
    }

    for (int i = 0; i < K; i++) {
        int random_number = pseudo_random(&seed) % n;
        frequencies[random_number]++;
    }

    printf("Frequency of each number:\n");
    for (int i = 0; i < n; i++) {
        printf("%d: %d\n", i, frequencies[i]);
    }

    double probability = 1.0 / K;
    printf("\nStatistical probability: %lf\n", probability);

    double mean = 0;
    for (int i = 0; i < n; i++) {
        mean += i * probability;
    }
    printf("Mean: %lf\n", mean);

    double variance = 0;
    for (int i = 0; i < n; i++) {
        variance += pow(i - mean, 2) * probability;
    }
    printf("Variance: %lf\n", variance);

    double standard_deviation = sqrt(variance);
    printf("Standard deviation: %lf\n", standard_deviation);

    return 0;
}
