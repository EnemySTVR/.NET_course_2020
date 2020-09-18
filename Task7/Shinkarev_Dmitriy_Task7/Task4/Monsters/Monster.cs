using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Monsters
{
    class Monster : GameObject
    {
        public Monster(int x, int y) 
            : base(x, y)
        {
            // Чтобы не отвлекаться на жизнь монстров сразу пускаем их в движение.
            RandomMoving();
        }

        public virtual void RandomMoving()
        {
            // Переопределяемый(все монстры могут гулять по разному) метод в котором проверяется возможность пойти, столкновения с игроком и объектами.
        }
    }
}
