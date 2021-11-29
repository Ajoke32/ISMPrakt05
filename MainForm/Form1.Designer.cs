
namespace MainForm
{
    partial class Form1
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
            this.dataGridViewArr = new System.Windows.Forms.DataGridView();
            this.buttonRand = new System.Windows.Forms.Button();
            this.labelQer = new System.Windows.Forms.Label();
            this.numericUpDownCoubt = new System.Windows.Forms.NumericUpDown();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelsum = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.labelMx = new System.Windows.Forms.Label();
            this.labelind = new System.Windows.Forms.Label();
            this.labelpairind = new System.Windows.Forms.Label();
            this.labelmaxindres = new System.Windows.Forms.Label();
            this.labelmaxid = new System.Windows.Forms.Label();
            this.labelmodulres = new System.Windows.Forms.Label();
            this.labelmodulmax = new System.Windows.Forms.Label();
            this.labelindres = new System.Windows.Forms.Label();
            this.labelindsum = new System.Windows.Forms.Label();
            this.labelcountres = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoubt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArr
            // 
            this.dataGridViewArr.AllowUserToDeleteRows = false;
            this.dataGridViewArr.AllowUserToResizeRows = false;
            this.dataGridViewArr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArr.Location = new System.Drawing.Point(16, 355);
            this.dataGridViewArr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewArr.Name = "dataGridViewArr";
            this.dataGridViewArr.Size = new System.Drawing.Size(578, 85);
            this.dataGridViewArr.TabIndex = 0;
            this.dataGridViewArr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArr_CellContentClick);
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(16, 324);
            this.buttonRand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(298, 26);
            this.buttonRand.TabIndex = 1;
            this.buttonRand.Text = "Згенерувати масив та виконати завдання ";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.buttonRand_Click);
            // 
            // labelQer
            // 
            this.labelQer.AutoSize = true;
            this.labelQer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQer.Location = new System.Drawing.Point(104, 27);
            this.labelQer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQer.Name = "labelQer";
            this.labelQer.Size = new System.Drawing.Size(212, 17);
            this.labelQer.TabIndex = 2;
            this.labelQer.Text = "Кількість елементів масиву";
            // 
            // numericUpDownCoubt
            // 
            this.numericUpDownCoubt.Location = new System.Drawing.Point(324, 25);
            this.numericUpDownCoubt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCoubt.Name = "numericUpDownCoubt";
            this.numericUpDownCoubt.Size = new System.Drawing.Size(43, 23);
            this.numericUpDownCoubt.TabIndex = 3;
            this.numericUpDownCoubt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCoubt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(25, 81);
            this.labelRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(178, 17);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "Сума від\'ємних елементів:";
            this.labelRes.Visible = false;
            this.labelRes.Click += new System.EventHandler(this.labelRes_Click);
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsum.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelsum.Location = new System.Drawing.Point(200, 81);
            this.labelsum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(37, 17);
            this.labelsum.TabIndex = 5;
            this.labelsum.Text = "sum";
            this.labelsum.Visible = false;
            this.labelsum.Click += new System.EventHandler(this.labelsum_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelresult.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelresult.Location = new System.Drawing.Point(346, 112);
            this.labelresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(40, 17);
            this.labelresult.TabIndex = 6;
            this.labelresult.Text = "resu";
            this.labelresult.Visible = false;
            this.labelresult.Click += new System.EventHandler(this.labelresult_Click);
            // 
            // labelMx
            // 
            this.labelMx.AutoSize = true;
            this.labelMx.Location = new System.Drawing.Point(25, 112);
            this.labelMx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMx.Name = "labelMx";
            this.labelMx.Size = new System.Drawing.Size(322, 17);
            this.labelMx.TabIndex = 7;
            this.labelMx.Text = "Mаксимальний серед парних елементів масиву:";
            this.labelMx.Visible = false;
            // 
            // labelind
            // 
            this.labelind.AutoSize = true;
            this.labelind.Location = new System.Drawing.Point(24, 146);
            this.labelind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelind.Name = "labelind";
            this.labelind.Size = new System.Drawing.Size(352, 17);
            this.labelind.TabIndex = 8;
            this.labelind.Text = "Добуток елементів масиву, що мають парні індекси:";
            this.labelind.Visible = false;
            // 
            // labelpairind
            // 
            this.labelpairind.AutoSize = true;
            this.labelpairind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelpairind.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelpairind.Location = new System.Drawing.Point(374, 146);
            this.labelpairind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpairind.Name = "labelpairind";
            this.labelpairind.Size = new System.Drawing.Size(32, 17);
            this.labelpairind.TabIndex = 9;
            this.labelpairind.Text = "red";
            this.labelpairind.Visible = false;
            // 
            // labelmaxindres
            // 
            this.labelmaxindres.AutoSize = true;
            this.labelmaxindres.Location = new System.Drawing.Point(25, 177);
            this.labelmaxindres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmaxindres.Name = "labelmaxindres";
            this.labelmaxindres.Size = new System.Drawing.Size(275, 17);
            this.labelmaxindres.TabIndex = 10;
            this.labelmaxindres.Text = "Iндекс максимального елемента масиву:";
            this.labelmaxindres.Visible = false;
            // 
            // labelmaxid
            // 
            this.labelmaxid.AutoSize = true;
            this.labelmaxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmaxid.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelmaxid.Location = new System.Drawing.Point(301, 177);
            this.labelmaxid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmaxid.Name = "labelmaxid";
            this.labelmaxid.Size = new System.Drawing.Size(52, 17);
            this.labelmaxid.TabIndex = 11;
            this.labelmaxid.Text = "label4";
            this.labelmaxid.Visible = false;
            // 
            // labelmodulres
            // 
            this.labelmodulres.AutoSize = true;
            this.labelmodulres.Location = new System.Drawing.Point(25, 208);
            this.labelmodulres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmodulres.Name = "labelmodulres";
            this.labelmodulres.Size = new System.Drawing.Size(299, 17);
            this.labelmodulres.TabIndex = 12;
            this.labelmodulres.Text = "Mаксимальний за модулем елемент масиву:";
            this.labelmodulres.Visible = false;
            // 
            // labelmodulmax
            // 
            this.labelmodulmax.AutoSize = true;
            this.labelmodulmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmodulmax.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelmodulmax.Location = new System.Drawing.Point(321, 208);
            this.labelmodulmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmodulmax.Name = "labelmodulmax";
            this.labelmodulmax.Size = new System.Drawing.Size(52, 17);
            this.labelmodulmax.TabIndex = 13;
            this.labelmodulmax.Text = "label6";
            this.labelmodulmax.Visible = false;
            // 
            // labelindres
            // 
            this.labelindres.AutoSize = true;
            this.labelindres.Location = new System.Drawing.Point(24, 240);
            this.labelindres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelindres.Name = "labelindres";
            this.labelindres.Size = new System.Drawing.Size(235, 17);
            this.labelindres.TabIndex = 14;
            this.labelindres.Text = "Cумa індексів додатних елементів:";
            this.labelindres.Visible = false;
            // 
            // labelindsum
            // 
            this.labelindsum.AutoSize = true;
            this.labelindsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelindsum.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelindsum.Location = new System.Drawing.Point(254, 240);
            this.labelindsum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelindsum.Name = "labelindsum";
            this.labelindsum.Size = new System.Drawing.Size(52, 17);
            this.labelindsum.TabIndex = 15;
            this.labelindsum.Text = "label1";
            this.labelindsum.Visible = false;
            // 
            // labelcountres
            // 
            this.labelcountres.AutoSize = true;
            this.labelcountres.Location = new System.Drawing.Point(24, 275);
            this.labelcountres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcountres.Name = "labelcountres";
            this.labelcountres.Size = new System.Drawing.Size(256, 17);
            this.labelcountres.TabIndex = 16;
            this.labelcountres.Text = "Kількість непарних елементів масиву:";
            this.labelcountres.Visible = false;
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcount.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelcount.Location = new System.Drawing.Point(278, 275);
            this.labelcount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(78, 17);
            this.labelcount.TabIndex = 17;
            this.labelcount.Text = "labelcoun";
            this.labelcount.Visible = false;
            this.labelcount.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 455);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelcountres);
            this.Controls.Add(this.labelindsum);
            this.Controls.Add(this.labelindres);
            this.Controls.Add(this.labelmodulmax);
            this.Controls.Add(this.labelmodulres);
            this.Controls.Add(this.labelmaxid);
            this.Controls.Add(this.labelmaxindres);
            this.Controls.Add(this.labelpairind);
            this.Controls.Add(this.labelind);
            this.Controls.Add(this.labelMx);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.labelsum);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.numericUpDownCoubt);
            this.Controls.Add(this.labelQer);
            this.Controls.Add(this.buttonRand);
            this.Controls.Add(this.dataGridViewArr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoubt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArr;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Label labelQer;
        private System.Windows.Forms.NumericUpDown numericUpDownCoubt;
        private System.Windows.Forms.Label labelRes;
        public System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Label labelMx;
        private System.Windows.Forms.Label labelind;
        private System.Windows.Forms.Label labelpairind;
        private System.Windows.Forms.Label labelmaxindres;
        private System.Windows.Forms.Label labelmaxid;
        private System.Windows.Forms.Label labelmodulres;
        private System.Windows.Forms.Label labelmodulmax;
        private System.Windows.Forms.Label labelindres;
        private System.Windows.Forms.Label labelindsum;
        private System.Windows.Forms.Label labelcountres;
        private System.Windows.Forms.Label labelcount;
    }
}

