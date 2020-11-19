using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shinkarev_Dmitriy_Task19.Data.Models
{
    public class User
    {
        public User()
        {
            Rewards = new List<Reward>();
        }
        public int Id { get; set; }

        [Display(Name = "First name:")]
        [Required(ErrorMessage = "Поле должно быть заполнено.")]
        [RegularExpression(@"^(([A-я]+|[^\W0-9_]))$", ErrorMessage = "Имя может содержать только буквы.")]
        [StringLength(20, ErrorMessage = "Длинна имени не должна привышать 20 символов")]
        public string FirstName { get; set; }

        [Display(Name = "Last name:")]
        [Required(ErrorMessage = "Поле должно быть заполнено.")]
        [RegularExpression(@"^(([A-я]+|[^\W0-9_]))$", ErrorMessage = "Фамилия может содержать только буквы.")]
        [StringLength(20, ErrorMessage = "Длинна фамилии не должна привышать 20 символов")]
        public string LastName { get; set; }

        [Display(Name = "Birth date:")]
        [Required(ErrorMessage = "Поле должно быть заполнено.")]
        [UIHint("Date")]
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                {
                    return DateTime.Now.Year - BirthDate.Year - 1;
                }
                else
                {
                    return DateTime.Now.Year - BirthDate.Year;
                }
            }
        }

        public List<Reward> Rewards { get; set; }
    }
}
