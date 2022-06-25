int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}

int a1 = 2;
int a2 = 7;
int a3 = 16;
int b1 = 29;
int b2 = 70;
int b3 = 11;
int c1 = 26;
int c2 = 78;
int c3 = 19;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(b1, b2, b3);
// int max3 = Max(c1, c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, a2, a3), 
    Max(b1, b2, b3), 
    Max(c1, c2, c3)
    );

Console.WriteLine(max);