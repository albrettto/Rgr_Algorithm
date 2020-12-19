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
        static int n = 15;                      //Кол-во вершин в орграфе
        int[,] adjacency_list = new int[n, n];  //Список смежности из n элементов
        string [] color = new string[n];        //Массив цветов вершин орграфа
                                                //Изначально все вершины белые
                                                //При входе в вершину её цвет будет изменяться на серый
                                                //А при выходе из неё в чёрный
        string cycle = "";                      //Строка с циклом (без конечного значения)
        int start_ind;                          //Индекс начальной вершины
        int few_ind;                            //Индекс вершины, с несколькими путями
        #endregion


        //void change_color(int few_ind, int k)
        //{
        //    bool changed = false;
        //    for (int j = 0; j < k; ++j)
        //    {
        //        for (int i = 0; i < cycle.Length; ++i)
        //            if (j == cycle[i])
        //            {
        //                color[j] = "grey";
        //                changed = true;
        //                break;
        //            }
        //        if(!changed)
        //            color[j] = "white";
        //        if (j == few_ind)
        //            color[j] = "black";
        //    }
        //}

        void dfs(int v, int from_v, int k)                  //Модифицированная функция Поиска в глубину
        {                                       //v — вершина, в которой мы сейчас находимся, k - кол-во вершин в орграфе 
            color[v] = "grey";                  //Закрашиваем вершину в серыцй цвет
            cycle += (v + 1) + " -> ";          //Добавляем её в строку с циклом
            int count = 0;                      //Переменная для подсчёта путей от этой вершины
            for (int i = 0; i < n; ++i)         //Считаем пути
                if (adjacency_list[v, i] == 0)  //Если встречаем 0 в списке смежности, значит более путей нет
                {
                    count = i;                  //Запоминаем кол-во путей
                    break;
                }
            if (count > 1)                      //Если путей > 1
                few_ind = v;                    //Запоминаем индекс вершины с несколькими путями
            for (int u = 0; u < count; ++u)     //Проходим по всем "соседям"
            {
                if (color[adjacency_list[v, u] - 1] == "white" || color[adjacency_list[v, u] - 1] == "black") //Если цвет белый(т.е. мы в нём до этого не были)
                    dfs(adjacency_list[v, u] - 1, v, k);           //Рекурсивно проверяем по dfs эту вершину
                if (color[adjacency_list[v, u] - 1] == "grey")  //Если цвет серый(т.е. мы в нём бывали)
                {
                    if (adjacency_list[v, u] - 1 == start_ind)  //Если вершина совпадает с начальной вершиной
                        Result_RichTextBox.Text += cycle + (start_ind + 1) + "\n";  //Записываем результат в Result_RichTextBox
                    int temp = 0;
                    while ((cycle[cycle.Length - 1]) != (char)(few_ind + 49))       //Пока не встретим вершину, которую мы запоминали
                    {
                        if ((cycle[cycle.Length - 1]) != ' ' && (cycle[cycle.Length - 1]) != '-' && (cycle[cycle.Length - 1]) != '>')
                            temp = cycle[cycle.Length - 1];
                        cycle = cycle.Remove(cycle.Length - 1);                     //Удаляем символ из строки с циклом
                    }
                    //while ((cycle[cycle.Length - 1]) != (char)(few_ind + 49))       //Пока не встретим вершину, которую мы запоминали
                    //    cycle = cycle.Remove(cycle.Length - 1);                     //Удаляем символ из строки с циклом
                    cycle += " -> ";            //Добавим "->", т.к. удалили его на предыдущем шаге
                    //change_color(temp, k);
                    break;
                }
            }
            if (adjacency_list[v, 0] == 0 && few_ind != 0)      //Если путей нет, но была вершина с несколькими путями
            {
                int temp = 0;
                while ((cycle[cycle.Length - 1]) != (char)(few_ind + 49))       //Пока не встретим вершину, которую мы запоминали
                {
                    if ((cycle[cycle.Length - 1]) != ' ' && (cycle[cycle.Length - 1]) != '-' && (cycle[cycle.Length - 1]) != '>')
                        temp = cycle[cycle.Length - 1];
                    cycle = cycle.Remove(cycle.Length - 1);                     //Удаляем символ из строки с циклом
                }
                while ((cycle[cycle.Length - 1]) != (char)(few_ind + 49))
                    cycle = cycle.Remove(cycle.Length - 1);     //Стираем всё до этой вершины
                cycle += " -> ";
                //change_color(temp, k);
            }
            //if(from_v == few_ind)
            //    color[v] = "black";                 //Помечаем вершину в чёрный цвет, т.к. выходим из неё
            //else
            //    color[v] = "white";
            color[v] = "black";

        }

        //int[] cl = new int[n];
        //int [] p = new int[n];
        //int cycle_st, cycle_end;

        //bool dfs(int v)
        //{
        //    cl[v] = 1;
        //    int count = 0;                      //Переменная для подсчёта путей от этой вершины
        //    for (int i = 0; i < n; ++i)         //Считаем пути
        //        if (adjacency_list[v, i] == 0)  //Если встречаем 0 в списке смежности, значит более путей нет
        //        {
        //            count = i;                  //Запоминаем кол-во путей
        //            break;
        //        }
        //    for (int i = 0; i < count; ++i)
        //    {
        //        int to = adjacency_list[v, i]-1;
        //        if (cl[to] == 0)
        //        {
        //            p[to] = v;
        //            if (dfs(to)) return true;
        //        }
        //        else if (cl[to] == 1)
        //        {
        //            cycle_end = v;
        //            cycle_st = to;
        //            return true;
        //        }
        //    }
        //    cl[v] = 2;
        //    return false;
        //}
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
                cycle = "";                                         //Очищаем строку с циклом
                few_ind = 0;                                        //Обнуляем индекс вершины с несколькими путями
                dfs(i, i, k);                                       //Вызываем dfs с i-той вершиной
            }

            //int[] cycle = new int[k];
            //for (int j = 0; j < n; ++j)
            //{
            //    p[j] = -1;
            //    cl[j] = 0;
            //}
            //cycle_st = -1;
            //for (int i = 0; i < k; ++i)
            //{

            //    if (dfs(i))
            //    {
            //        cycle[0] = cycle_st;
            //        int c = 1;
            //        for (int v = cycle_end; v != cycle_st; v = p[v])
            //        {
            //            cycle[c] = v;
            //            ++c;
            //        }
            //        for (int m = 0; m < c; ++m)
            //                Result_RichTextBox.Text += cycle[m] + " -> ";
            //        Result_RichTextBox.Text += cycle_st + "\n";
            //    }
            //}

            if (Result_RichTextBox.Text == "")                      //Если RichTextBox с результатом пуст, после предыдущего шага
                Result_RichTextBox.Text = "Циклы не найдены!";      //То орграф не имеет циклов
        }
    }
}