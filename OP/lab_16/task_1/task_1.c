#define _USE_MATH_DEFINES
#include <stdio.h>
#include <math.h>


float calculate_circle_area(float radius) {
    float area = M_PI * pow(radius, 2);
    return area;
}

int main() {
    float radius;

    printf("Enter the radius of the circle: ");
    scanf_s("%f", &radius);

    float result = calculate_circle_area(radius);
    printf("The area of the circle with radius %.2f is %.2f\n", radius, result);

    return 0;
}
