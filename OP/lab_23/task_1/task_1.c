#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define MAX_CARS 100

struct Car {
    char brand[50];
    char color[20];
    int serialNumber;
    char regNumber[15];
    int yearOfManufacture;
    int inspectionYear;
    float price;
};

struct Car cars[MAX_CARS];
int numberOfCars = 0;

void addCar() {
    if (numberOfCars < MAX_CARS) {
        struct Car newCar;
        printf("Enter car details:\n");
        printf("Brand: ");
        scanf("%s", newCar.brand);
        printf("Color: ");
        scanf("%s", newCar.color);
        printf("Serial number: ");
        scanf("%d", &newCar.serialNumber);
        printf("Registration number: ");
        scanf("%s", newCar.regNumber);
        printf("Year of manufacture: ");
        scanf("%d", &newCar.yearOfManufacture);
        printf("Inspection year: ");
        scanf("%d", &newCar.inspectionYear);
        printf("Price: ");
        scanf("%f", &newCar.price);

        cars[numberOfCars++] = newCar;
        printf("Car added successfully!\n");
    }
    else {
        printf("Cannot add more cars. Maximum limit reached.\n");
    }
}

void displayCars() {
    if (numberOfCars == 0) {
        printf("No cars to display.\n");
    }
    else {
        printf("Cars information:\n");
        printf("----------------------------------------------------------------------------------------------------------------\n");
        printf("Brand\t\tColor\t\tSerial\t\tReg. Number\tYear\t\tInspect.\tPrice\n");
        printf("----------------------------------------------------------------------------------------------------------------\n");
        for (int i = 0; i < numberOfCars; ++i) {
            printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
        }
        printf("----------------------------------------------------------------------------------------------------------------\n");
    }
}

void searchCarByField() {
    int choice;
    printf("\nEnter the field for search (1 - Brand, 2 - Color, 3 - Serial Number, 4 - Reg. Number, 5 - Year of Manufacture, 6 - Inspection Year, 7 - Price): ");
    scanf("%d", &choice);

    int found = 0;
    char searchString[50];
    int searchNumber;
    float searchingPrice;

    switch (choice) {
    case 1:
        printf("Enter the brand: ");
        scanf("%s", &searchString);
        for (int i = 0; i < numberOfCars; ++i) {
            if (strcmp(cars[i].brand, searchString) == 0) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    case 2:
        printf("Enter the color: ");
        scanf("%s", &searchString);
        for (int i = 0; i < numberOfCars; ++i) {
            if (strcmp(cars[i].color, searchString) == 0) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    case 3:
        printf("Enter the serial number: ");
        scanf("%d", &searchNumber);
        for (int i = 0; i < numberOfCars; ++i) {
            if (cars[i].serialNumber == searchNumber) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    case 4:
        printf("Enter the registration number: ");
        scanf("%s", &searchString);
        for (int i = 0; i < numberOfCars; ++i) {
            if (strcmp(cars[i].regNumber, searchString) == 0) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    case 5:
        printf("Enter the year of manufacture: ");
        scanf("%d", &searchNumber);
        for (int i = 0; i < numberOfCars; ++i) {
            if (cars[i].yearOfManufacture == searchNumber) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    case 6:
        printf("Enter the inspection year: ");
        scanf("%d", &searchNumber);
        for (int i = 0; i < numberOfCars; ++i) {
            if (cars[i].inspectionYear == searchNumber) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    case 7:
        printf("Enter the price: ");
        scanf("%f", &searchingPrice);
        for (int i = 0; i < numberOfCars; ++i) {
            if (cars[i].price == searchingPrice) {
                printf("%s\t\t%s\t\t%d\t\t%s\t\t%d\t\t%d\t\t%.2f\n", cars[i].brand, cars[i].color, cars[i].serialNumber,
                    cars[i].regNumber, cars[i].yearOfManufacture, cars[i].inspectionYear, cars[i].price);
                printf("----------------------------------------------------------------------------------------------------------------\n");
                found = 1;
            }
        }
        break;
    default:
        printf("Invalid choice.\n");
    }

    if (!found) {
        printf("Car not found.\n");
    }
}

void deleteCarByIndex() {
    int index;
    printf("Enter the index of the car to delete: ");
    scanf("%d", &index);

    if (index >= 0 && index < numberOfCars) {
        for (int i = index; i < numberOfCars - 1; ++i) {
            cars[i] = cars[i + 1];
        }
        numberOfCars--;
        printf("Car deleted successfully!\n");
    }
    else {
        printf("Invalid index for deletion.\n");
    }
}

int compareBrand(const void* a, const void* b) {
    return strcmp(((struct Car*)a)->brand, ((struct Car*)b)->brand);
}

int compareColor(const void* a, const void* b) {
    return strcmp(((struct Car*)a)->color, ((struct Car*)b)->color);
}

int compareSerialNumber(const void* a, const void* b) {
    return ((struct Car*)a)->serialNumber - ((struct Car*)b)->serialNumber;
}

int compareRegNumber(const void* a, const void* b) {
    return strcmp(((struct Car*)a)->regNumber, ((struct Car*)b)->regNumber);
}

int compareYearOfManufacture(const void* a, const void* b) {
    return ((struct Car*)a)->yearOfManufacture - ((struct Car*)b)->yearOfManufacture;
}

int compareInspectionYear(const void* a, const void* b) {
    return ((struct Car*)a)->inspectionYear - ((struct Car*)b)->inspectionYear;
}

int comparePrice(const void* a, const void* b) {
    if (((struct Car*)a)->price < ((struct Car*)b)->price) return -1;
    if (((struct Car*)a)->price > ((struct Car*)b)->price) return 1;
    return 0;
}


void sortCarsByField() {
    int choice;
    printf("\nEnter the field for sorting (1 - Brand, 2 - Color, 3 - Serial Number, 4 - Reg. Number, 5 - Year of Manufacture, 6 - Inspection Year, 7 - Price): ");
    scanf("%d", &choice);

    if (numberOfCars > 0) {
        switch (choice) {
        case 1:
            qsort(cars, numberOfCars, sizeof(struct Car), compareBrand);
            break;
        case 2:
            qsort(cars, numberOfCars, sizeof(struct Car), compareColor);
            break;
        case 3:
            qsort(cars, numberOfCars, sizeof(struct Car), compareSerialNumber);
            break;
        case 4:
            qsort(cars, numberOfCars, sizeof(struct Car), compareRegNumber);
            break;
        case 5:
            qsort(cars, numberOfCars, sizeof(struct Car), compareYearOfManufacture);
            break;
        case 6:
            qsort(cars, numberOfCars, sizeof(struct Car), compareInspectionYear);
            break;
        case 7:
            qsort(cars, numberOfCars, sizeof(struct Car), comparePrice);
            break;
        default:
            printf("Invalid choice.\n");
            return;
        }
        printf("Cars sorted successfully.\n");
    }
    else {
        printf("No cars to sort.\n");
    }
}


int main() {
    int choice;

    while (1) {
        printf("\nChoose an option:\n");
        printf("1. Add a new car\n");
        printf("2. Display cars\n");
        printf("3. Search for a car by field\n");
        printf("4. Delete a car\n");
        printf("5. Sort cars by field\n");
        printf("6. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
        case 1:
            addCar();
            break;
        case 2:
            displayCars();
            break;
        case 3:
            searchCarByField();
            break;
        case 4:
            deleteCarByIndex();
            break;
        case 5:
            sortCarsByField();
            break;
        case 6:
            exit(0);
        default:
            printf("Invalid choice.\n");
        }
    }

    return 0;
}
