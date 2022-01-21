using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Part16.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Не указано Имя")] // атрибут Required, благодаря чему фреймворк знает, что данное свойство обязательно должно содержать некоторое значение
        public string Name { get; set; }
        [Required] 
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина от 3 до 50")] // максимальная допустимая длина строки
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        [Required] // атрибут Required, благодаря чему фреймворк знает, что данное свойство обязательно должно содержать некоторое значение
        public string Password { get; set; }
        [Range(18,150, ErrorMessage = "Возраст от 18")] // минимальные и максимальные ограничения для числовых данных
        // [Remote(action: "CheckEmail", controller: "Home", ErrorMessage ="Email уже используется")]
        // Для валидации свойства выполняет запрос на сервер к определенному методу контроллера.
        // И если требуемый метод контроллера вернет  значение false, то валидация не пройдена
        public int Age { get; set; }
    }
}
