namespace SpecificationPack
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addSpec1Btn = new System.Windows.Forms.Button();
            this.formBtn = new System.Windows.Forms.Button();
            this.addSpec2Btn = new System.Windows.Forms.Button();
            this.specAlexAvrTBox = new System.Windows.Forms.TextBox();
            this.specAlexTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clrBtn = new System.Windows.Forms.Button();
            this.SpecAlexHelukabel = new System.Windows.Forms.CheckBox();
            this.SpecAlexHelukabelTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Спецификация комплектующих";
            // 
            // addSpec1Btn
            // 
            this.addSpec1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSpec1Btn.Location = new System.Drawing.Point(197, 67);
            this.addSpec1Btn.Name = "addSpec1Btn";
            this.addSpec1Btn.Size = new System.Drawing.Size(99, 36);
            this.addSpec1Btn.TabIndex = 2;
            this.addSpec1Btn.Text = "Добавить спецификацию";
            this.addSpec1Btn.UseVisualStyleBackColor = true;
            this.addSpec1Btn.Click += new System.EventHandler(this.addSpec1Btn_Click);
            // 
            // formBtn
            // 
            this.formBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.formBtn.Location = new System.Drawing.Point(181, 240);
            this.formBtn.Name = "formBtn";
            this.formBtn.Size = new System.Drawing.Size(118, 34);
            this.formBtn.TabIndex = 3;
            this.formBtn.Text = "Сформировать";
            this.formBtn.UseVisualStyleBackColor = true;
            this.formBtn.Click += new System.EventHandler(this.formBtn_Click);
            // 
            // addSpec2Btn
            // 
            this.addSpec2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSpec2Btn.Location = new System.Drawing.Point(200, 185);
            this.addSpec2Btn.Name = "addSpec2Btn";
            this.addSpec2Btn.Size = new System.Drawing.Size(99, 36);
            this.addSpec2Btn.TabIndex = 7;
            this.addSpec2Btn.Text = "Добавить спецификацию";
            this.addSpec2Btn.UseVisualStyleBackColor = true;
            this.addSpec2Btn.Click += new System.EventHandler(this.addSpec2Btn_Click);
            // 
            // specAlexAvrTBox
            // 
            this.specAlexAvrTBox.AllowDrop = true;
            this.specAlexAvrTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.specAlexAvrTBox.Location = new System.Drawing.Point(16, 141);
            this.specAlexAvrTBox.Multiline = true;
            this.specAlexAvrTBox.Name = "specAlexAvrTBox";
            this.specAlexAvrTBox.Size = new System.Drawing.Size(281, 38);
            this.specAlexAvrTBox.TabIndex = 8;
            this.specAlexAvrTBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.specAlexAvrTBox_DragDrop);
            this.specAlexAvrTBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.specAlexAvrTBox_DragEnter);
            // 
            // specAlexTBox
            // 
            this.specAlexTBox.AllowDrop = true;
            this.specAlexTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.specAlexTBox.Location = new System.Drawing.Point(13, 23);
            this.specAlexTBox.Multiline = true;
            this.specAlexTBox.Name = "specAlexTBox";
            this.specAlexTBox.Size = new System.Drawing.Size(281, 38);
            this.specAlexTBox.TabIndex = 8;
            this.specAlexTBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.specAlexTBox_DragDrop);
            this.specAlexTBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.specAlexTBox_DragEnter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Спецификация шкафа";
            // 
            // clrBtn
            // 
            this.clrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clrBtn.Location = new System.Drawing.Point(12, 238);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(99, 36);
            this.clrBtn.TabIndex = 5;
            this.clrBtn.Text = "Очистить";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // SpecAlexHelukabel
            // 
            this.SpecAlexHelukabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecAlexHelukabel.AutoSize = true;
            this.SpecAlexHelukabel.Checked = true;
            this.SpecAlexHelukabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpecAlexHelukabel.Location = new System.Drawing.Point(12, 69);
            this.SpecAlexHelukabel.Name = "SpecAlexHelukabel";
            this.SpecAlexHelukabel.Size = new System.Drawing.Size(152, 17);
            this.SpecAlexHelukabel.TabIndex = 11;
            this.SpecAlexHelukabel.Text = "Домножать Helukabel на";
            this.SpecAlexHelukabel.UseVisualStyleBackColor = true;
            // 
            // SpecAlexHelukabelTxt
            // 
            this.SpecAlexHelukabelTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecAlexHelukabelTxt.Location = new System.Drawing.Point(164, 67);
            this.SpecAlexHelukabelTxt.Name = "SpecAlexHelukabelTxt";
            this.SpecAlexHelukabelTxt.Size = new System.Drawing.Size(27, 20);
            this.SpecAlexHelukabelTxt.TabIndex = 15;
            this.SpecAlexHelukabelTxt.Text = "3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 283);
            this.Controls.Add(this.SpecAlexHelukabelTxt);
            this.Controls.Add(this.SpecAlexHelukabel);
            this.Controls.Add(this.specAlexAvrTBox);
            this.Controls.Add(this.specAlexTBox);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.addSpec2Btn);
            this.Controls.Add(this.formBtn);
            this.Controls.Add(this.addSpec1Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Формирование общей спецификации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSpec1Btn;
        private System.Windows.Forms.Button formBtn;
        private System.Windows.Forms.Button addSpec2Btn;
        private System.Windows.Forms.TextBox specAlexAvrTBox;
        private System.Windows.Forms.TextBox specAlexTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.CheckBox SpecAlexHelukabel;
        private System.Windows.Forms.TextBox SpecAlexHelukabelTxt;
    }
}

