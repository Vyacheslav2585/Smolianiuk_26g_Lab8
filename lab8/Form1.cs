namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Виводимо вікно з запитом ввести текст
            string inputText = Microsoft.VisualBasic.Interaction.InputBox("Введіть текст для обробки:", "Введення тексту", "");

            // Перевіряємо, чи було введено текст
            if (inputText != "")
            {
                // Виконуємо видалення букви 'к' з рядка
                string outputText = "";
                foreach (char c in inputText)
                {
                    if (c != 'к')
                    {
                        outputText += c;
                    }
                }

                // Виводимо вхідний та вихідний текст у MessageBox
                MessageBox.Show("Вхідний текст: " + inputText + "\n\nВихідний текст: " + outputText, "Результат");
            }
            else
            {
                MessageBox.Show("Текст не було введено!", "Помилка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Отримуємо введений користувачем текстовий рядок
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть текстовий рядок:", "Ввід", "");

            // Якщо користувач натиснув "Cancel", вихід з функції
            if (input == "") return;

            // Змінна для збереження результату перетворення рядка
            string output = "";

            // Проходимося по кожному символу вхідного рядка
            for (int i = 0; i < input.Length; i++)
            {
                // Якщо символ не дорівнює "?", повторюємо його двічі
                if (input[i] != '?')
                {
                    output += input[i];
                    output += input[i];
                }
                // Якщо символ дорівнює "?", додаємо його без змін
                else
                {
                    output += input[i];
                }
            }

            // Виводимо вхідний та вихідний рядки в MessageBox
            MessageBox.Show("Вхідний рядок: " + input + "\n\nВихідний рядок: " + output, "Результат");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}