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
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1035, 579);
            this.Controls.Add(this.Info_RichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "РГР Хусамов Альберт ПРО-222";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info_RichTextBox;
    }
}

