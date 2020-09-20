using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task4
{
    class Player : GameObject
    {
        private Playground _playground;
        public Player(int xCoordinates, int yCoordinates, Playground playground)
            : base(xCoordinates, yCoordinates)
        {
            // Конечно, круто провернуть всё это через события, но для простоты сделаем так:
            // Копируем в _pg ссылку на наш playground для того, чтобы оповещать его о наших перемещениях и взаимодействовать с другими обьектами.
            _playground = playground;
            // И добавляем на playground нашего player'a
            _playground.AddObject(this);
        }

        /*      В методах ниже проверяем возможность перемещения по полю.
                Проверяем свободны ли целевые координаты:

                Если не свободны смотрим, чем занято.
                Если бонус, то получаем профит, удаляем бонус и идем.
                Если не бонус, то не идем.
                Если враг, то гейм овер.

                Если координаты свободны, то идем: 
                Удаляем игрока в текущих координатах из playground.
                Меняем коордитаты игрока.
                Добавляем игрока в новых координатах на playground.
            */
        public void MoveUp()
        {
            
        }
        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }
        public void MoveRight()
        {

        }
    }
}
