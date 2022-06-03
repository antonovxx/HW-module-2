using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Задание 1. Создание переменных и вывод 
 * Что нужно сделать
Объявите несколько переменных, которые будут хранить следующие значения:

    Ф. И. О.
    Возраст
    Email
    Баллы по программированию
    Баллы по математике
    Баллы по физике

 * Задание 2. Реализация подсчёта количества баллов по всем предметам
 * Что нужно сделать
Cоздайте две переменные для подсчёта суммы баллов по всем предметам и рассчитайте среднее арифметическое значение. Для этого:

    Создайте переменную под сумму баллов по всем предметам.
    Посчитайте сумму баллов.
    Создайте переменную под средний балл.
    Рассчитайте среднее арифметическое баллов.
    Выведите информацию на экран.
 */
namespace task1_2
{
    public class Student
    {
        private string fullName;
        private byte age;
        private string email;
        private float programmingPoints;
        private float mathPoints;
        private float physicsPoints;

        public Student(string fullName, byte age, string email, float programmingPoints, float mathPoints, float physicsPoint)
        {
            this.fullName = fullName;
            this.age = age;
            this.email = email;
            this.programmingPoints = programmingPoints;
            this.mathPoints = mathPoints;
            this.physicsPoints = physicsPoint;
        }

        private float gradePointAverage
        {
            get
            {
                return (mathPoints + programmingPoints + physicsPoints) / 3;
            }
        }

        public override string ToString()
        {
            return string.Format("ФИО: {0}" +
                "\nВозраст: {1}" +
                "\nEmail: {2}" +
                "\nБаллы по программированию: {3}" +
                "\nБаллы по математике: {4}" +
                "\nБаллы по физике: {5}," +
                "\nСредний балл: {6}",
                fullName, 
                age, 
                email,
                programmingPoints,
                mathPoints,
                physicsPoints,
                gradePointAverage);
        }
    }
}
