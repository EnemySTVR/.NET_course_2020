using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shinkarev_Dmitriy_Task19.Data.Models
{
    public class Reward
    {
        public int Id { get; set; }

        [Display(Name = "Name:")]
        [Required(ErrorMessage = "Поле должно быть заполнено.")]
        [RegularExpression(@"^(([A-я]+|[^\W0-9_]))$", ErrorMessage = "Имя может содержать только буквы.")]
        [StringLength(20, ErrorMessage = "Длинна имени не должна привышать 20 символов.")]
        public string Name { get; set; }

        [Display(Name = "Description:")]
        [Required(ErrorMessage = "Поле должно быть заполнено.")]
        [StringLength(200, ErrorMessage = "Длинна имени не должна привышать 200 символов.")]
        public string Description { get; set; }

        public List<User> Users { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return ((Reward)obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
