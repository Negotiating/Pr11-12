using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR11_12_WF
{
	public partial class Form1 : Form
	{
		IntArray IntArray;
		public Form1()
		{
			InitializeComponent();
			rows_box.Text = 1.ToString();
			columns_box.Text = 1.ToString();
			diagonal_box.Text = 1.ToString();
			column_box.Text = 0.ToString();
		}

		private void Execute_Click(object sender, EventArgs e)
		{
			
			try
			{
				IntArray = new IntArray(Convert.ToInt32(rows_box.Text), Convert.ToInt32(columns_box.Text));
				IntArray.random_array();
				IntArray.output_array(array_tabel);
				if (IntArray)
				{
					IntArray.scalar = Convert.ToInt32(diagonal_box.Text);
					IntArray.output_array(array_tabel);
				}
				else throw new Exception("Массив не квадраьный");
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			try
			{
				sum_box.Text = IntArray.sum_array(Convert.ToInt32(column_box.Text)).ToString();
				IntArray++.output_array(increment_tabel);
				IntArray--.output_array(decrement_tabel);
				IntArray array = new IntArray(Convert.ToInt32(rows_box.Text), Convert.ToInt32(columns_box.Text));
				array.random_array();
				array.output_array(second_tabel);
				array = array+IntArray;
				array.output_array(sum_tabel);
				int[,] mas = new int[2, 2];
				array = (IntArray)mas;
				array.random_array();
				array.output_array(ToIntArray_tabel);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}
	}
}
