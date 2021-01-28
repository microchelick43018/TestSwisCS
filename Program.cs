using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace TestSwisCS
{
    class Game
    {
        private static Dictionary<int, List<int>> _wheels;
        private static Dictionary<int, List<int>> _lines;
        private static Dictionary<int, List<int>> _payTable;
        private int[,] _matrix = new int[4, 5];
        public static Dictionary<int, List<int>> Lines { get => _lines; }
        public static Dictionary<int, List<int>> PlayTable { get => _payTable; }
        public int[,] Matrix { get => _matrix; }
        public Game()
        {
            _wheels = new Dictionary<int, List<int>>();
            {
                _wheels.Add(0, new List<int> { 5, 1, 9, 10, 9, 4, 6, 5, 2, 6, 9, 4, 9, 5, 7, 3, 10, 9, 5, 10, 7, 3, 10, 9, 6, 10, 4, 6, 10, 3, 9,
                                   5, 10, 0, 0, 12, 12, 6, 10, 1, 9, 10, 1, 6, 9, 3, 9, 10, 3, 10, 6, 9, 4, 9, 6, 10, 9, 8, 10, 4, 9,
                                   10, 7, 4, 10, 6, 7, 10, 2, 7, 9, 7, 9 });
                _wheels.Add(1, new List<int> { 7, 8, 4, 7, 6, 3, 9, 8, 1, 9, 11, 7, 4, 7, 6, 7, 3, 10, 2, 7, 8, 10, 2, 9, 4, 7, 11, 10, 2, 8, 11, 8, 9,
                                     4, 10, 11, 4, 8, 5, 8, 3, 10, 5, 3, 5, 8, 5, 4, 10, 3, 7, 5, 4, 7, 5, 1, 0, 0, 0, 12, 10, 11, 7, 10, 4,
                                     7, 6, 7, 2, 8, 6, 7, 2, 8, 12, 12, 10, 1, 6, 10, 11, 5, 9, 6, 1, 5, 6, 9, 2, 6, 5, 6, 3, 7, 9, 7, 2, 9, 5,
                                     9, 3, 5, 7, 4, 5, 7, 9 });
                _wheels.Add(2, new List<int> { 3, 8, 1, 7, 4, 8, 3, 8, 2, 9, 9, 10, 10, 8, 11, 3, 5, 4, 8, 1, 8, 3, 8, 3, 5, 1, 8, 3, 2, 1, 5, 3, 8, 4,
                                     8, 3, 8, 1, 8, 1, 11, 2, 5, 3, 8, 1, 8, 4, 12, 0, 0, 12, 1, 8, 2, 9, 2, 8, 3, 8, 2, 8, 1, 7, 3, 6, 4, 10,
                                     1, 11, 8, 1, 7 });
                _wheels.Add(3, new List<int> {4, 9, 4, 10, 2, 0, 0, 0, 0, 5, 11, 4, 8, 1, 9, 6, 2, 5, 4, 7, 11, 7, 2, 7, 4, 7, 10, 1, 7, 4, 10, 11, 7,
                                     2, 6, 2, 9, 4, 6, 2, 8, 2, 9, 1, 10, 4, 8, 7, 7, 7, 10, 2, 8, 2, 9, 4, 8, 10, 2, 7, 4, 9, 8, 2, 10, 6, 3,
                                     9, 2, 10, 12, 12, 12, 2, 10, 3, 10, 3, 5, 4, 10, 2, 8, 1, 9, 3, 6, 4, 10, 3, 8, 4, 9, 1, 10, 4, 10, 1, 5,
                                     7, 9 });
                _wheels.Add(4, new List<int> { 2, 7, 10, 1, 8, 3, 10, 6, 2, 10, 7, 3, 6, 10, 1, 7, 6, 5, 2, 10, 2, 7, 3, 7, 3, 10, 9, 5, 4, 5, 8, 2, 9,
                                     6, 3, 6, 0, 0, 0, 0, 1, 6, 2, 5, 4, 8, 9, 3, 7, 6, 2, 5, 6, 9, 4, 5, 6, 1, 9, 3, 7, 2, 8, 3, 6, 9, 4, 5, 1, 8, 4, 6,
                                     3, 6, 0, 12, 12, 12, 12, 7, 2, 7, 12, 10, 1, 5, 2, 6, 1, 8, 2, 6, 5, 7, 9 });
            }
            _lines = new Dictionary<int, List<int>>();
            {
                _lines.Add(0, new List<int>() { 0, 0, 0, 0, 0 }); _lines.Add(1, new List<int>() { 1, 1, 1, 1, 1 }); _lines.Add(2, new List<int>() { 2, 2, 2, 2, 2 });
                _lines.Add(3, new List<int>() { 3, 3, 3, 3, 3 }); _lines.Add(4, new List<int>() { 1, 2, 3, 2, 1 }); _lines.Add(5, new List<int>() { 2, 1, 0, 1, 2 });
                _lines.Add(6, new List<int>() { 0, 0, 1, 2, 3 }); _lines.Add(7, new List<int>() { 3, 3, 2, 1, 0 }); _lines.Add(8, new List<int>() { 1, 0, 0, 0, 1 });
                _lines.Add(9, new List<int>() { 2, 3, 3, 3, 2 }); _lines.Add(10, new List<int>() { 0, 1, 2, 3, 3 }); _lines.Add(11, new List<int>() { 3, 2, 1, 0, 0 });
                _lines.Add(12, new List<int>() { 1, 0, 1, 2, 1 }); _lines.Add(13, new List<int>() { 2, 3, 2, 1, 2 }); _lines.Add(14, new List<int>() { 0, 1, 0, 1, 0 });
                _lines.Add(15, new List<int>() { 3, 2, 3, 2, 3 }); _lines.Add(16, new List<int>() { 1, 2, 1, 0, 1 }); _lines.Add(17, new List<int>() { 2, 1, 2, 3, 2 });
                _lines.Add(18, new List<int>() { 0, 1, 1, 1, 0 }); _lines.Add(19, new List<int>() { 3, 2, 2, 2, 3 });
            }
            _payTable = new Dictionary<int, List<int>>();
            {
                _payTable.Add(0, new List<int> { 0, 50, 200, 1000 });
                _payTable.Add(1, new List<int> { 0, 25, 100, 400 });
                _payTable.Add(2, new List<int> { 0, 25, 100, 400 });
                _payTable.Add(3, new List<int> { 0, 20, 75, 250 });
                _payTable.Add(4, new List<int> { 0, 20, 75, 250 });
                _payTable.Add(5, new List<int> { 0, 5, 50, 150 });
                _payTable.Add(6, new List<int> { 0, 5, 50, 150 });
                _payTable.Add(7, new List<int> { 0, 5, 20, 100 });
                _payTable.Add(8, new List<int> { 0, 5, 20, 100 });
                _payTable.Add(9, new List<int> { 0, 5, 20, 100 });
                _payTable.Add(10, new List<int> { 0, 5, 20, 100 });
            }
        }
        private void GetMatrix(ref int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int r = random.Next(0, _wheels[i].Count);//метод Next(min, max) объекта random генерирует случайное число в интервале [min, max) 
                for (int j = 0; j < 4; j++)
                {
                    _matrix[j, i] = _wheels[i][(r + j) % _wheels[i].Count]; //(temp + j) % _wheels[i].Count тут берем остаток от длины ленты барабана, 
                    //чтобы взять частичку с конца и частичку с начала ленты
                    //и заполняем матрицу по столбцу
                }
            }
        }
        private int CountLine(List<int> line, int [,] matrix, Dictionary<int, List<int>> payTable)
        {
            int i = 0;// положение на линии
            int k = 1;// количество идущих подряд
            int cellValue;// значение считаемой ячейки
            while(i < 5 && matrix[line[i], i] == 12)//цикл делает так, чтобы определить, какое значение(цифру) ячейки мы  будем считать, а т.к. 12 нет в таблице
                //выплат, то мы идём по линии пока мы не встретим другое число, но заодно и будем прибавлять k
            {
                k++;
                i++;
            }
            
            if (i == 5)// мы дошли до конца линии, то получили линию джокеров
            {
                return 0;
            }
            else//в ином случае мы остановимся на другом числе
            {
                cellValue = matrix[line[i], i];
            }
            if (cellValue == 11)// нет смысла считать 11 (нет в таблице выплат)
            {
                return 0;
            }
            for (; i < 4; i++)// продолжаем идти по линии
            {
                if (cellValue == matrix[line[i + 1], i + 1] || matrix[line[i + 1], i + 1] == 12)//смотрим, если следующий символ равен cellValue или джокеру
                {// то прибавляем счётчик идущих подряд
                    k++;
                }
                else// в ином случае это конец линии
                {
                    break;
                }
            }
            if (k < 3) { return 0; }// если идущих подряд цифр меньше трёх, то они выводят 0
            else { return payTable[cellValue][k - 2]; }//в ином случае возращаем соотвественно таблице выплат
        }
        public int Play()
        {
            int sum = 0;
            GetMatrix(ref _matrix);// генерирует барабаны (матрицу)
            for (int i = 0; i < 20; i++)// цикл для подсчёта каждой линии
            {
                sum += CountLine(_lines[i], _matrix, _payTable);
            }
            return sum;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            const int QUANTITYOFGAMES = 10000000;
            Game game = new Game();
            int Win = 0;
            int hits = 0;
            for (int i = 0; i < QUANTITYOFGAMES; i++)
            {
                int temp = game.Play();
                if (temp > 0) hits++;
                Win += temp;
            }
            Console.WriteLine("Amount win = " + Win);
            Console.WriteLine($"RTP = {(double) Win / QUANTITYOFGAMES * 100 / 5}%");
            Console.WriteLine($"Quantity of hits = {hits}");
            Console.WriteLine($"HitRate = {(double) QUANTITYOFGAMES / hits}");
            Console.ReadKey();
        }
    }
}
