/*Условие:Дана матрица, состоящая из n строк и n столбцов или одномерные массивы из n элементов каждый Составить алгоритм и программу для получения 
и выводов указанных в условии результатов и самих массивов, если изменялись какие-либо их элементы. Алгоритм любой задачи может быть составлен
с использованием единственного двухкратного цикла*/
/*Задача 2.5.2 Условие: Получить массив X1, X2 ...Xn, По правилу Xi = 1, если элемент Aii больше каждого из элементов i-ой строки матрицы,
иначе Xi = 0. Найти так же сумму элементов матрицы.*/

/*Condition: Given a matrix consisting of n rows and n columns or one-dimensional arrays of n elements each Compose an algorithm and a program to obtain
and the outputs of the results specified in the condition and the arrays themselves, if any of their elements have changed. The algorithm of any problem can be composed
using a single double loop*/
/*Task 2.5.2 Condition: Get an array X1, X2 ...Xn, According to the rule Xi = 1, if the element Aii is greater than each of the elements of the i-th row of the matrix,
otherwise Xi = 0. Also find the sum of the matrix elements.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_variant_CSharp_2_5_2
{
    public partial class OneDoubleCycle : Form
    {
        public OneDoubleCycle()
        {
            InitializeComponent();
        }
        private void buttonMatrDim_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxInputEl.Text);                 //n x n матрица
            dataGridView1.RowCount = n+1;                             //кол-во строк(+1 получ. массив)
            dataGridView1.ColumnCount = n;                          //столбцов
            dataGridView1.Rows[0].HeaderCell.Value = "Матрица N x N";
            int SummElemets = 0;									//для подсчета суммы элементов матрицы
            Random rnd = new Random();
            int[,] tableNxN = new int[n, n];
            bool[] tableNewN = new bool[n];                           //одномерный массив для вывода результатов
            bool Condition = true;									//флаг для хранения условия

            for (int count_row = 0; count_row < n; count_row++)
            {
                for (int count_column = 0; count_column < n; count_column++)                                         //заполняем значения X
                {
                    tableNxN[count_row, count_column] = rnd.Next(-25, 25);                                      //заполняем массив случайными значениями координат
                    dataGridView1.Rows[count_row].Cells[count_column].Value = tableNxN[count_row, count_column];
                    SummElemets += tableNxN[count_row, count_column];
                    if (tableNxN [count_row, count_row] < tableNxN[count_row, count_column])                     //Если элемент Aii меньше хоть одного текущего элемента i-ой строки матрицы
                        Condition = false;
                }
                tableNewN[count_row] = Condition;
                dataGridView1.Rows[n].Cells[count_row].Value = tableNewN[count_row];
                dataGridView1.Rows[count_row].Cells[count_row].Style.BackColor = Color.LightYellow;
                Condition = true;                                      //сбросить флаг
            }
        }
    }
}
