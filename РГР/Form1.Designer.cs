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
            this.Result_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Result_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.AdjList_Label = new System.Windows.Forms.Label();
            this.Canvas_Panel = new System.Windows.Forms.Panel();
            this.AdjList_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Info_RichTextBox
            // 
            this.Info_RichTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Info_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_RichTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Info_RichTextBox.Location = new System.Drawing.Point(13, 13);
            this.Info_RichTextBox.Name = "Info_RichTextBox";
            this.Info_RichTextBox.ReadOnly = true;
            this.Info_RichTextBox.Size = new System.Drawing.Size(429, 90);
            this.Info_RichTextBox.TabIndex = 0;
            this.Info_RichTextBox.Text = "Хусамов Альберт ПРО-222\nВариант №17\nЗадание:\nОрграф, заданный с помощью списков с" +
    "межности, проверить на наличие\nциклов и при их наличии вывести каждый цикл в вид" +
    "е вершин циклического пути.";
            // 
            // Result_RichTextBox
            // 
            this.Result_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result_RichTextBox.BackColor = System.Drawing.Color.MintCream;
            this.Result_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_RichTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.Result_RichTextBox.Location = new System.Drawing.Point(649, 40);
            this.Result_RichTextBox.Name = "Result_RichTextBox";
            this.Result_RichTextBox.Size = new System.Drawing.Size(383, 449);
            this.Result_RichTextBox.TabIndex = 5;
            this.Result_RichTextBox.Text = "";
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result_Label.Location = new System.Drawing.Point(645, 13);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(108, 24);
            this.Result_Label.TabIndex = 6;
            this.Result_Label.Text = "Результат:";
            // 
            // Result_Button
            // 
            this.Result_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Result_Button.BackColor = System.Drawing.Color.MintCream;
            this.Result_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Result_Button.ForeColor = System.Drawing.Color.SeaGreen;
            this.Result_Button.Location = new System.Drawing.Point(15, 466);
            this.Result_Button.Name = "Result_Button";
            this.Result_Button.Size = new System.Drawing.Size(169, 23);
            this.Result_Button.TabIndex = 7;
            this.Result_Button.Text = "Проверить на наличие циклов";
            this.Result_Button.UseVisualStyleBackColor = false;
            this.Result_Button.Click += new System.EventHandler(this.Result_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear_Button.BackColor = System.Drawing.Color.MistyRose;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_Button.ForeColor = System.Drawing.Color.Firebrick;
            this.Clear_Button.Location = new System.Drawing.Point(190, 466);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(170, 23);
            this.Clear_Button.TabIndex = 9;
            this.Clear_Button.Text = "Очистить список смежностей";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // AdjList_Label
            // 
            this.AdjList_Label.AutoSize = true;
            this.AdjList_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdjList_Label.Location = new System.Drawing.Point(448, 13);
            this.AdjList_Label.Name = "AdjList_Label";
            this.AdjList_Label.Size = new System.Drawing.Size(186, 24);
            this.AdjList_Label.TabIndex = 14;
            this.AdjList_Label.Text = "Список смежности:";
            // 
            // Canvas_Panel
            // 
            this.Canvas_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Canvas_Panel.BackColor = System.Drawing.Color.MintCream;
            this.Canvas_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas_Panel.Location = new System.Drawing.Point(15, 107);
            this.Canvas_Panel.Name = "Canvas_Panel";
            this.Canvas_Panel.Size = new System.Drawing.Size(426, 353);
            this.Canvas_Panel.TabIndex = 16;
            this.Canvas_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_Panel_MouseDown);
            // 
            // AdjList_RichTextBox
            // 
            this.AdjList_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdjList_RichTextBox.BackColor = System.Drawing.Color.MintCream;
            this.AdjList_RichTextBox.Location = new System.Drawing.Point(449, 41);
            this.AdjList_RichTextBox.Name = "AdjList_RichTextBox";
            this.AdjList_RichTextBox.ReadOnly = true;
            this.AdjList_RichTextBox.Size = new System.Drawing.Size(194, 448);
            this.AdjList_RichTextBox.TabIndex = 17;
            this.AdjList_RichTextBox.Text = "";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1044, 501);
            this.Controls.Add(this.AdjList_RichTextBox);
            this.Controls.Add(this.Canvas_Panel);
            this.Controls.Add(this.AdjList_Label);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Result_Button);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Result_RichTextBox);
            this.Controls.Add(this.Info_RichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1060, 540);
            this.Name = "Main_Form";
            this.Text = "РГР Хусамов Альберт ПРО-222";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info_RichTextBox;
        private System.Windows.Forms.RichTextBox Result_RichTextBox;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button Result_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label AdjList_Label;
        private System.Windows.Forms.Panel Canvas_Panel;
        private System.Windows.Forms.RichTextBox AdjList_RichTextBox;
    }
}

