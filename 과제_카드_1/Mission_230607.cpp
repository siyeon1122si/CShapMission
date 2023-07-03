#include <iostream>
#include <Windows.h>
#include <stdlib.h>
#include <stdio.h>

void card();
void ShuffleOnce(int* firstnumber, int* secondnumber);

int main()
{
	card();
	
}

void ShuffleOnce(int* firstnumber, int* secondnumber)
{
	int temp = 0;
	temp = *firstnumber;
	*firstnumber = *secondnumber;
	*secondnumber = temp;
}      // shuffleOnce()


void card()
{
	int cards[13] = { 0, };
	char cardPatterns[][4] = { "♠" , "◇" , "♡" , "♣" };   // 2차원 배열 선언 및 초기화  

	int i;  // 반복 제어 변수
	int count;  // 문자열의 개수를 저장할 변수
	

	for (int i = 0; i < 13; i++)
	{
		cards[i] = i + 1;

	}

	const int shuffleCard = 200;  //몇번 섞을지
	int random1, random2 = 0;

	srand(time(NULL));
	for (int i = 0; i < shuffleCard; i++)
	{
		random1 = rand() % 13;
		random2 = rand() % 13;
		ShuffleOnce(&cards[random1], &cards[random2]);
	}

	count = sizeof(cardPatterns) / sizeof(cardPatterns[0]); // 초기화된 문자열의 수를 계산

	for (int i = 0; i < 1; i++)
	{
		int a; a = rand() % 4;  //배열에서 패턴 추출을 위한 랜덤 인덱스 값

		printf("%s : ",cardPatterns[a]);
		switch(cards[i])
		{
		case 1 :
			printf("A");
			break;
		case 11 :
			printf("J");
			break;
		case 12:
			printf("Q");
			break;
		case 13 :
			printf("K");
			break;
		default:
			printf("%d", cards[i]);
			break;
		}
	}
}
