namespace PR11_12_WF
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
			this.PR11_box = new System.Windows.Forms.GroupBox();
			this.sum_box = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.diagonal_box = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.column_box = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Execute = new System.Windows.Forms.Button();
			this.columns_box = new System.Windows.Forms.TextBox();
			this.rows_box = new System.Windows.Forms.TextBox();
			this.array_tabel = new System.Windows.Forms.DataGridView();
			this.PR12_box = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.increment_tabel = new System.Windows.Forms.DataGridView();
			this.decrement_tabel = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.sum_tabel = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.second_tabel = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.ToIntArray_tabel = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.PR11_box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.array_tabel)).BeginInit();
			this.PR12_box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.increment_tabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.decrement_tabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sum_tabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.second_tabel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ToIntArray_tabel)).BeginInit();
			this.SuspendLayout();
			// 
			// PR11_box
			// 
			this.PR11_box.Controls.Add(this.label9);
			this.PR11_box.Controls.Add(this.second_tabel);
			this.PR11_box.Controls.Add(this.sum_box);
			this.PR11_box.Controls.Add(this.label5);
			this.PR11_box.Controls.Add(this.diagonal_box);
			this.PR11_box.Controls.Add(this.label4);
			this.PR11_box.Controls.Add(this.column_box);
			this.PR11_box.Controls.Add(this.label3);
			this.PR11_box.Controls.Add(this.label2);
			this.PR11_box.Controls.Add(this.label1);
			this.PR11_box.Controls.Add(this.Execute);
			this.PR11_box.Controls.Add(this.columns_box);
			this.PR11_box.Controls.Add(this.rows_box);
			this.PR11_box.Controls.Add(this.array_tabel);
			this.PR11_box.Location = new System.Drawing.Point(8, 8);
			this.PR11_box.Name = "PR11_box";
			this.PR11_box.Size = new System.Drawing.Size(486, 399);
			this.PR11_box.TabIndex = 0;
			this.PR11_box.TabStop = false;
			this.PR11_box.Text = "Практическая 11";
			// 
			// sum_box
			// 
			this.sum_box.Location = new System.Drawing.Point(206, 188);
			this.sum_box.Name = "sum_box";
			this.sum_box.Size = new System.Drawing.Size(67, 22);
			this.sum_box.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(194, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Сумма выбранного столбца:";
			// 
			// diagonal_box
			// 
			this.diagonal_box.Location = new System.Drawing.Point(413, 152);
			this.diagonal_box.Name = "diagonal_box";
			this.diagonal_box.Size = new System.Drawing.Size(67, 22);
			this.diagonal_box.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(252, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Значение для главной диагонали:";
			// 
			// column_box
			// 
			this.column_box.Location = new System.Drawing.Point(413, 98);
			this.column_box.Name = "column_box";
			this.column_box.Size = new System.Drawing.Size(67, 22);
			this.column_box.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(252, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Столбец:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(252, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Количество столбцов:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(252, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Количество строк:";
			// 
			// Execute
			// 
			this.Execute.Location = new System.Drawing.Point(355, 305);
			this.Execute.Name = "Execute";
			this.Execute.Size = new System.Drawing.Size(103, 37);
			this.Execute.TabIndex = 3;
			this.Execute.Text = "Выполнить";
			this.Execute.UseVisualStyleBackColor = true;
			this.Execute.Click += new System.EventHandler(this.Execute_Click);
			// 
			// columns_box
			// 
			this.columns_box.Location = new System.Drawing.Point(413, 61);
			this.columns_box.Name = "columns_box";
			this.columns_box.Size = new System.Drawing.Size(67, 22);
			this.columns_box.TabIndex = 2;
			// 
			// rows_box
			// 
			this.rows_box.Location = new System.Drawing.Point(413, 21);
			this.rows_box.Name = "rows_box";
			this.rows_box.Size = new System.Drawing.Size(67, 22);
			this.rows_box.TabIndex = 1;
			// 
			// array_tabel
			// 
			this.array_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.array_tabel.Location = new System.Drawing.Point(6, 21);
			this.array_tabel.Name = "array_tabel";
			this.array_tabel.RowTemplate.Height = 24;
			this.array_tabel.Size = new System.Drawing.Size(240, 150);
			this.array_tabel.TabIndex = 0;
			// 
			// PR12_box
			// 
			this.PR12_box.Controls.Add(this.label10);
			this.PR12_box.Controls.Add(this.ToIntArray_tabel);
			this.PR12_box.Controls.Add(this.label8);
			this.PR12_box.Controls.Add(this.sum_tabel);
			this.PR12_box.Controls.Add(this.label7);
			this.PR12_box.Controls.Add(this.decrement_tabel);
			this.PR12_box.Controls.Add(this.label6);
			this.PR12_box.Controls.Add(this.increment_tabel);
			this.PR12_box.Location = new System.Drawing.Point(500, 8);
			this.PR12_box.Name = "PR12_box";
			this.PR12_box.Size = new System.Drawing.Size(557, 399);
			this.PR12_box.TabIndex = 1;
			this.PR12_box.TabStop = false;
			this.PR12_box.Text = "Практическая 12";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "Инкремент:";
			// 
			// increment_tabel
			// 
			this.increment_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.increment_tabel.Location = new System.Drawing.Point(6, 46);
			this.increment_tabel.Name = "increment_tabel";
			this.increment_tabel.RowTemplate.Height = 24;
			this.increment_tabel.Size = new System.Drawing.Size(240, 150);
			this.increment_tabel.TabIndex = 1;
			// 
			// decrement_tabel
			// 
			this.decrement_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.decrement_tabel.Location = new System.Drawing.Point(252, 46);
			this.decrement_tabel.Name = "decrement_tabel";
			this.decrement_tabel.RowTemplate.Height = 24;
			this.decrement_tabel.Size = new System.Drawing.Size(240, 150);
			this.decrement_tabel.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(249, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "Декремент:";
			// 
			// sum_tabel
			// 
			this.sum_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sum_tabel.Location = new System.Drawing.Point(6, 243);
			this.sum_tabel.Name = "sum_tabel";
			this.sum_tabel.RowTemplate.Height = 24;
			this.sum_tabel.Size = new System.Drawing.Size(240, 150);
			this.sum_tabel.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 223);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 17);
			this.label8.TabIndex = 13;
			this.label8.Text = "Оператор +:";
			// 
			// second_tabel
			// 
			this.second_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.second_tabel.Location = new System.Drawing.Point(9, 243);
			this.second_tabel.Name = "second_tabel";
			this.second_tabel.RowTemplate.Height = 24;
			this.second_tabel.Size = new System.Drawing.Size(240, 150);
			this.second_tabel.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 223);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(156, 17);
			this.label9.TabIndex = 13;
			this.label9.Text = "Массив для сложения:";
			// 
			// ToIntArray_tabel
			// 
			this.ToIntArray_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ToIntArray_tabel.Location = new System.Drawing.Point(252, 243);
			this.ToIntArray_tabel.Name = "ToIntArray_tabel";
			this.ToIntArray_tabel.RowTemplate.Height = 24;
			this.ToIntArray_tabel.Size = new System.Drawing.Size(240, 150);
			this.ToIntArray_tabel.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(249, 206);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(173, 34);
			this.label10.TabIndex = 15;
			this.label10.Text = "Преобразование класса \r\nArray в класс IntArray:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 419);
			this.Controls.Add(this.PR12_box);
			this.Controls.Add(this.PR11_box);
			this.Name = "Form1";
			this.Text = "Практика 11-12";
			this.PR11_box.ResumeLayout(false);
			this.PR11_box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.array_tabel)).EndInit();
			this.PR12_box.ResumeLayout(false);
			this.PR12_box.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.increment_tabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.decrement_tabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sum_tabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.second_tabel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ToIntArray_tabel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox PR11_box;
		private System.Windows.Forms.DataGridView array_tabel;
		private System.Windows.Forms.GroupBox PR12_box;
		private System.Windows.Forms.TextBox columns_box;
		private System.Windows.Forms.TextBox rows_box;
		private System.Windows.Forms.Button Execute;
		private System.Windows.Forms.TextBox column_box;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox diagonal_box;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox sum_box;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView increment_tabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView decrement_tabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView sum_tabel;
		private System.Windows.Forms.DataGridView second_tabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView ToIntArray_tabel;
	}
}

