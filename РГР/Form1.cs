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

        static int n = 15;
        //Список смежности из 15 элементов, т.к. я ограничил кол-во вершин до 15
        int[,] adjacency_list = new int[n, n];

        //ребро
        class Edge
        {
            public int v1, v2;
            public Edge(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
        }

        List<int> V = new List<int>(n);//Лист с вершинами
        List<Edge> E = new List<Edge>(1000);//Лист с ребрами
        List<string> catalogCycles = new List<string>(1000);//Результирующая строка

        ///*
        //u – номер вершины, в которой мы находимся в данный момент, 
        //endV – номер конечной вершины цикла, 
        //Е – список ребер, 
        //color[] – массив, в котором хранятся цвета вершин, 
        //unavailableEdge – см. ниже, 
        //cycle – список, в который заносится последовательность вершин искомого цикла.
        //*/
        //private void DFScycle(int u, int endV, List<Edge> E, int[] color, int unavailableEdge, List<int> cycle)
        //{
        //    //если u == endV, то эту вершину перекрашивать не нужно, иначе мы в нее не вернемся, а вернуться необходимо
        //    if (u != endV)
        //        color[u] = 2;
        //    else if (cycle.Count >= 2)
        //    {
        //        cycle.Reverse();
        //        string s = cycle[0].ToString();
        //        for (int i = 1; i < cycle.Count; i++)
        //            s += "-" + cycle[i].ToString();
        //        bool flag = false; //есть ли палиндром для этого цикла графа в List<string> catalogCycles?
        //        for (int i = 0; i < catalogCycles.Count; i++)
        //            if (catalogCycles[i].ToString() == s)
        //            {
        //                flag = true;
        //                break;
        //            }
        //        if (!flag)
        //        {
        //            cycle.Reverse();
        //            s = cycle[0].ToString();
        //            for (int i = 1; i < cycle.Count; i++)
        //                s += "-" + cycle[i].ToString();
        //            catalogCycles.Add(s);
        //        }
        //        return;
        //    }
        //    for (int w = 0; w < E.Count; w++)
        //    {
        //        if (w == unavailableEdge)
        //            continue;
        //        if (color[E[w].v2] == 1 && E[w].v1 == u)
        //        {
        //            List<int> cycleNEW = new List<int>(cycle);
        //            cycleNEW.Add(E[w].v2 + 1);
        //            DFScycle(E[w].v2, endV, E, color, w, cycleNEW);
        //            color[E[w].v2] = 1;
        //        }
        //        else if (color[E[w].v1] == 1 && E[w].v2 == u)
        //        {
        //            List<int> cycleNEW = new List<int>(cycle);
        //            cycleNEW.Add(E[w].v1 + 1);
        //            DFScycle(E[w].v1, endV, E, color, w, cycleNEW);
        //            color[E[w].v1] = 1;
        //        }
        //    }
        //}
        //private void cyclesSearch()
        //{
        //    int[] color = new int[V.Count];
        //    for (int i = 0; i < V.Count; i++)
        //    {
        //        for (int k = 0; k < V.Count; k++)
        //            color[k] = 1;
        //        List<int> cycle = new List<int>(1000);
        //        //поскольку в C# нумерация элементов начинается с нуля, то для
        //        //удобочитаемости результатов поиска в список добавляем номер i + 1
        //        cycle.Add(i + 1);
        //        DFScycle(i, i, E, color, -1, cycle);
        //    }
        //}



        //List<int> color = new List<int>(1000);
        //List<int> p = new List<int>(1000);
        //int cycle_st, cycle_end;
        //bool dfs(int v)
        //{
        //    color[v] = 1;
        //    int i = 0;
        //    while (adjacency_list[v, i] != 0)
        //    {
        //        int to = adjacency_list[v, i] - 1;
        //        if (color[to] == 0)
        //        {
        //            p[to] = v;
        //            if (dfs(to)) return true;
        //        }
        //        else if (color[to] == 1)
        //        {
        //            cycle_end = v;
        //            cycle_st = to;
        //            return true;
        //        }
        //        ++i;
        //    }
        //    color[v] = 2;
        //    return false;
        //}



        //int[] color = new int[n];
        //bool cycle;
        //// color — массив цветов, изначально все вершины белые  
        //void dfs(int start)
        //{
        //    color[start] = 1;
        //    int u = 0;
        //    while (adjacency_list[start, u] != 0)
        //    {
        //        if (color[adjacency_list[start, u]] == 0)
        //            dfs(adjacency_list[start, u]);
        //        else if (color[adjacency_list[start, u]] == 1)
        //            cycle = true;
        //        ++u;
        //    }
        //    color[start] = 2;
        //}



        string [] color = new string[n];
        string cycle = "";
        void dfs(int v, int k) {             // v — вершина, в которой мы сейчас находимся 
            color[v] = "grey";
            cycle += (v+1) + " -> ";
            int count = 0;
            for (int i = 0; i < n; ++i)
                if (adjacency_list[v, i] == 0)
                {
                    count = i;
                    break;
                }
            for (int u = 0; u < count; ++u)
            {
                if (color[adjacency_list[v, u]-1] == "white")
                    dfs(adjacency_list[v, u]-1, k);
                if (color[adjacency_list[v, u] - 1] == "grey")
                    break;
            }            
            color[v] = "black";
                }




        private void Adjacency_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ind = Convert.ToInt32(Top_NumericUpDown.Value) - 1;
                if (adjacency_list[ind, 0] == 0)
                {
                    int i = 0;
                    string numb = "";
                    while (Adjacency_TextBox.Text != "" && Adjacency_TextBox.Text != " ")
                    {
                        if (Adjacency_TextBox.Text[0] == ' ' && numb != "")
                        {
                            if (numb.Length > 1)
                            {
                                for (int j = 0; j < numb.Length; ++j)
                                    adjacency_list[ind, i] += Convert.ToInt32(numb[j]) * (int)Math.Pow(10, numb.Length - 1 - j);
                            }
                            else
                                adjacency_list[ind, i] = Convert.ToInt32(numb);
                            ++i;
                            numb = "";
                            Adjacency_TextBox.Text = Adjacency_TextBox.Text.Remove(0, 1);
                        }
                        else
                        {
                            numb += Adjacency_TextBox.Text[0];
                            Adjacency_TextBox.Text = Adjacency_TextBox.Text.Remove(0, 1);
                        }
                    }
                    if(Adjacency_TextBox.Text == "" && numb != "")
                        if (numb.Length > 1)
                        {
                            for (int j = 0; j < numb.Length; ++j)
                                adjacency_list[ind, i] += Convert.ToInt32(numb[j]) * (int)Math.Pow(10, numb.Length - 1 - j);
                        }
                        else
                            adjacency_list[ind, i] = Convert.ToInt32(numb);
                }
                else
                    Adjacency_TextBox.Text = "Вы уже вводили данные для этой вершины! Смените вершину.";
                if(Top_NumericUpDown.Value != CountTop_NumericUpDown.Value)
                    Top_NumericUpDown.Value++;
            }
        }

        private void ClearList_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    adjacency_list[i, j] = 0;
            Adjacency_TextBox.Text = "";
            Top_NumericUpDown.Value = 1;
            CountTop_NumericUpDown.Value = 1;
            Alert_Label.Text = "";
            Result_RichTextBox.Text = "";
        }

        private void Adjacency_TextBox_Click(object sender, EventArgs e)
        {
            if (Adjacency_TextBox.Text == "Вы уже вводили данные для этой вершины! Смените вершину.")
                Adjacency_TextBox.Text = "";
        }

        private void Top_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Top_NumericUpDown.Value > CountTop_NumericUpDown.Value)
            {
                Alert_Label.Text = Top_NumericUpDown.Value.ToString() + " вершины нет! Увеличьте кол-во вершин.";
                Top_NumericUpDown.Value--;
            }
        }

        private void CountTop_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Alert_Label.Text = "";
        }

        private void Result_Button_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(CountTop_NumericUpDown.Value);

            
            for (int i = 0; i < k; ++i)
            {
                for (int j = 0; j < k; ++j)
                    color[j] = "white";
                cycle = "";
                dfs(i, k);
                Result_RichTextBox.Text += cycle + (i+1) + "\n";
            }




            //for (int i = 0; i < k; ++i)
            //{
            //    for (int j = 0; j < n; ++j)
            //        if (adjacency_list[i, j] != 0)
            //            E.Add(new Edge(i, adjacency_list[i, j] - 1));
            //        else
            //            break;
            //    V.Add(i);
            //}
            //cyclesSearch();
            //while (catalogCycles.Count > 0)
            //{
            //    Result_RichTextBox.Text += catalogCycles.First() + "\n";
            //    catalogCycles.RemoveAt(0);
            //}
            //if (Result_RichTextBox.Text == "")
            //    Result_RichTextBox.Text = "Циклов в оргафе нет!";





            //for (int i = 0; i < k; ++i)
            //{
            //    p.Insert(i, -1);
            //    color.Insert(i, 0);
            //}
            //cycle_st = -1;
            //for (int i = 0; i < k; ++i)
            //    if (dfs(i) && cycle_st != -1)
            //    {
            //        List<int> cycle = new List<int>(1000);
            //        cycle.Add(cycle_st + 1);
            //        for (int v = cycle_end; v != cycle_st && p[v] != -1; v = p[v])
            //            if (v != -1)
            //                cycle.Add(v + 1);
            //        //for (int v = cycle_end; v != cycle_st && p[v] != -1; v = p[v])
            //        //    cycle.Add(v);
            //        cycle.Add(cycle_st + 1);
            //        for (int item = 0; item < cycle.Count; ++item)
            //        {
            //            Result_RichTextBox.Text += " " + cycle[item];
            //        }
            //        //foreach (var item in cycle)
            //        //{
            //        //    if (item == cycle.Count)
            //        //        break;
            //        //    Result_RichTextBox.Text += " " + cycle[item];
            //        //}
            //        Result_RichTextBox.Text += "\n";
            //    }



            //for (int i = 0; i < k; ++i)
            //    color[i] = 0;
            //for (int i = 0; i < k; ++i)
            //{
            //    cycle = false;
            //    if (color[i] == 0)
            //    {
            //        dfs(i);
            //        Result_RichTextBox.Text += cycle;
            //    }
            //    Result_RichTextBox.Text += "\n";
            //}
        }
    }
}

//public void DFS(int start)
//{
//    List<int> list = new List<int>();
//    Stack<int> s = new Stack<int>();
//    list.Add(start);
//    for (int i = k - 1; i >= 0; --i)
//        s.Push(i);
//    rep:
//    while (s.Count != 0)
//    {
//        int v = s.Peek();
//        s.Pop();
//        foreach (int i in list)
//        {
//            if (i == v)
//                goto rep;
//        }
//        list.Add(v);
//        for (int i = k; i >= 0; --i)
//            s.Push(i);
//    }
//}