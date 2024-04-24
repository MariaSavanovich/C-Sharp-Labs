namespace laba_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] a; //��������� ������
        int m, n; // ����������� �������
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string[] st1 = new string[n];
                string[] st2 = new string[n];
                int i, j;
                //textBox1.Clear(); ���� ����� � ��� �� textbox
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
            // ������ ��� �������� ����� �������� ������
            string[] mas;
            // ���������� ����� � ������� ����� ���������� ����� � textBox1
            n = textBox1.Lines.Length;
            // ������ ��� �������� ���� ��������� �����
            string[] dan = new string[n];
            // ��������� ������ �������� � ������ ���������� �����
            dan = textBox1.Lines;
            // ������� ��������� ������ ������
            while (dan[n - 1] == "") n--;
            // �������� ������ ������ �� ��������
            // ����������� ����� ���������� ������� ���� ������
            mas = dan[0].Split(' ');
            // ��������� ���������� �������� ���������� �������
            m = mas.Length;
            // ������� ��������� ������
            a = new double[n, m];
            // ���������� ������� � ����������
            for (i = 0; i < n; i++)
            {
                mas = dan[i].Split(' ');
                for (j = 0; j < m; j++)
                    a[i, j] = Convert.ToDouble(mas[j]);
            }
        }


    }
}


