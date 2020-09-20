using System;
using System.Collections.Generic;
using System.Text;
using Task4;

namespace Task4.OtherObjects
{
    abstract class OtherObject : GameObject
    {
        // Добавляем возможность проверить является ли бонусом данный объект.
        private bool _isBonus = false;
        private Player _player;
        public bool IsBonus { get; }

        public OtherObject(int xCoordinates, int yCoordinates)
            : base(xCoordinates, yCoordinates)
        {
            // В конструкторах бонусов необходимо переключать isBonus на true.
        }

        // Бонусам переопределяем этот метод. Остальным он может пригодиться в будущем, но пока не трогаем.
        public virtual void TakeProfit(Player player) { }


    }
}
