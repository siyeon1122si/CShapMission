using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// 콘솔 맵은 직사각형
// 밖으로 못나가게 가장자리는 다 벽
// 플레이어는 특정한 위치에 초기화를 한다
// 맵 내부에 벽이 랜덤한 위치에 생성된다
// 벽은 장애물이 되어서 플레이어의 이동을 방해하는 수단으로 사용된다
// 적은 플레이어가 입력을 하나 받을 때마다 플레이어의 방향으로 1칸 이동한다.
// 적은 일정 시간 혹은 턴마다 1명씩 추가된다
// 플레이어가 이동한 횟수를 점수로 처리한다 
// ( vary hard ) 콘솔이 켜져 있을 동안의 플레이 중에서 플레이어의 Best score 를 출력한다

namespace Mission_230619
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
