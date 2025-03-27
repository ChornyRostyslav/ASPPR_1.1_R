namespace ASPPR_1._1_R
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_FindInverseMatrix = new System.Windows.Forms.Button();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.dataGridViewReverse = new System.Windows.Forms.DataGridView();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.btn_Rank = new System.Windows.Forms.Button();
            this.btn_FindSolution = new System.Windows.Forms.Button();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxLogging = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FindInverseMatrix
            // 
            this.btn_FindInverseMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_FindInverseMatrix.Location = new System.Drawing.Point(486, 36);
            this.btn_FindInverseMatrix.Name = "btn_FindInverseMatrix";
            this.btn_FindInverseMatrix.Size = new System.Drawing.Size(263, 46);
            this.btn_FindInverseMatrix.TabIndex = 0;
            this.btn_FindInverseMatrix.Text = "Знайти обернену матрицю";
            this.btn_FindInverseMatrix.UseVisualStyleBackColor = true;
            this.btn_FindInverseMatrix.Click += new System.EventHandler(this.btn_FindInverseMatrix_Click);
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.AllowUserToDeleteRows = false;
            this.dataGridViewA.AllowUserToResizeColumns = false;
            this.dataGridViewA.AllowUserToResizeRows = false;
            this.dataGridViewA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewA.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewA.Enabled = false;
            this.dataGridViewA.GridColor = System.Drawing.Color.White;
            this.dataGridViewA.Location = new System.Drawing.Point(66, 36);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersVisible = false;
            this.dataGridViewA.Size = new System.Drawing.Size(205, 183);
            this.dataGridViewA.TabIndex = 6;
            // 
            // dataGridViewReverse
            // 
            this.dataGridViewReverse.AllowUserToAddRows = false;
            this.dataGridViewReverse.AllowUserToDeleteRows = false;
            this.dataGridViewReverse.AllowUserToResizeColumns = false;
            this.dataGridViewReverse.AllowUserToResizeRows = false;
            this.dataGridViewReverse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReverse.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReverse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReverse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReverse.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReverse.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReverse.Enabled = false;
            this.dataGridViewReverse.GridColor = System.Drawing.Color.White;
            this.dataGridViewReverse.Location = new System.Drawing.Point(66, 300);
            this.dataGridViewReverse.Name = "dataGridViewReverse";
            this.dataGridViewReverse.RowHeadersVisible = false;
            this.dataGridViewReverse.Size = new System.Drawing.Size(205, 183);
            this.dataGridViewReverse.TabIndex = 7;
            // 
            // txtRank
            // 
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtRank.Location = new System.Drawing.Point(66, 244);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(100, 29);
            this.txtRank.TabIndex = 8;
            // 
            // btn_Rank
            // 
            this.btn_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Rank.Location = new System.Drawing.Point(486, 104);
            this.btn_Rank.Name = "btn_Rank";
            this.btn_Rank.Size = new System.Drawing.Size(263, 46);
            this.btn_Rank.TabIndex = 9;
            this.btn_Rank.Text = "Знайти ранг матриці";
            this.btn_Rank.UseVisualStyleBackColor = true;
            this.btn_Rank.Click += new System.EventHandler(this.btn_Rank_Click);
            // 
            // btn_FindSolution
            // 
            this.btn_FindSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_FindSolution.Location = new System.Drawing.Point(486, 173);
            this.btn_FindSolution.Name = "btn_FindSolution";
            this.btn_FindSolution.Size = new System.Drawing.Size(263, 46);
            this.btn_FindSolution.TabIndex = 10;
            this.btn_FindSolution.Text = "Обчислити СЛАУ";
            this.btn_FindSolution.UseVisualStyleBackColor = true;
            this.btn_FindSolution.Click += new System.EventHandler(this.btn_FindSolution_Click);
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AllowUserToDeleteRows = false;
            this.dataGridViewB.AllowUserToResizeColumns = false;
            this.dataGridViewB.AllowUserToResizeRows = false;
            this.dataGridViewB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewB.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewB.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewB.Enabled = false;
            this.dataGridViewB.GridColor = System.Drawing.Color.White;
            this.dataGridViewB.Location = new System.Drawing.Point(341, 36);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersVisible = false;
            this.dataGridViewB.Size = new System.Drawing.Size(73, 183);
            this.dataGridViewB.TabIndex = 11;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewResult.Enabled = false;
            this.dataGridViewResult.GridColor = System.Drawing.Color.White;
            this.dataGridViewResult.Location = new System.Drawing.Point(341, 300);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.Size = new System.Drawing.Size(73, 183);
            this.dataGridViewResult.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ранг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Обернена матриця:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "X:";
            // 
            // checkBoxLogging
            // 
            this.checkBoxLogging.AutoSize = true;
            this.checkBoxLogging.Location = new System.Drawing.Point(486, 300);
            this.checkBoxLogging.Name = "checkBoxLogging";
            this.checkBoxLogging.Size = new System.Drawing.Size(110, 17);
            this.checkBoxLogging.TabIndex = 18;
            this.checkBoxLogging.Text = "Логувати у файл";
            this.checkBoxLogging.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 530);
            this.Controls.Add(this.checkBoxLogging);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.btn_FindSolution);
            this.Controls.Add(this.btn_Rank);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.dataGridViewReverse);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.btn_FindInverseMatrix);
            this.Name = "Form1";
            this.Text = "Chornyi 631";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FindInverseMatrix;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.DataGridView dataGridViewReverse;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Button btn_Rank;
        private System.Windows.Forms.Button btn_FindSolution;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxLogging;
    }
}

