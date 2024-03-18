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

union SignedShortInput {
    signed short value;
    struct {
        unsigned short sign : 1;
        unsigned short magnitude : 15;
    } parts;
};

union FloatRepresentation {
    float value;
    struct {
        unsigned int mantissa : 23;
        unsigned int exponent : 8;
        unsigned int sign : 1;
    } parts;
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
    SignedShortInput input{};

    printf("Enter a signed short integer: ");
    scanf("%hd", &input.value);

    if (input.parts.sign == 0) {
        printf("Sign: Positive\n");
        printf("Magnitude: %hu\n", input.parts.magnitude);
    } else {
        printf("Sign: Negative\n");
        printf("Magnitude: %hu\n", input.parts.magnitude);
    }

    unsigned short absValue = (input.value >= 0) ? input.value : -input.value;
    bool sign = input.value < 0;

    printf("Using bitwise operations:\n");
    printf("Sign: %s\n", (sign ? "Negative" : "Positive"));
    printf("Magnitude: %hu\n", absValue);
}

void task_3() {
    signed char a = 5;
    signed char b = 127;
    signed char c = 2;
    signed char d = -3;
    signed char e = -120;
    signed char f = -34;
    signed char g = -5;
    signed char h = 56;
    signed char i = 38;

    printf("a) 5 + 127 = %d\n", a + b);
    printf("b) 2 - 3 = %d\n", c - d);
    printf("c) -120 - 34 = %d\n", e - f);
    printf("d) (unsigned char)(-5) = %d\n", (unsigned char)g);
    printf("e) 56 & 38 = %d\n", h & i);
    printf("f) 56 | 38 = %d\n", h | i);
}

void task_4() {
    union FloatRepresentation number;
    number.value = 123.45f;
    printf("Bitwise representation: ");
    for (int i = sizeof(float) - 1; i >= 0; --i) {
        printf("%hhx ", *((unsigned char*)&number.value + i));
    }
    printf("\n");
    printf("Byte-wise representation: ");
    for (int i = 0; i < sizeof(float); ++i) {
        printf("%hhx ", *((unsigned char*)&number.value + i));
    }
    printf("\n");
    printf("Sign: %d\n", number.parts.sign);
    printf("Exponent: %d\n", number.parts.exponent);
    printf("Mantissa: %u\n", number.parts.mantissa);
    printf("Memory size of FloatRepresentation union: %zu bytes\n", sizeof(union FloatRepresentation));
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
