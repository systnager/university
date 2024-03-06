#include <stdio.h>
#include <string.h>

int main() {
    const char* grades[] = { "No such grade", "No such grade", "Unsatisfactory", "Satisfactory", "Good", "Excellent" };

    int choice;
    printf("Choose an option:\n");
    printf("1. Convert number to grade using switch\n");
    printf("2. Convert number to grade using string array\n");
    printf("3. Convert grade to number\n");
    scanf_s("%d", &choice);

    switch (choice) {
    case 1: {
        int grade;
        printf("Enter a number (2 to 5): ");
        scanf_s("%d", &grade);

        switch (grade) {
        case 2:
            printf("Unsatisfactory\n");
            break;
        case 3:
            printf("Satisfactory\n");
            break;
        case 4:
            printf("Good\n");
            break;
        case 5:
            printf("Excellent\n");
            break;
        default:
            printf("No such grade\n");
        }
        break;
    }
    case 2: {
        const char* grades[] = { "No such grade", "No such grade", "Unsatisfactory", "Satisfactory", "Good", "Excellent" };

        int grade;
        printf("Enter a number (2 to 5): ");
        scanf_s("%d", &grade);

        if (grade >= 2 && grade <= 5) {
            printf("%s\n", grades[grade]);
        }
        else {
            printf("%s\n", grades[0]);
        }
        break;
    }
    case 3: {
        getchar();

        char input[20];
        printf("Enter a grade (Unsatisfactory, Satisfactory, Good, Excellent): ");
        fgets(input, sizeof(input), stdin);

        int grade = -1;
        input[strcspn(input, "\n")] = '\0';

        for (int i = 2; i <= 5; i++) {
            if (strcmp(input, grades[i]) == 0) {
                grade = i;
                break;
            }
        }

        if (grade != -1) {
            printf("Numeric grade: %d\n", grade);
        }
        else {
            printf("No such grade\n");
        }
        break;
    }
    default:
        printf("Invalid choice\n");
    }

    return 0;
}
