/*#include <stdio.h>

void strCopy(char* str, char* name);

int main()
{
	char str[25];
	char name[25];

	fgets(name, 25, stdin);
	
	strCopy(str, name);
	puts(str);
}

void strCopy(char* str, char* name)
{
	while (*name != 0 && *name != '\n')
	{
		*str = *name;
		str++;
		name++;
	}
	*str = 0;
}*/

#include <stdio.h>
#include <string.h>

enum Menu
{
	ListUsers = 0,
	AddUser = 1,
	Exit = 2
};

void cleanEnter(char* string)
{
	while (*string != 0)
	{
		if (*string == '\n')
		{
			*string = 0;
		}
		string++;
	}
}

void strCopy(char* from, char* to)
{
	while (*from != 0 && *from != '\n')
	{
		*to = *from;
		from++;
		to++;
	}
	*to = 0;
}

void clearArray(char array[][10][256],
	int colCount, int rowCount)
{
	for (int col = 0; col < colCount;
		col++)
	{
		for (int row = 0; row < rowCount;
			row++)
		{
			array[col][row][0] = 0;
		}
	}
}

void printArray(char array[][10][256],
	int colCount, int rowCount)
{
	printf("Name\tPhone\n");
	for (int row = 0; row < rowCount;
		row++)
	{
		for (int col = 0; col < colCount;
			col++)
		{
			printf("%s\t",
				array[col][row]);
		}
		printf("\n");
	}
}

int main()
{
	char addressBook[2][10][256];
	clearArray(addressBook, 2, 10);

	char name[256];
	char phone[256];
	for (int user = 0; user < 2; user++)
	{
		printf("Enter name: ");
		fgets(name, 256, stdin);
		strcpy(addressBook[0][user], name);
		cleanEnter(addressBook[0][user]);

		printf("Enter phone: ");
		fgets(phone, 256, stdin);
		strcpy(addressBook[1][user], phone);
		cleanEnter(addressBook[1][user]);
	}

	printArray(addressBook, 2, 10);
}

