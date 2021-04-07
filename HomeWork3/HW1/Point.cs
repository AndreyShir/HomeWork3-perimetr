using System;

namespace HomeWork3
{
    class Point
    /* Класс Point должен хранить целочисленные координаты X, Y и название точки. 
     * Доступ к данным класса Point должен быть только для чтения (свойства с одним методом доступа get). 
     * Класс Point должен содержать пользовательский конструктор, в теле которого поля инициализируются значениями аргументов.*/
    {

        public string name { get; } = "No name";
        public int x { get; }
        public int y { get; }


        public Point()
        {
           
        }
        public Point(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;
        }
        public Point(string pointName, int pointX, int pointY)
        {
            name = pointName;
            x = pointX;
            y = pointY;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name} x: {x} y: {y}");

        }
    }
}
