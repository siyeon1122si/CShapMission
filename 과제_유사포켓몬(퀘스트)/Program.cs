using Mission_230619;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 따라오는 몬스터 ver2

// 풀숲 추가 : 플레이어가 풀숲을 돌아다니면 36%확률로 배틀이 일어난다.
// NPC 추가 : 플레이어가 NPC를 만나면 퀘스트를 받아서 몬스터와의 배틀 5번을 채우면 퀘스트 클리어 문구를 본다.
// 이번에는 몬스터가 따라오지 않고 배틀이 일어난다.

namespace _230622실습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.MapOpen();
        }
    }
}
