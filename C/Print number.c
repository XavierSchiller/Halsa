//Write a program that repeatedly accepts user input and then prints the numbers between 0 and the entered number. If the user enters a number less than or equal to zero, the program will exit.
#include<stdio.h>

void main()
{
    int number,count=0;
    do
    {
        printf("Enter a number:");scanf("%d",number);
        while(count!=number)
        {
            printf("%d\n",count);
            count++;
        }
    }while(number!=0||number<0);
}
