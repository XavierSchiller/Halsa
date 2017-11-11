#include<stdio.h>
#include<stdlib.h>
#include<string.h>

char * split(char *,char);
int main()
{
	printf("Enter the size of the array");
	int size;
	scanf("%d",&size);
	char *s=(char *)malloc(size);
	scanf("%s",s);
	char *p=split(s,'!');
	printf("%s",p);
}

char * split(char *str, char splc)
{
	int counter;
	for(int i=0;i<strlen(str);i++)
		{
			if(str[i]==splc) 
				{
				break;
				}
			counter++;
		}
	char *strr=(char *)malloc(counter);
	strncpy(strr,str,counter);
	return strr;
}


