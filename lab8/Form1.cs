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
            // �������� ���� � ������� ������ �����
            string inputText = Microsoft.VisualBasic.Interaction.InputBox("������ ����� ��� �������:", "�������� ������", "");

            // ����������, �� ���� ������� �����
            if (inputText != "")
            {
                // �������� ��������� ����� '�' � �����
                string outputText = "";
                foreach (char c in inputText)
                {
                    if (c != '�')
                    {
                        outputText += c;
                    }
                }

                // �������� ������� �� �������� ����� � MessageBox
                MessageBox.Show("������� �����: " + inputText + "\n\n�������� �����: " + outputText, "���������");
            }
            else
            {
                MessageBox.Show("����� �� ���� �������!", "�������");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �������� �������� ������������ ��������� �����
            string input = Microsoft.VisualBasic.Interaction.InputBox("������ ��������� �����:", "���", "");

            // ���� ���������� �������� "Cancel", ����� � �������
            if (input == "") return;

            // ����� ��� ���������� ���������� ������������ �����
            string output = "";

            // ����������� �� ������� ������� �������� �����
            for (int i = 0; i < input.Length; i++)
            {
                // ���� ������ �� ������� "?", ���������� ���� ����
                if (input[i] != '?')
                {
                    output += input[i];
                    output += input[i];
                }
                // ���� ������ ������� "?", ������ ���� ��� ���
                else
                {
                    output += input[i];
                }
            }

            // �������� ������� �� �������� ����� � MessageBox
            MessageBox.Show("������� �����: " + input + "\n\n�������� �����: " + output, "���������");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}