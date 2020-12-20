using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        static int n = 15;                      //Максимальное кол-во вершин в орграфе
        int[,] adjacency_list = new int[n, n];  //Список смежности из n элементов
        string [] color = new string[n];        //Массив цветов вершин орграфа
                                                //Изначально все вершины белые
                                                //При входе в вершину её цвет будет изменяться на серый
        string cycle = "";                      //Строка с циклом (без конечного значения)
        int start_ind;                          //Индекс начальной вершины
        #endregion
        void change_color(int k)           //Изменяем цвета в орграфе
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
        void DFS(int v, int k)                  //Модифицированная функция Поиска в глубину
        {                                       //v — вершина, в которой мы сейчас находимся, k - кол-во вершин в орграфе
            int count = 0;                      //Переменная для подсчёта путей исходящих из этой вершины
            for (int i = 0; i < n; ++i)         //Считаем пути
                if (adjacency_list[v, i] == 0)  //Если встречаем 0 в списке смежности, значит больше путей нет
                {
                    count = i;                  //Запоминаем кол-во путей
                    break;                      //Выходим из цикла
                }
            color[v] = "grey";                  //Закрашиваем вершину в серый цвет
            for (int u = 0; u < count; ++u)     //Проходим по всем "соседям" этой вершины
            {
                                                //Возвращаем строку до вершины у которой несколько путей
                                                //Это необходимо для верного вывода циклов
                while (cycle[cycle.Length-1] != (v+49))
                    cycle = cycle.Remove(cycle.Length - 1);
                cycle += " -> ";
                if (count > 1 && u != 0)        //Если кол-во путей из этой вершины > 1 и это не первый путь
                    change_color(k);  //Меняем цвета серых вершин на белые, чтобы можно было найти и другие циклы
                if (color[adjacency_list[v, u] - 1] == "white")     //Если следующая вершина белая
                {
                    cycle += (adjacency_list[v, u]) + " ";          //Прибавляем в цикл вершину
                    DFS(adjacency_list[v, u] - 1, k);               //Вызываем DFS для следующей вершины
                }
                //Если цвет вершины серый и вершина равна стартовой, печатаем цикл в Result_RichTextBox
                if (color[adjacency_list[v, u] - 1] == "grey" && adjacency_list[v, u]-1 == start_ind)
                    Result_RichTextBox.Text += cycle + (start_ind + 1) + "\n";
            }
        }
        private void Adjacency_TextBox_KeyDown(object sender, KeyEventArgs e)   //Обработчик нажатия на TextBox с вводом данных
        {
            if (e.KeyCode == Keys.Enter)            //Если было нажатие на Enter
            {
                int ind = Convert.ToInt32(Top_NumericUpDown.Value) - 1; //Индекс 
                string copy_adj = "";
                if (adjacency_list[ind, 0] == 0)    //Если для этой вершины еще нет путей
                {
                    int i = 0;
                    string numb = "";               //Храним значение очередного числа в строковом представлении
                    copy_adj = Adjacency_TextBox.Text;
                    while (Adjacency_TextBox.Text != "" && Adjacency_TextBox.Text != " ")   //Пока TextBox не пуст и не имеет одного символа = пробелу
                    {
                        if (Adjacency_TextBox.Text[0] == ' ' && numb != "")                 //Если первый элемент TextBox - пробел и numb не пуст
                        {
                            if (numb.Length > 1)                                            //Если число не однозначное
                            {
                                for (int j = 0; j < numb.Length; ++j)                       //Преобразуем строкоове значение в числовое
                                    adjacency_list[ind, i] += Convert.ToInt32(numb[j]) * (int)Math.Pow(10, numb.Length - 1 - j);
                            }
                            else                                                            //Если число однозначное
                                adjacency_list[ind, i] = Convert.ToInt32(numb);
                            ++i;
                            numb = "";                                                      //Обнуляем numb
                            Adjacency_TextBox.Text = Adjacency_TextBox.Text.Remove(0, 1);   //Удаляем первый символ из TextBox
                        }
                        else                                                                //Если первый элемент TextBox - не пробел или numb пуст
                        {
                            numb += Adjacency_TextBox.Text[0];                              //Добавялем в numb цифру
                            Adjacency_TextBox.Text = Adjacency_TextBox.Text.Remove(0, 1);   //Удаляем первый символ из TextBox
                        }
                    }
                    if(Adjacency_TextBox.Text == "" && numb != "")                          //Если TextBox пуст и numb не пуст
                        if (numb.Length > 1)                                                // Если число не однозначное
                        {
                            for (int j = 0; j < numb.Length; ++j)                           //Преобразуем строкоове значение в числовое
                                adjacency_list[ind, i] += Convert.ToInt32(numb[j]) * (int)Math.Pow(10, numb.Length - 1 - j);
                        }
                        else
                            adjacency_list[ind, i] = Convert.ToInt32(numb);                 //Если число однозначное
                }
                else                                //Если список смежности для этой вершины не пуст
                                                    //Выводим об этом сообщение
                    Adjacency_TextBox.Text = "Вы уже вводили данные для этой вершины! Смените вершину.";
                                                    //Выводим список смежности для данной вершины
                AdjList_RichTextBox.Text += "Вершина №" + Top_NumericUpDown.Value + ": " + copy_adj + "\n";
                                                    //Если вершина не равна кол-ву всех вершин в орграфе
                if (Top_NumericUpDown.Value != CountTop_NumericUpDown.Value)
                    Top_NumericUpDown.Value++;      //Переходим к следуеющей вершине
            }
        }
        private void Clear_Button_Click(object sender, EventArgs e) //Возврат всех элементов панели к начальному положению
        {
            for (int i = 0; i < n; ++i)         //Очистка списков смежностей
                for (int j = 0; j < n; ++j)
                    adjacency_list[i, j] = 0;
            Adjacency_TextBox.Text = "";        //Очистка TextBox, куда вводим данные
            Top_NumericUpDown.Value = 1;        //Возврат значения NumericUpDown к 1
            CountTop_NumericUpDown.Value = 1;   //Возврат значения NumericUpDown к 1
            Alert_Label.Text = "";              //Очистка Label с предупреждением
            AdjList_RichTextBox.Text = "";      //Очистка RichTextBox со списками смежностей
            Result_RichTextBox.Text = "";       //Очистка RichTextBox с результатом
        }
        private void Adjacency_TextBox_Click(object sender, EventArgs e)    //Обработчик нажатия на TextBox с вводом данных
        {
            if (Adjacency_TextBox.Text == "Вы уже вводили данные для этой вершины! Смените вершину.")
                Adjacency_TextBox.Text = "";
        }
        private void Top_NumericUpDown_ValueChanged(object sender, EventArgs e) //Обработчик изменения вершины
        {
            if (Top_NumericUpDown.Value > CountTop_NumericUpDown.Value) //Если вершина становится > Кол-ва вершин
            {
                //Выводим предупреждение
                Alert_Label.Text = Top_NumericUpDown.Value.ToString() + " вершины нет! Увеличьте кол-во вершин.";
                Top_NumericUpDown.Value--;  //Уменьшаем значение вершины
            }
        }
        private void CountTop_NumericUpDown_ValueChanged(object sender, EventArgs e)    //Обработчик изменения кол-ва вершин
        {
            Alert_Label.Text = "";  //Очищаем Label с предупреждением
        }
        private void Result_Button_Click(object sender, EventArgs e)//Обработчик нажатия на кнопку результата
        {
            int k = Convert.ToInt32(CountTop_NumericUpDown.Value);  //k - кол-во вершин в орграфе
            for (int i = 0; i < k; ++i)                             //Для всех вершин в орграфе
            {
                start_ind = i;                                      //Запоминаем начальную вершину
                for (int j = 0; j < k; ++j)                         //Все вершины "перекрашиваем" в белый цвет
                    color[j] = "white";
                cycle = (i+1) + " ";                                //Очищаем строку с циклом
                DFS(i, k);                                          //Вызываем DFS для i-той вершины
            }
            if (Result_RichTextBox.Text == "")                      //Если RichTextBox с результатом пуст, после предыдущего шага
                Result_RichTextBox.Text = "Циклы не найдены!";      //То орграф не имеет циклов
        }
    }
}