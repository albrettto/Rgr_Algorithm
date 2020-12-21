using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace РГР
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        #region Declaration of variables
        struct Circle //структура Круг (координаты центра круга и радиус)
        {
            public int x;
            public int y;
            public int rad;
        }
        static int n = 15;                      //Максимальное кол-во вершин в орграфе
        Circle[] circles = new Circle[n];       //массив кругов
        int k = 0;                              //Кол-во вершин в орграфе
        int[,] adjacency_list = new int[n, n];  //Список смежности из n элементов
        string[] color = new string[n];         //Массив цветов вершин орграфа
                                                //Изначально все вершины белые
                                                //При входе в вершину её цвет будет изменяться на серый
        string cycle = "";                      //Строка с циклом (без конечного значения)
        int start_ind;                          //Индекс начальной вершины
        int from_vertex = -1;                   //Переменная для запоминания выбранной вершины
        #endregion
        void change_color()                             //Изменяем цвета в орграфе
        {
            for (int j = 0; j < k; ++j)                 //Проходим по всем вершинам
            {
                bool changed = false;                   //Булевая переменная для проверки на окрашенность в серый
                for (int i = 0; i < cycle.Length; ++i)  //Проходим по всей строке с циклом
                    if (j+49 == cycle[i])               //Если встречаем вершину в цикле
                    {
                        color[j] = "grey";              //Красим её в серый цвет
                        changed = true;                 //Отмечаем это в булевой переменной
                        break;                          //Выходи из цикла
                    }
                if (!changed)                           //Если вершина не была перекрашена
                    color[j] = "white";                 //Красим её в белый цвет
            }
        }
        void DFS(int v)                         //Модифицированная функция Поиска в глубину
        {                                       //v — вершина, в которой мы сейчас находимся, k - кол-во вершин в орграфе
            int count = 0;                      //Переменная для подсчёта путей исходящих из этой вершины
            for (int i = 0; i < k; ++i)         //Считаем пути
                if (adjacency_list[v, i] == 0)  //Если встречаем 0 в списке смежности, значит больше путей нет
                {
                    count = i;                  //Запоминаем кол-во путей
                    break;                      //Выходим из цикла
                }
            color[v] = "grey";                  //Закрашиваем вершину в серый цвет
            for (int u = 0; u < count; ++u)     //Проходим по всем "соседям" этой вершины
            {
                                                //Возвращаем строку до вершины, у которой несколько путей
                                                //Это необходимо для верного вывода циклов
                while (cycle[cycle.Length-1] != (v+49))
                    cycle = cycle.Remove(cycle.Length - 1);
                cycle += " -> ";
                if (count > 1 && u != 0)        //Если кол-во путей из этой вершины > 1 и это не первый путь
                    change_color();  //Меняем цвета серых вершин на белые, чтобы можно было найти и другие циклы
                if (color[adjacency_list[v, u] - 1] == "white")     //Если следующая вершина белая
                {
                    cycle += (adjacency_list[v, u]) + " ";          //Прибавляем в цикл вершину
                    DFS(adjacency_list[v, u] - 1);                  //Вызываем DFS для следующей вершины
                }
                //Если цвет вершины серый и вершина равна стартовой, печатаем цикл в Result_RichTextBox
                if (color[adjacency_list[v, u] - 1] == "grey" && adjacency_list[v, u]-1 == start_ind)
                    Result_RichTextBox.Text += cycle + (start_ind + 1) + "\n";
            }
        }
        private void Canvas_Panel_MouseDown(object sender, MouseEventArgs e)//Обработчик нажатия на Полотно
        {
            Pen pen_default = new Pen(Color.MediumBlue, 3); //карандаш для круга по умолчанию
            Pen pen_selected = new Pen(Color.Red, 3);       //карандаш для выбранного круга
            Pen pen_for_line = new Pen(Color.Black, 2);     //карандаш для соединительных линий
            pen_for_line.CustomEndCap = new AdjustableArrowCap(7, 13);//Добавляем в конец линии стрелочку
            if (e.Button == MouseButtons.Right) //если нажата правая кнопка мыши
            {
                circles[k].rad = 15;
                circles[k].x = e.X - circles[k].rad;
                circles[k].y = e.Y - circles[k].rad;
                Canvas_Panel.CreateGraphics().DrawEllipse(pen_default,
                                                            circles[k].x,
                                                            circles[k].y,
                                                            circles[k].rad * 2,
                                                            circles[k].rad * 2); //рисуем круг
                var lb = new Label //текст для отображения номера круга на панели
                {
                    Location = new Point(circles[k].x + circles[k].rad / 2 + 30, circles[k].y + circles[k].rad / 2 - 5), //местоположение текста
                    Text = (k + 1).ToString(), //номер круга
                    Font = new Font("Serif", 14),
                    AutoSize = true //размер "автоматический"
                };
                Canvas_Panel.Controls.Add(lb); //добавление номера круга на панель
                k++; //увеличиваем счётчик вершин
                if (k > n)//Если кол-во вершин больше максимального
                {
                    MessageBox.Show("Вы привысили максимальное кол-во вершин!");
                    Clear_Button_Click(sender, e);
                }
            }
            if (e.Button == MouseButtons.Left)  //если нажата левая кнопка мыши
            {
                if (from_vertex == -1)          //если пока не запомнили ни одну из вершин
                {
                    for (int i = 0; i < k; i++) //проверяем попал ли щелчок мыши на какую-то из вершин
                        if (((e.X - circles[i].x - circles[i].rad) *
                                (e.X - circles[i].x - circles[i].rad) +
                                (e.Y - circles[i].y - circles[i].rad) *
                                (e.Y - circles[i].y - circles[i].rad))
                                < (circles[i].rad) * (circles[i].rad))
                        {
                            from_vertex = i;//если попали, то запоминаем вершину по которой щелкнули
                            Canvas_Panel.CreateGraphics().DrawEllipse(pen_selected,
                                                                        circles[i].x,
                                                                        circles[i].y,
                                                                        circles[i].rad * 2,
                                                                        circles[i].rad * 2); //выделяем круг
                            break;//выходим из цикла
                        }


                }
                else //если по одной из вершин уже раннее щелкнули(запомнили), то
                {
                    int to_vertex = -1;         //создаём переменную для запоминания второй вершины
                    for (int i = 0; i < k; i++) //проверяем попал ли щелчок мыши на какую-то из вершин
                        if (((e.X - circles[i].x - circles[i].rad) *
                                    (e.X - circles[i].x - circles[i].rad) +
                                    (e.Y - circles[i].y - circles[i].rad) *
                                    (e.Y - circles[i].y - circles[i].rad))
                                    < (circles[i].rad) * (circles[i].rad))
                        {
                            to_vertex = i;//если попали, то запоминаем вершину по которой щелкнули
                            Canvas_Panel.CreateGraphics().DrawEllipse(pen_selected,
                                                                        circles[i].x,
                                                                        circles[i].y,
                                                                        circles[i].rad * 2,
                                                                        circles[i].rad * 2); //выделяем круг
                            break;//выходим из цикла
                        }
                    if ((to_vertex != -1) && (from_vertex != to_vertex))//если щелкнули сначала по одной, а потом по другой вершине
                    {
                        //центр первой выделенной вершины
                        Point p1 = new Point(circles[from_vertex].x + circles[from_vertex].rad,
                                                circles[from_vertex].y + circles[from_vertex].rad);
                        //центр второй выделенной вершины
                        Point p2 = new Point(circles[to_vertex].x + circles[to_vertex].rad,
                                                circles[to_vertex].y + circles[to_vertex].rad);
                        //рисуем соединительную линию
                        Canvas_Panel.CreateGraphics().DrawLine(pen_for_line, p1, p2);
                        //отмечаем в списке смежностей путь
                        int i;
                        for (i = 0; adjacency_list[from_vertex, i] != 0; ++i) ;
                        adjacency_list[from_vertex, i] = to_vertex + 1; //Добавляем вершину в список смежности
                        AdjList_RichTextBox.Text = "";//Очищаем RichTextBox со списком смежности, чтобы переписать его
                        for (i = 0; i < k; ++i)//Обновляем списки смежности в RichTextBox
                        {
                            AdjList_RichTextBox.Text += (i + 1) + ":";
                            for (int j = 0; adjacency_list[i, j] != 0; ++j)
                                AdjList_RichTextBox.Text += " " + adjacency_list[i, j];
                            AdjList_RichTextBox.Text += "\n";
                        }
                        Canvas_Panel.CreateGraphics().DrawEllipse(pen_default,
                                                                    circles[from_vertex].x,
                                                                    circles[from_vertex].y,
                                                                    circles[from_vertex].rad * 2,
                                                                    circles[from_vertex].rad * 2);//Снимаем выделение
                        Canvas_Panel.CreateGraphics().DrawEllipse(pen_default,
                                                                    circles[to_vertex].x,
                                                                    circles[to_vertex].y,
                                                                    circles[to_vertex].rad * 2,
                                                                    circles[to_vertex].rad * 2);//Снимаем выделение
                        from_vertex = -1;//сбрасываем значение для дальнейшей работы
                    }
                }
            }
        }
        private void Clear_Button_Click(object sender, EventArgs e) //Возврат всех элементов панели к начальному положению
        {
            for (int i = 0; i < k; ++i)         //Очистка списков смежностей
                for (int j = 0; j < k; ++j)
                    adjacency_list[i, j] = 0;
            AdjList_RichTextBox.Text = "";      //Очистка RichTextBox со списками смежностей
            Result_RichTextBox.Text = "";       //Очистка RichTextBox с результатом
            Canvas_Panel.Refresh();             //Обновление полотна
            for (int i = 0; i < k; ++i)         //Очистка массива структур
            {
                circles[i].x = 0;
                circles[i].y = 0;
                circles[i].rad = 0;
            }
            Canvas_Panel.Controls.Clear();      //Очитска Полотна от лэйблов
            k = 0;                              //Обнуляем кол-во вершин
        }
        private void Result_Button_Click(object sender, EventArgs e)//Обработчик нажатия на кнопку результата
        {
            for (int i = 0; i < k; ++i)                             //Для всех вершин в орграфе
            {
                start_ind = i;                                      //Запоминаем начальную вершину
                for (int j = 0; j < k; ++j)                         //Все вершины "перекрашиваем" в белый цвет
                    color[j] = "white";
                cycle = (i+1) + " ";                                //Очищаем строку с циклом
                DFS(i);                                          //Вызываем DFS для i-той вершины
            }
            if (Result_RichTextBox.Text == "")                      //Если RichTextBox с результатом пуст, после предыдущего шага
                Result_RichTextBox.Text = "Циклы не найдены!";      //То орграф не имеет циклов
        }
    }
}