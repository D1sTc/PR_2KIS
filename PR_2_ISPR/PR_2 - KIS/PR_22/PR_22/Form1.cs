using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void elements_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Generation_Click(object sender, EventArgs e)
        {
                errorProviderNull.Clear();
                errorProviderSymbol.Clear();
                errorProviderNumberCharacters.Clear();
                Random rand = new Random();
                List<int> numbers = new List<int>();

                for (int i = 0; i < 10; i++)
                {
                    int randomNumber = rand.Next(1, 100); // Генерируем случайное число от 1 до 9
                    numbers.Add(randomNumber); // Добавляем число в List numbers
                }

                string numbersExit = String.Join(" ", numbers); // Преобразуем список в строку через запятую

                elements.Text = numbersExit; // Присваиваем строку со случайными числами к текстовому полю elements
        }

        private void DeleteСertainElements_Click(object sender, EventArgs e)
        {
            try
            {
            errorProviderNull.Clear();
            errorProviderSymbol.Clear();
            errorProviderNumberCharacters.Clear();
            string input = elements.Text;
            List<int> numbers = input.Split(' ')
                                   .Select(Int32.Parse)
                                   .ToList();

            IEnumerable<int> evenPositionNumbers = numbers.Where((num, index) => index % 2 == 1 && num % 2 != 0).ToList();

            foreach (int num in evenPositionNumbers)
            {
                int index = numbers.IndexOf(num);
                numbers.RemoveAt(index);
            }

            elementsExit.Text = String.Join(" ", numbers);
            }

            catch
            {
                int inputNumber;
                if (!int.TryParse(elements.Text, out inputNumber))
                {
                    errorProviderSymbol.SetError(elements, "Ошибка. Пожалуйста, введите целочисленное значение.");
                }
                else if (String.IsNullOrEmpty(elements.Text))
                {
                    errorProviderNull.SetError(elements, "Поля не должны быть пустыми.");
                }
                else
                {
                    errorProviderNull.Clear();
                    errorProviderSymbol.Clear();
                }

                if (elements.Text.Length > 10)
                {
                errorProviderNumberCharacters.SetError(elements, "Ошибка. Слишком длинное значение!");
                }
                else
                {
                    errorProviderNumberCharacters.Clear();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            elements.Clear();
            elementsExit.Clear();
            errorProviderNull.Clear();
            errorProviderSymbol.Clear();
            errorProviderNumberCharacters.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            elements.Clear();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ApplicationGeneration_Click(object sender, EventArgs e)
        {
            Generation_Click(sender, e);
        }

        private void ApplicationDeleteSymbols_Click(object sender, EventArgs e)
        {
            DeleteСertainElements_Click(sender, e);
        }

        private void Reference_Click(object sender, EventArgs e)
        {

        }

        private void elementsExit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

// исправить- var заменить на интерфейсы