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
            // Привязываем обработчики событий нажатия кнопок к соответствующим методам

            button1.Click += new EventHandler(button2_Click);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Разбиваем строку на отдельные числа
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Преобразуем числа в массив целых чисел
            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out array[i]))
                {
                    MessageBox.Show("Ошибка ввода: одно из значений не является целым числом.");
                    return;
                }
            }

            // Сортируем массив
            SortArray(array);

            // Выводим результат в textBox3
            textBox2.Text = "Отсортированный массив: " + string.Join(" ", array);
        }

        private void SortArray(int[] array)
        {
            // Разделяем массив на две части: отрицательные и нулевые элементы, и положительные элементы
            int negativeIndex = 0;
            int positiveIndex = array.Length - 1;

            while (negativeIndex < positiveIndex)
            {
                // Пока negativeIndex указывает на отрицательный или нулевой элемент, увеличиваем его
                while (negativeIndex < array.Length && array[negativeIndex] <= 0)
                {
                    negativeIndex++;
                }

                // Пока positiveIndex указывает на положительный элемент, уменьшаем его
                while (positiveIndex >= 0 && array[positiveIndex] > 0)
                {
                    positiveIndex--;
                }

                // Если индексы не пересеклись, меняем элементы местами
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
