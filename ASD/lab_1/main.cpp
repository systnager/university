#include <iostream>
#include <cstdio>
#include <ctime>

struct DateTime {
    int year;
    int month;
    int day;
    int hour;
    int minute;
    int second;
};

void task_1() {
    DateTime currentDateTime = {2024, 3, 14, 12, 30, 45};

    printf("DateTime structure:\n");
    printf("Year: %d\n", currentDateTime.year);
    printf("Month: %d\n", currentDateTime.month);
    printf("Day: %d\n", currentDateTime.day);
    printf("Hour: %d\n", currentDateTime.hour);
    printf("Minute: %d\n", currentDateTime.minute);
    printf("Second: %d\n", currentDateTime.second);

    time_t currentTime = time(nullptr);
    struct tm *currentTM = localtime(&currentTime);

    printf("\nCurrent time using tm structure:\n");
    printf("Year: %d\n", currentTM->tm_year + 1900);
    printf("Month: %d\n", currentTM->tm_mon + 1);
    printf("Day: %d\n", currentTM->tm_mday);
    printf("Hour: %d\n", currentTM->tm_hour);
    printf("Minute: %d\n", currentTM->tm_min);
    printf("Second: %d\n", currentTM->tm_sec);

    printf("Memory size of DateTime structure: %zu bytes\n", sizeof(DateTime));
    printf("Memory size of tm structure: %zu bytes\n", sizeof(struct tm));
}

void task_2() {

}

void task_3() {

}

void task_4() {

}

int main() {
    printf("Choice task from 1 to 4: ");
    int choice;
    scanf("%d", &choice);
    if (choice == 1) {
        task_1();
    } else if (choice == 2) {
        task_2();
    } else if (choice == 3) {
        task_3();
    } else if (choice == 4) {
        task_4();
    } else {
        printf("Invalid choice. Goodbye!");
    }
    return 0;
}
