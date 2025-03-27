using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ASPPR_1._1_R
{
    public partial class Form1 : Form
    {

        private string logText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FindInverseMatrix_Click(object sender, EventArgs e)
        {
            InverseMatrix(GetMatrixFromGrid(dataGridViewA));
        }

        private double[,] GetMatrixFromGrid(DataGridView grid)
        {
            int rows = grid.RowCount;
            int cols = grid.ColumnCount;
            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = Convert.ToDouble(grid[j, i].Value);

            return matrix;
        }

        private string MatrixToString(double[,] matrix)
        {
            string result = "";
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    result += matrix[i, j].ToString("F2") + " ";
                result += "\n";
            }
            return result;
        }

        private void SaveLogToFile()
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = Path.Combine(folderDialog.SelectedPath, "log.txt");
                    File.WriteAllText(filePath, logText);
                    MessageBox.Show("Лог збережено: " + filePath, "Збереження логу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private double[,] JordanElimination(double[,] matrix, int r, int s)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] newMatrix = (double[,])matrix.Clone();
            double originalPivot = matrix[r, s];

            logText += $"\nКрок #{r + 1}\nРозв’язувальний елемент: A[{r + 1}, {s + 1}] = {originalPivot:F2}\n";

            newMatrix[r, s] = 1.0;

            for (int j = 0; j < cols; j++)
            {
                if (j != s)
                {
                    newMatrix[r, j] = -matrix[r, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (i == r) continue;
                for (int j = 0; j < cols; j++)
                {
                    if (j == s) continue;
                    newMatrix[i, j] = (matrix[i, j] * originalPivot) - (matrix[i, s] * matrix[r, j]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newMatrix[i, j] /= originalPivot;
                }
            }

            logText += "Матриця після виконання ЗЖВ:\n" + MatrixToString(newMatrix);

            return newMatrix;
        }

        private void CalculateMatrixRank(double[,] matrix)
        {
            int n = matrix.GetLength(1);
            int m = matrix.GetLength(0);
            double[,] a = (double[,])matrix.Clone();
            int r = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i, i] != 0)
                {
                    a = JordanElimination(a, i, i);
                    r++;
                }
            }

            txtRank.Text = r.ToString();
        }

        private void FindSolution(double[,] a, double[,] matrixB)
        {
            int rowsA = a.GetLength(0);
            int colsA = a.GetLength(1);
            double sum = 0;
            double term = 0;
            double[,] X = new double[rowsA, 1];

            for (int i = 0; i < rowsA; i++)
            {
                a = JordanElimination(a, i, i);
            }

            logText += "\nОбернена матриця:\n" + MatrixToString(a);
            logText += "\nВхідна матриця B:\n" + MatrixToString(matrixB);
            logText += "\nОбчислення розв'язків:\n";

            for (int i = 0; i < rowsA; i++)
            {
                logText += $"\nX[{i+1}] = ";
                sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    term = a[i, k] * matrixB[k, 0];
                    sum += term;
                    logText += $"{matrixB[k, 0]:F2} * {a[i, k]:F2}";
                    if (k < colsA - 1) logText += " + ";
                }
                logText += $" = {sum:F2}";
                X[i, 0] = sum;
            }

            if (checkBoxLogging.Checked)
            {
                SaveLogToFile();
            }

            ShowMatrix(X, dataGridViewResult, "F2");
        }

        private void InverseMatrix(double[,] a)
        {
            int n = a.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                a = JordanElimination(a, i, i);
            }

            logText += "\nОбернена матриця:\n" + MatrixToString(a); 
            if (checkBoxLogging.Checked)
                SaveLogToFile();

            ShowMatrix(a, dataGridViewReverse, "F2");
        }

        private void ShowMatrix(double[,] matrix, DataGridView grid, string format)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < cols; i++)
                grid.Columns.Add("", "");

            grid.RowCount = rows;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    grid[j, i].Value = matrix[i, j].ToString(format);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[,] matrixA = {
            {1, 1, 2},
            {1, -2, 3},
            {-3, 1, 1}
            };

            double[,] matrixB = {
            {4},
            {3},
            {6}
            };

            ShowMatrix(matrixA, dataGridViewA, "");
            ShowMatrix(matrixB, dataGridViewB, "");
        }

        private void btn_Rank_Click(object sender, EventArgs e)
        {
            CalculateMatrixRank(GetMatrixFromGrid(dataGridViewA));
        }

        private void btn_FindSolution_Click(object sender, EventArgs e)
        {
            FindSolution(GetMatrixFromGrid(dataGridViewA), GetMatrixFromGrid(dataGridViewB));
        }
    }
}
