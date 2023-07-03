using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class Card
    {
        Map map1 = new Map();
        public void CardOpen(ref int coin)
        {


            while (true)
            {
                // 컴퓨터의 카드 선택 {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("                                    컴퓨터가 카드를 고르는 중입니다");

                Console.Write(" · ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);



                System.Console.Clear(); // 콘솔 창 초기화

                Random AIrandom = new Random();  // 랜덤 생성

                int AICardrand1 = AIrandom.Next(1, 13); // 컴퓨터의 카드 랜덤1
                int AICardrand2 = AIrandom.Next(1, 13); // 컴퓨터의 카드 랜덤2

                int AIPatternrand1 = AIrandom.Next(1, 4); // 컴퓨터의 카드 패턴 랜덤1
                int AIPatternrand2 = AIrandom.Next(1, 4); // 컴퓨터의 카드 패턴 랜덤2


                string[] AICardChoice = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" }; // 13장의 카드 종류
                string[] AIPattern = { "♤", "◆", "♥", "♧" }; // 4개의 카드 패턴

                Console.WriteLine();
                Console.WriteLine(" [ 컴퓨터의 카드 1 ]          [ 컴퓨터의 카드 2 ] ");

                // 카드 출력 부분

                if (AICardrand1 < AICardrand2) //AI 카드1번이 2번보다 작으면 첫번째로 나오게 출력
                {
                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘ ");
                }
                else //AI 카드2번이 1번보다 작으면 첫번째로 나오게 출력
                {
                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘ ");
                }
                // } 컴퓨터의 카드 선택 



                // 기본 소지금액 선언 및 출력
                Console.WriteLine();

                Console.WriteLine(" 현재 소지 금액 : [ {0} ]", coin);
                Console.WriteLine();

                // 베팅 시작
                Console.WriteLine(" 베팅을 시작하겠습니다 ! 베팅금액을 적어주세요.");

                Console.WriteLine();

                int Bettingcoin = int.Parse(Console.ReadLine());  // 사용자로부터 입력된 문자열을 정수로 변환하는 역할


                if (Bettingcoin <= coin) // 베팅 코인이 현재 코인과 같거나 작을 때 출력
                {
                    coin -= Bettingcoin;
                    Console.WriteLine();
                    Console.WriteLine(" 베팅금액은 [ {0} ] 입니다. ", Bettingcoin);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" 현재 소지 금액 : [ {0} ] ", coin);
                    Console.WriteLine();
                    Console.WriteLine(" 베팅이 완료되었습니다.");
                }

                // 베팅 시작
                Console.ReadLine();
                System.Console.Clear();



                // 유저의 카드 선택 {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("                                     유저가 카드를 고르는 중입니다");

                Console.Write(" · ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);


                System.Console.Clear();

                Random userrandom = new Random();  // 랜덤 생성

                int MyCardrand = userrandom.Next(1, 13); // 유저의 카드 랜덤

                int MyPatternrand = userrandom.Next(1, 4); // 유저의 카드 패턴 랜덤


                string[] MyCardChoice = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" }; // 12장의 카드 종류
                string[] MyPattern = { "♤", "◆", "♥", "♧" }; // 4개의 카드 패턴

                Console.WriteLine();
                Console.WriteLine(" [ 유저의 카드 ] ");

                // 카드 출력 부분
                Console.WriteLine();

                Console.WriteLine(" ┌──────────────┐ ");
                Console.WriteLine(" │ {00}{01}          │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand]);
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │          {00}{01} │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand]);
                Console.WriteLine(" └──────────────┘ ");
                // } 유저의 카드 선택 




                // 결과 출력 ... {
                Console.WriteLine(" 결과를 보려면 아무키나 눌러주세요. ");
                Console.ReadLine();
                System.Console.Clear();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("                                                결과는 ");

                Console.Write(" · ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                // } 결과 출력 ...
                System.Console.Clear();


                if (AICardrand1 > AICardrand2 && MyCardrand < AICardrand1 && MyCardrand > AICardrand2)  // AI 카드1 번이 2번보다 크면 더 앞에 나오게 설정
                {
                    Console.WriteLine(" [ 컴퓨터의 카드 1 ]         [ 유저의 카드 ]         [ 컴퓨터의 카드 2 ] ");

                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐          ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │          │ {04}{05}          │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │          │          {04}{05} │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘          └──────────────┘ ");


                    Console.WriteLine(" [ 유저의 카드 ] 가 컴퓨터의 카드 2장 사이에 있으므로 베팅에 성공하였습니다 ! ");
                    coin = coin + (Bettingcoin * 2);

                }
                else if (AICardrand1 < AICardrand2 && MyCardrand > AICardrand1 && MyCardrand < AICardrand2)  // AI 카드1 번이 2번보다 작으면 더 앞에 나오게 설정
                {
                    Console.WriteLine(" [ 컴퓨터의 카드 1 ]         [ 유저의 카드 ]         [ 컴퓨터의 카드 2 ] ");

                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐          ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │          │ {04}{05}          │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │          │          {04}{05} │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘          └──────────────┘ ");


                    Console.WriteLine(" [ 유저의 카드 ] 가 컴퓨터의 카드 2장 사이에 있으므로 베팅에 성공하였습니다 ! ");
                    coin = coin + (Bettingcoin * 2);

                }

                else // AI 카드 1번과 2번 사이에 유저의 카드가 없으면 베팅 실패
                {
                    Console.WriteLine("   [ 유저의 카드 ]        [ 컴퓨터의 카드 1 ]         [ 컴퓨터의 카드 2 ] ");

                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐          ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │          │ {04}{05}          │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │          │          {04}{05} │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘          └──────────────┘ ");

                    Console.WriteLine(" [ 유저의 카드 ] 가 컴퓨터의 카드 2장 사이에 있지 않으므로 베팅에 실패하였습니다. ");
                    coin -= Bettingcoin;
                }

                Console.WriteLine();
                Console.WriteLine(" 현재 소지 금액 : [ {0} ] ", coin);
                Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" 마을로 돌아갑니다");
                Console.WriteLine();
                System.Console.Clear();
                map1.MapOpen(ref coin);

            }
        }
    }
}
