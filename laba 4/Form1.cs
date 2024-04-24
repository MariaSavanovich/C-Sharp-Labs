namespace laba_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] a; //двумерный массив
        int m, n; // размерности массива
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string[] st1 = new string[n];
                string[] st2 = new string[n];
                int i, j;
                //textBox1.Clear(); если вывод в тот же textbox
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        a[i, j] *= 2;
                        st1[i] += " " + Convert.ToString(a[i, j]);
                    }
                    st2[i] = st1[i].Trim();
                }
                textBox2.Lines = st2;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                double sum = 0;
                int i, j;
                for (i = 0; i < n; i++)
                    for (j = 0; j < m; j++)
                        sum += a[i, j];
                label1.Text = "Sum= " + Convert.ToString(sum);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            // массив для хранения одной вводимой строки
            string[] mas;
            // количество строк в массиве равно количеству строк в textBox1
            n = textBox1.Lines.Length;
            // массив для хранения всех введенных строк
            string[] dan = new string[n];
            // введенные строки передаем в массив символьных строк
            dan = textBox1.Lines;
            // удаляем последние пустые строки
            while (dan[n - 1] == "") n--;
            // разделим первую строку на элементы
            // разделитель между элементами массива есть пробел
            mas = dan[0].Split(' ');
            // определим количество столбцов двумерного массива
            m = mas.Length;
            // создаем двумерный массив
            a = new double[n, m];
            // заполнение массива а значениями
            for (i = 0; i < n; i++)
            {
                mas = dan[i].Split(' ');
                for (j = 0; j < m; j++)
                    a[i, j] = Convert.ToDouble(mas[j]);
            }
        }


    }
}


