namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.AllowUserToAddRows = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnHeadersVisible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            int n = (int)numUpDown.Value;
            double[] array = new double[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                array[i] = Math.Round(rnd.NextDouble() * 100 - 50, 2);

            lstArray.Items.Add("Початковий масив:");
            lstArray.Items.Add(string.Join(" | ", array));

            if (double.TryParse(txtA.Text, out double A) && double.TryParse(txtB.Text, out double B))
            {
                int countInRange = array.Count(x => x >= A && x <= B);
                lstArray.Items.Add($"Кількість у діапазоні [{A}, {B}]: {countInRange}");
            }

            double maxVal = array.Max();
            int maxIndex = Array.IndexOf(array, maxVal);
            double sumAfter = 0;
            for (int i = maxIndex + 1; i < n; i++) sumAfter += array[i];

            lstArray.Items.Add($"Сума після макс. ({maxVal}): {Math.Round(sumAfter, 2)}");

            var sorted = array.OrderByDescending(x => Math.Abs(x)).ToArray();
            lstArray.Items.Add("Відсортовано за убуванням модулів:");
            lstArray.Items.Add(string.Join(" | ", sorted));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int size = 4;
            int[,] matrix = new int[size, size];
            Random rnd = new Random();

            dgv1.RowCount = size;
            dgv1.ColumnCount = size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                    dgv1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            bool cornersOdd = (matrix[0, size - 1] % 2 != 0) && (matrix[size - 1, size - 1] % 2 != 0);

            bool cornersFive = (matrix[0, 0] % 10 == 5) || (matrix[size - 1, 0] % 10 == 5);

            string message = $"Чи непарні числа в правих кутах? {(cornersOdd ? "Так" : "Ні")}\n" +
                             $"Чи є число, що закінчуєтья на 5 в лівих кутах? {(cornersFive ? "Так" : "Ні")}";

            MessageBox.Show(message, "Результат Завдання 2");
        }
    }
}
