namespace РГР
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Info_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Top_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Top_Info__Label = new System.Windows.Forms.Label();
            this.Adjacency_TextBox = new System.Windows.Forms.TextBox();
            this.Adjacency_Label = new System.Windows.Forms.Label();
            this.Result_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Result_Button = new System.Windows.Forms.Button();
            this.ClearList_Button = new System.Windows.Forms.Button();
            this.CountTop_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountTop_Label = new System.Windows.Forms.Label();
            this.Alert_Label = new System.Windows.Forms.Label();
            this.AdditInfo_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Top_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTop_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_RichTextBox
            // 
            this.Info_RichTextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.Info_RichTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.Info_RichTextBox.Location = new System.Drawing.Point(13, 13);
            this.Info_RichTextBox.Name = "Info_RichTextBox";
            this.Info_RichTextBox.ReadOnly = true;
            this.Info_RichTextBox.Size = new System.Drawing.Size(429, 90);
            this.Info_RichTextBox.TabIndex = 0;
            this.Info_RichTextBox.Text = "Хусамов Альберт ПРО-222\nРГР Вариант №17\nЗадание:\nОрграф, заданный с помощью списк" +
    "ов смежности, проверить на наличие\nциклов и при их наличии вывести каждый цикл в" +
    " виде вершин циклического пути.";
            // 
            // Top_NumericUpDown
            // 
            this.Top_NumericUpDown.BackColor = System.Drawing.Color.MintCream;
            this.Top_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_NumericUpDown.ForeColor = System.Drawing.Color.DarkGreen;
            this.Top_NumericUpDown.Location = new System.Drawing.Point(75, 135);
            this.Top_NumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Top_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Top_NumericUpDown.Name = "Top_NumericUpDown";
            this.Top_NumericUpDown.Size = new System.Drawing.Size(32, 21);
            this.Top_NumericUpDown.TabIndex = 1;
            this.Top_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Top_NumericUpDown.ValueChanged += new System.EventHandler(this.Top_NumericUpDown_ValueChanged);
            // 
            // Top_Info__Label
            // 
            this.Top_Info__Label.AutoSize = true;
            this.Top_Info__Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Top_Info__Label.Location = new System.Drawing.Point(10, 137);
            this.Top_Info__Label.Name = "Top_Info__Label";
            this.Top_Info__Label.Size = new System.Drawing.Size(62, 15);
            this.Top_Info__Label.TabIndex = 2;
            this.Top_Info__Label.Text = "Вершина:";
            // 
            // Adjacency_TextBox
            // 
            this.Adjacency_TextBox.BackColor = System.Drawing.Color.MintCream;
            this.Adjacency_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adjacency_TextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.Adjacency_TextBox.Location = new System.Drawing.Point(12, 195);
            this.Adjacency_TextBox.Name = "Adjacency_TextBox";
            this.Adjacency_TextBox.Size = new System.Drawing.Size(367, 21);
            this.Adjacency_TextBox.TabIndex = 3;
            this.Adjacency_TextBox.Click += new System.EventHandler(this.Adjacency_TextBox_Click);
            this.Adjacency_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Adjacency_TextBox_KeyDown);
            // 
            // Adjacency_Label
            // 
            this.Adjacency_Label.AutoSize = true;
            this.Adjacency_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adjacency_Label.Location = new System.Drawing.Point(10, 159);
            this.Adjacency_Label.Name = "Adjacency_Label";
            this.Adjacency_Label.Size = new System.Drawing.Size(227, 15);
            this.Adjacency_Label.TabIndex = 4;
            this.Adjacency_Label.Text = "Введите вершины смежные с данной:";
            // 
            // Result_RichTextBox
            // 
            this.Result_RichTextBox.BackColor = System.Drawing.Color.MintCream;
            this.Result_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_RichTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.Result_RichTextBox.Location = new System.Drawing.Point(487, 40);
            this.Result_RichTextBox.Name = "Result_RichTextBox";
            this.Result_RichTextBox.Size = new System.Drawing.Size(301, 185);
            this.Result_RichTextBox.TabIndex = 5;
            this.Result_RichTextBox.Text = "";
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_Label.Location = new System.Drawing.Point(483, 13);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(108, 24);
            this.Result_Label.TabIndex = 6;
            this.Result_Label.Text = "Результат:";
            // 
            // Result_Button
            // 
            this.Result_Button.BackColor = System.Drawing.Color.MintCream;
            this.Result_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Result_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Result_Button.Location = new System.Drawing.Point(13, 222);
            this.Result_Button.Name = "Result_Button";
            this.Result_Button.Size = new System.Drawing.Size(169, 23);
            this.Result_Button.TabIndex = 7;
            this.Result_Button.Text = "Проверить на наличие циклов";
            this.Result_Button.UseVisualStyleBackColor = false;
            this.Result_Button.Click += new System.EventHandler(this.Result_Button_Click);
            // 
            // ClearList_Button
            // 
            this.ClearList_Button.BackColor = System.Drawing.Color.MistyRose;
            this.ClearList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearList_Button.ForeColor = System.Drawing.Color.Firebrick;
            this.ClearList_Button.Location = new System.Drawing.Point(187, 222);
            this.ClearList_Button.Name = "ClearList_Button";
            this.ClearList_Button.Size = new System.Drawing.Size(170, 23);
            this.ClearList_Button.TabIndex = 9;
            this.ClearList_Button.Text = "Очистить список смежностей";
            this.ClearList_Button.UseVisualStyleBackColor = false;
            this.ClearList_Button.Click += new System.EventHandler(this.ClearList_Button_Click);
            // 
            // CountTop_NumericUpDown
            // 
            this.CountTop_NumericUpDown.BackColor = System.Drawing.Color.MintCream;
            this.CountTop_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTop_NumericUpDown.ForeColor = System.Drawing.Color.DarkGreen;
            this.CountTop_NumericUpDown.Location = new System.Drawing.Point(163, 109);
            this.CountTop_NumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CountTop_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountTop_NumericUpDown.Name = "CountTop_NumericUpDown";
            this.CountTop_NumericUpDown.Size = new System.Drawing.Size(32, 21);
            this.CountTop_NumericUpDown.TabIndex = 10;
            this.CountTop_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountTop_NumericUpDown.ValueChanged += new System.EventHandler(this.CountTop_NumericUpDown_ValueChanged);
            // 
            // CountTop_Label
            // 
            this.CountTop_Label.AutoSize = true;
            this.CountTop_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTop_Label.Location = new System.Drawing.Point(10, 111);
            this.CountTop_Label.Name = "CountTop_Label";
            this.CountTop_Label.Size = new System.Drawing.Size(147, 15);
            this.CountTop_Label.TabIndex = 11;
            this.CountTop_Label.Text = "Кол-во вершин в графе:";
            // 
            // Alert_Label
            // 
            this.Alert_Label.AutoSize = true;
            this.Alert_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alert_Label.ForeColor = System.Drawing.Color.Red;
            this.Alert_Label.Location = new System.Drawing.Point(113, 137);
            this.Alert_Label.Name = "Alert_Label";
            this.Alert_Label.Size = new System.Drawing.Size(0, 15);
            this.Alert_Label.TabIndex = 12;
            // 
            // AdditInfo_Label
            // 
            this.AdditInfo_Label.AutoSize = true;
            this.AdditInfo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditInfo_Label.Location = new System.Drawing.Point(9, 179);
            this.AdditInfo_Label.Name = "AdditInfo_Label";
            this.AdditInfo_Label.Size = new System.Drawing.Size(311, 13);
            this.AdditInfo_Label.TabIndex = 13;
            this.AdditInfo_Label.Text = "(Вершины записывать ч/з пробел. В конце нажать на Enter)";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(814, 281);
            this.Controls.Add(this.AdditInfo_Label);
            this.Controls.Add(this.Alert_Label);
            this.Controls.Add(this.CountTop_Label);
            this.Controls.Add(this.CountTop_NumericUpDown);
            this.Controls.Add(this.ClearList_Button);
            this.Controls.Add(this.Result_Button);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Result_RichTextBox);
            this.Controls.Add(this.Adjacency_Label);
            this.Controls.Add(this.Adjacency_TextBox);
            this.Controls.Add(this.Top_Info__Label);
            this.Controls.Add(this.Top_NumericUpDown);
            this.Controls.Add(this.Info_RichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "РГР Хусамов Альберт ПРО-222";
            ((System.ComponentModel.ISupportInitialize)(this.Top_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTop_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info_RichTextBox;
        private System.Windows.Forms.NumericUpDown Top_NumericUpDown;
        private System.Windows.Forms.Label Top_Info__Label;
        private System.Windows.Forms.TextBox Adjacency_TextBox;
        private System.Windows.Forms.Label Adjacency_Label;
        private System.Windows.Forms.RichTextBox Result_RichTextBox;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button Result_Button;
        private System.Windows.Forms.Button ClearList_Button;
        private System.Windows.Forms.NumericUpDown CountTop_NumericUpDown;
        private System.Windows.Forms.Label CountTop_Label;
        private System.Windows.Forms.Label Alert_Label;
        private System.Windows.Forms.Label AdditInfo_Label;
    }
}

