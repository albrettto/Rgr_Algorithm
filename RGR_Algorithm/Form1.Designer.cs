namespace RGR_Algorithm
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
            this.Canvas_Panel = new System.Windows.Forms.Panel();
            this.Input_TextBox = new System.Windows.Forms.TextBox();
            this.Instruct_Label = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Result_TextBox = new System.Windows.Forms.TextBox();
            this.Result_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info_RichTextBox
            // 
            this.Info_RichTextBox.BackColor = System.Drawing.Color.MintCream;
            this.Info_RichTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Info_RichTextBox.Location = new System.Drawing.Point(12, 12);
            this.Info_RichTextBox.Name = "Info_RichTextBox";
            this.Info_RichTextBox.ReadOnly = true;
            this.Info_RichTextBox.Size = new System.Drawing.Size(377, 65);
            this.Info_RichTextBox.TabIndex = 0;
            this.Info_RichTextBox.Text = "Хусамов Альберт ПРО-222\nРГР Вариант №3\nЗадание:\nНапишите программу поиска, включе" +
    "ния и исключения из Б-дерева.";
            // 
            // Canvas_Panel
            // 
            this.Canvas_Panel.BackColor = System.Drawing.Color.Honeydew;
            this.Canvas_Panel.Location = new System.Drawing.Point(395, 12);
            this.Canvas_Panel.Name = "Canvas_Panel";
            this.Canvas_Panel.Size = new System.Drawing.Size(627, 747);
            this.Canvas_Panel.TabIndex = 1;
            // 
            // Input_TextBox
            // 
            this.Input_TextBox.BackColor = System.Drawing.Color.MintCream;
            this.Input_TextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.Input_TextBox.Location = new System.Drawing.Point(12, 134);
            this.Input_TextBox.Name = "Input_TextBox";
            this.Input_TextBox.Size = new System.Drawing.Size(377, 20);
            this.Input_TextBox.TabIndex = 2;
            // 
            // Instruct_Label
            // 
            this.Instruct_Label.AutoSize = true;
            this.Instruct_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instruct_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Instruct_Label.Location = new System.Drawing.Point(9, 116);
            this.Instruct_Label.Name = "Instruct_Label";
            this.Instruct_Label.Size = new System.Drawing.Size(368, 15);
            this.Instruct_Label.TabIndex = 3;
            this.Instruct_Label.Text = "Введите число, которое хотите найти, добавить или удалить:";
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.DarkGreen;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_Button.ForeColor = System.Drawing.Color.MintCream;
            this.Search_Button.Location = new System.Drawing.Point(12, 160);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 4;
            this.Search_Button.Text = "Найти";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.DarkGreen;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Button.ForeColor = System.Drawing.Color.MintCream;
            this.Add_Button.Location = new System.Drawing.Point(93, 160);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 5;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.DarkGreen;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Button.ForeColor = System.Drawing.Color.MintCream;
            this.Delete_Button.Location = new System.Drawing.Point(174, 160);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Удалить";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.BackColor = System.Drawing.Color.MintCream;
            this.Result_TextBox.Enabled = false;
            this.Result_TextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.Result_TextBox.Location = new System.Drawing.Point(12, 229);
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.ReadOnly = true;
            this.Result_TextBox.Size = new System.Drawing.Size(377, 20);
            this.Result_TextBox.TabIndex = 7;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Result_Label.Location = new System.Drawing.Point(12, 211);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(71, 15);
            this.Result_Label.TabIndex = 8;
            this.Result_Label.Text = "Результат:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1034, 771);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Result_TextBox);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Instruct_Label);
            this.Controls.Add(this.Input_TextBox);
            this.Controls.Add(this.Canvas_Panel);
            this.Controls.Add(this.Info_RichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1050, 810);
            this.MinimumSize = new System.Drawing.Size(1050, 810);
            this.Name = "Main_Form";
            this.Text = "РГР Хусамов Альберт ПРО-222";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info_RichTextBox;
        private System.Windows.Forms.Panel Canvas_Panel;
        private System.Windows.Forms.TextBox Input_TextBox;
        private System.Windows.Forms.Label Instruct_Label;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox Result_TextBox;
        private System.Windows.Forms.Label Result_Label;
    }
}

