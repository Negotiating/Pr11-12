using System;
using System.Windows.Forms;

namespace PR11_12_WF
{
	class IntArray
	{
		private int[,] _array;
		private int _rows, _columns;
		public IntArray() { }
		public IntArray(int rows, int columns)
		{
			if (rows > 0 && columns > 0)
			{
				_array = new int[rows, columns];
				_rows = rows;
				_columns = columns;
			}
			else throw new Exception("Некорректный размер массива");
		}
		public int quantity
		{
			get
			{
				int null_elements = 0;
				for (int i = 0; i < _rows; ++i)
					for (int j = 0; j < _columns; ++j)
					{
						if (_array[i, j] == 0) null_elements++;
					}
				return null_elements;
			}
		}
		public int scalar
		{
			set
			{
				if (_rows == _columns)
				{
					for (int i = 0; i < _rows; ++i)
						for (int j = 0; j < _columns; ++j)
						{
							if (i == j) _array[i, j] = value;
						}
				}
				else throw new Exception("Массив не является квадратным");
			}
		}
		public void random_array()
		{
			Random rand = new Random();
			for (int i = 0; i < _rows; i++)
				for (int j = 0; j < _columns; j++)
					_array[i, j] = rand.Next(-5, 5);
		}
		public void input_array()
		{
			for (int i = 0; i < _rows; ++i)
				for (int j = 0; j < _columns; ++j)
				{
					Console.Write($"array[{i}, {j}] = ");
					_array[i, j] = Convert.ToInt32(Console.ReadLine());
				}
		}
		public void output_array(DataGridView tabel)
		{
			tabel.RowCount = _rows;
			tabel.ColumnCount = _columns;
			for (int i = 0; i < _rows; ++i)
			{
				for (int j = 0; j < _columns; ++j)
				{
					tabel.Columns[j].Width = 30;
					tabel.Rows[i].Cells[j].Value = _array[i, j];
				}

			}

		}
		public int sum_array(int column)
		{
			int sum = 0;
			for (int i = 0; i < _rows; i++)
				sum += _array[i, column];
			return sum;
		}
		public int this[int i, int j]
		{
			get
			{
				if (i < 0 || i > _rows && j < 0 || j > _columns)
				{
					throw new Exception("Не корректно задан индекс!!!");
				}
				return _array[i, j];
			}
			set
			{
				if (i < 0 || i > _rows && j < 0 || j > _columns)
				{
					throw new Exception("Не корректно задан индекс!!!");
				}
				_array[i, j] = value;
			}
		}
		public static implicit operator int[,] (IntArray mas)
		{
			return mas._array;
		}

		public static implicit operator IntArray(int[,] array)
		{
			IntArray result = new IntArray();
			result._rows = array.GetLength(0);
			result._columns = array.GetLength(1);
			result._array = array;
			return result;
		}
		public static IntArray operator ++(IntArray array)
		{
			for (int i = 0; i < array._rows; i++)
				for (int j = 0; j < array._columns; j++)
					array[i, j]++;
			return array;
		}
		public static IntArray operator --(IntArray array)
		{
			for (int i = 0; i < array._rows; i++)
				for (int j = 0; j < array._columns; j++)
					array[i, j]--;
			return array;
		}
		public static IntArray operator +(IntArray array1, IntArray array2)
		{
			if (array1._columns == array2._columns && array1._rows == array2._rows)
			{
				IntArray rez = new IntArray(array1._rows, array1._columns);
				for (int i = 0; i < rez._rows; i++)
					for (int j = 0; j < rez._columns; j++)
					{
						rez[i, j] = array1[i, j] + array2[i, j];
					}
				return rez;
			}
			else
			{
				throw new Exception("Массивы имеют разные размеры!");
				return null;
			}
		}
		public static bool operator true(IntArray array)
		{
			if (array._columns == array._rows) return true;
			else return false;
		}
		public static bool operator false(IntArray array)
		{
			if (array._columns != array._rows) return false;
			else return true;
		}
	}
}
