using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mission_230619
{

    public class Battle
    {
        int userHp = 100;
        Map map1 = new Map();
        public void Mountain(ref int coin)
        {

            Console.WriteLine(" =====================");
            Console.WriteLine("  [ 산에 도착했습니다 ]");
            Console.WriteLine(" =====================");

            Random random = new Random();

            int battle = random.Next(1, 100);

            if (battle <= 60 && battle > 0)
            {
                BattleOpen();
            }
            else
            {
                HealOpen(userHp);
            }

        }

        public void BattleOpen()
        {
            Random random = new Random();
            int monsterHp = 100;
            int monsterDamage = 10;
            int userDamage = random.Next(20, 50);

            Console.WriteLine(" [ 전투 발생 ! ]");
            Console.WriteLine();

            while ( (monsterHp > 0 ) && ( userHp > 0) )
            {
                Thread.Sleep( 1500 );
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine(" ===========================================");
                Console.WriteLine("   [ 몬스터의 체력 = {0}   [ 유저 체력 = {1}    ",monsterHp,userHp);
                Console.WriteLine(" ===========================================");
                Console.WriteLine();

                Console.WriteLine(" 유저가 몬스터에게 [ {0} ] 만큼의 데미지를 입혔습니다 ",userDamage);
                monsterHp -= userDamage;
                
                if ( monsterHp > 0 )
                {
                    Thread.Sleep(1500);
                    Console.Clear();


                    Console.WriteLine();
                    Console.WriteLine(" ===========================================");
                    Console.WriteLine("   [ 몬스터의 체력 = {0}   [ 유저 체력 = {1}    ", monsterHp, userHp);
                    Console.WriteLine(" ===========================================");

                    Console.WriteLine(" 몬스터에게 [ {0} ] 만큼의 데미지를 입었습니다 ", monsterDamage);
                    Console.WriteLine();
                    userHp -= monsterDamage;
                }

                if ( monsterHp <= 0 )
                {
                    Thread.Sleep(1500);
                    Console.Clear();


                    Console.WriteLine();
                    Console.WriteLine(" \n             몬스터 처치 !              \n ");
                    Console.WriteLine(" ===========================================");
                    Console.WriteLine("   [ 몬스터의 체력 = 0     [ 유저 체력 = {1}    ", monsterHp, userHp);
                    Console.WriteLine(" ===========================================");
                    Console.WriteLine();

                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
                else if ( userHp <= 0 )
                {
                    Thread.Sleep(1500);
                    Console.Clear();


                    Console.WriteLine();
                    Console.WriteLine(" \n            사망하였습니다              \n ");
                    Console.WriteLine(" ===========================================");
                    Console.WriteLine("   [ 몬스터의 체력 = {0}   [ 유저 체력 = 0      ", monsterHp, userHp);
                    Console.WriteLine(" ===========================================");
                    Console.WriteLine();


                    Console.ReadLine();
                    Console.Clear();
                    return;

                }

            }
        }

        public void HealOpen(int userHp)
        {
            Random random = new Random();

            int heal = random.Next(10, 50);

            Console.WriteLine(" [ 힐을 발동합니다 ! ]");

            if ( userHp >= 100 )
            {
                Console.WriteLine(" 남은 유저의 체력은 [ 100 ] 입니다.");
                Console.WriteLine(" 유저의 체력이 이미 최대치이므로 힐을 받을 수 없습니다. ");

                Thread.Sleep(1500);
                Console.Clear();
                return;

            }

            else if ( userHp < 100 )
            {
                Console.WriteLine(" 남은 유저의 체력은 [ {0} ] 입니다",userHp);
                Console.WriteLine(" [ {0} ] 의 힐을 받았습니다 !",heal);
                userHp = heal + userHp;

                Console.WriteLine( " 유저의 체력 = {0} ",userHp);

                Thread.Sleep(1500);
                Console.Clear();
                return;

            }
        }
    }

}