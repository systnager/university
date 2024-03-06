#define _USE_MATH_DEFINES
#include <stdio.h>
#include <math.h>

double DegToRad(double D) {
    return D * (M_PI / 180.0);
}

double RadToDeg(double R) {
    return R * (180.0 / M_PI);
}

int main() {
    double angles_degrees[] = { 30, 45, 60, 90, 120 };
    int i = 0;

    while (i < 5) {
        double radians = DegToRad(angles_degrees[i]);
        printf("%lf degrees = %lf radians\n", angles_degrees[i], radians);
        i++;
    }

    double angles_radians[] = { M_PI / 6, M_PI / 4, M_PI / 3, M_PI / 2, 2 * M_PI / 3 };
    i = 0;

    while (i < 5) {
        double degrees = RadToDeg(angles_radians[i]);
        printf("%lf radians = %lf degrees\n", angles_radians[i], degrees);
        i++;
    }

    return 0;
}
