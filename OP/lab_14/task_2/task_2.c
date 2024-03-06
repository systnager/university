#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

#define ROWS 5
#define COLS 5

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    double b[ROWS][COLS];

    srand(time(NULL));

    printf("Початковий масив b (випадкові числа від 0 до 9):\n");
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            b[i][j] = (double)(rand() % 10);
            printf("%.2lf ", b[i][j]);
        }
        printf("\n");
    }

    double max_element = b[0][0];
    int max_i = 0, max_j = 0;
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            if (b[i][j] > max_element) {
                max_element = b[i][j];
                max_i = i;
                max_j = j;
            }
        }
    }
    printf("\nМаксимальний елемент: %.2lf, індекси: [%d][%d]\n", max_element, max_i, max_j);
    double min_element = b[0][0];
    int min_i = 0, min_j = 0;
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            if (b[i][j] < min_element) {
                min_element = b[i][j];
                min_i = i;
                min_j = j;
            }
        }
    }
    printf("Мінімальний елемент: %.2lf, індекси: [%d][%d]\n", min_element, min_i, min_j);
    printf("Середньоарифметичні значення елементів кожного рядка:\n");
    for (int i = 0; i < ROWS; i++) {
        double sum = 0.0;
        for (int j = 0; j < COLS; j++) {
            sum += b[i][j];
        }
        double average = sum / COLS;
        printf("Рядок %d: %.2lf\n", i, average);
    }
    double diagonal_product = 1.0;
    for (int i = 0; i < ROWS; i++) {
        diagonal_product *= b[i][i];
    }
    printf("Добуток елементів головної діагоналі: %.2lf\n", diagonal_product);
    double diagonal_sum = 0.0;
    for (int i = 0; i < ROWS; i++) {
        diagonal_sum += b[i][i];
    }
    printf("Сума елементів головної діагоналі: %.2lf\n", diagonal_sum);
    double below_diagonal_sum = 0.0;
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            if (i > j) {
                below_diagonal_sum += b[i][j];
            }
        }
    }
    printf("Сума елементів під головною діагоналлю: %.2lf\n", below_diagonal_sum);

    return 0;
}
