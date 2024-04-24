using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ����������� ����������� ������� ������� ������ � ��������������� �������

            button1.Click += new EventHandler(button2_Click);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // ��������� ������ �� ��������� �����
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // ����������� ����� � ������ ����� �����
            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out array[i]))
                {
                    MessageBox.Show("������ �����: ���� �� �������� �� �������� ����� ������.");
                    return;
                }
            }

            // ��������� ������
            SortArray(array);

            // ������� ��������� � textBox3
            textBox2.Text = "��������������� ������: " + string.Join(" ", array);
        }

        private void SortArray(int[] array)
        {
            // ��������� ������ �� ��� �����: ������������� � ������� ��������, � ������������� ��������
            int negativeIndex = 0;
            int positiveIndex = array.Length - 1;

            while (negativeIndex < positiveIndex)
            {
                // ���� negativeIndex ��������� �� ������������� ��� ������� �������, ����������� ���
                while (negativeIndex < array.Length && array[negativeIndex] <= 0)
                {
                    negativeIndex++;
                }

                // ���� positiveIndex ��������� �� ������������� �������, ��������� ���
                while (positiveIndex >= 0 && array[positiveIndex] > 0)
                {
                    positiveIndex--;
                }

                // ���� ������� �� �����������, ������ �������� �������
                if (negativeIndex < positiveIndex)
                {
                    int temp = array[negativeIndex];
                    array[negativeIndex] = array[positiveIndex];
                    array[positiveIndex] = temp;
                }
            }
        }

    }
}
