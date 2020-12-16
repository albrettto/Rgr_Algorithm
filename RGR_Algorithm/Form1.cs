using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_Algorithm
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        // Структура узла
        unsafe struct Node
        {
            public bool leaf;  // является ли узел листом
            public int n;      // количество ключей узла
            public int[] key;  // ключи узла
            public Node [] c;   // указатели на детей узла
        }
        // Структура дерева
         unsafe struct BTree
        {
            public int t;      // минимальная степень дерева
            public Node root;  // указатель на корень дерева
        }

        bool BTree_Search(ref Node node, int key)
        {
            if (node.n != 0)
            {
                for (int i = 0; i < node.n; ++i)
                    if (key == node.key[i])
                    {
                        Result_TextBox.Text = "Ключ найден!";
                        return true;
                    }
                    else if (key < node.key[0])
                        BTree_Search(ref node.c[0], key);
                    else if (node.key[i] < key && key < node.key[i + 1])
                        BTree_Search(ref node.c[i + 1], key);
                    else
                        BTree_Search(ref node.c[node.n - 1], key);
            }
                Result_TextBox.Text = "Ключ не найден!";
                return false;

        }

        void BTree_Add(ref Node node, int key)
        {
            if(BTree_Search(ref node, key) == false)
            {

            }
            else
                Result_TextBox.Text = "Такой ключ уже есть!";
        }



        //void B_Tree_Insert(BTree T, int k) {
        //    Node r = T.root;
        //    if (r.n == 2 * T.t - 1){
        //        Node s = new Node();
        //        T.root = s;
        //        s.leaf = false;
        //        s.n = 0;
        //        s.c[1] = r;
        //        B_Tree_Split_Child(s, T.t, 1);
        //        B_Tree_Insert_Nonfull(s, k, T.t); 
        //    }
        //    else
        //        B_Tree_Insert_Nonfull(r, k, T.t); 
        //}
        //void B_Tree_Insert_Nonfull(Node x, int k, int t) {
        //    int i = x.n;
        //    if (x.leaf) {
        //        while (i >= 1 && k < x.key[i])
        //        {
        //            x.key[i + 1] = x.key[i];
        //            i -= 1;
        //        } 
        //        x.key[i + 1] = k;
        //        x.n = x.n + 1;
        //        //Disk - Write(x);
        //    }
        //    else {
        //        while (i >= 1 && k < x.key[i]) 
        //                i -= 1;
        //        i += 1;
        //        //Disk - Read(x.c[i]);
        //        if (x.c[i].n == 2 * t - 1)
        //        {
        //            B_Tree_Split_Child(x, t, i);
        //            if (k > x.key[i])
        //                i = i + 1;
        //        }
        //        B_Tree_Insert_Nonfull(x.c[i], k, t);
        //    } 
        //}
        //void B_Tree_Split_Child(Node x, int t, int i) {
        //    Node z = new Node();
        //    Node y = x.c[i];
        //    z.leaf = y.leaf;
        //    z.n = t - 1;
        //    for (int j = 1; j < t - 1; ++j)
        //        z.key[j] = y.key[j + t];
        //    if (!y.leaf)
        //        for (int j = 1; j < t; ++j)
        //            z.c[j] = y.c[j + t];
        //    y.n = t - 1;
        //    for (int j = x.n + 1; j < i + 1; ++j)
        //        x.c[j + 1] = x.c[j];
        //    x.c[i + 1] = z;
        //    for (int j = x.n; j < i; ++j)
        //        x.key[j + 1] = x.key[j];
        //    x.key[i] = y.key[t];
        //    x.n = x.n + 1;
        //    //Disk - Write(y);
        //    //Disk - Write(z);
        //    //Disk - Write(x);
        //}
        
        
        BTree tree;
        int pos_x = 250, pos_y = 20;
        int size = 120;
        int count = 1;
        private void Search_Button_Click(object sender, EventArgs e)
        {
            int key;
            if (Input_TextBox.Text != "")
            {
                key = Convert.ToInt32(Input_TextBox.Text);
                BTree_Search(ref tree.root, key);
            }
            for(int i = 0; i < 4; i++)
                Paint_Btree();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            int key;
            if (Input_TextBox.Text != "")
            {
                key = Convert.ToInt32(Input_TextBox.Text);
                BTree_Add(ref tree.root, key);
            }
            
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int key;
            if (Input_TextBox.Text != "")
                key = Convert.ToInt32(Input_TextBox.Text);
        }
        void Paint_Btree()
        {
            
            Pen pen = new Pen(Color.Green, 2);
            int copy_pos_x = pos_x;
            for (int i = 0; i < count; ++i)
            {
                Canvas_Panel.CreateGraphics().DrawRectangle(pen, pos_x, pos_y, size, size / 4);
                pos_x += size + 10; 
            }
            count *= 2;
            pos_x = copy_pos_x - size / 2; pos_y += size / 2;
            //{
            //    //данные необходимые для рисования соединительных линий
            //    String drawString = ( + 1).ToString();
            //    Font drawFont = new Font("Arial", 14);
            //    SolidBrush drawBrush = new SolidBrush(Color.DarkBlue);
            //    PointF drawPoint = new PointF(circles[n].x + circles[n].rad / 2, circles[n].y + circles[n].rad / 2);
            //    //выводим цифру внутри вершины
            //    Canvas_Panel.CreateGraphics().DrawString(drawString, drawFont, drawBrush, drawPoint);
            //}

        }
    }
}
