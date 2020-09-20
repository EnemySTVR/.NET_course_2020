using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Monsters
{
    abstract class Monster : GameObject
    {
        public Monster(int xCoordinates, int yCoordinates) 
            : base(xCoordinates, yCoordinates)
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
