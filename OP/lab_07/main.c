#include <stdio.h>


void asd(double x, double y) {
    if (y <= 0 || y >= x + 1 || y <= -x - 1 || y >= 1) {
        printf("True\n");
    } else {
        printf("False\n");
    }
}

void task_1() {
    printf("x = 15, y = 15\n");
    asd(15, 15);

    printf("x = -15, y = -15\n");
    asd(-15, -15);

    printf("x = 15, y = -2\n");
    asd(15, -2);

    printf("x = 0, y = 2\n");
    asd(0, 2);

    printf("x = 0, y = 0.5\n");
    asd(0, 0.5);
}

void task_2() {
    int inputNumber;

    printf("Enter Number:");
    scanf("%d", &inputNumber);

    printf("Entered number %d %s 0\n%d %s 4\n%d %s 8\n%d %s 9\n%d %s 30\n",
           inputNumber,
           (inputNumber == 0) ? "equal" : "not equal",
           inputNumber,
           (inputNumber == 4) ? "equal" : "not equal",
           inputNumber,
           (inputNumber == 8) ? "equal" : "not equal",
           inputNumber,
           (inputNumber == 9) ? "equal" : "not equal",
           inputNumber,
           (inputNumber == 30) ? "equal" : "not equal");
}

void task_3() {
    int X, Y, Z;

    printf("Enter three numbers (X, Y, Z): ");
    scanf("%d %d %d", &X, &Y, &Z);

    int isAnyGreaterThan100 = (X > 100 || Y > 100 || Z > 100) ? 1 : 0;

    if (isAnyGreaterThan100)
        printf("At least one of the numbers X, Y, or Z is greater than 100.\n");
    else
        printf("None of the numbers X, Y, or Z is greater than 100.\n");
}

int main() {
    int choice;
    printf("Enter 1 for first task\nEnter 2 for second task\nEnter 3 for third task\n");
    scanf("%d", &choice);
    switch (choice) {
        case 1:
            task_1();
            break;
        case 2:
            task_2();
            break;
        case 3:
            task_3();
            break;
        default:
            printf("Invalid input");
    }
    return 0;
}
