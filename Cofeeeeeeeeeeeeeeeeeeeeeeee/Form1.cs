namespace Cofeeeeeeeeeeeeeeeeeeeeeeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] words = { "��������", "�����", "���������", "���������", "��������", "�����", "���� ����" };
            comboBox1.Items.AddRange(words);
            string[] word = { "�������", "�����", "������", "����������", "���������", "�������", "������ �� �����", "������� ������" };
            comboBox2.Items.AddRange(word);
            string[] slova = { "��������", "������� ��������", "������", "������ ����", "�������" };
            comboBox3.Items.AddRange(slova);
        }
        string coffee;
        string milk;
        string syrup;
        double totalPrice = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (coffee)
            {
                case "��������":
                case "�����":
                case "���������":
                case "���������":
                    totalPrice += 2.5;
                    break;
                case "��������":
                case "�����":
                case "���� ����":
                    totalPrice += 3.0;
                    break;
            }
            switch (milk)
            {
                case "�������":
                case "�����":
                case "������":
                case "����������":
                case "���������":
                case "�������":
                    totalPrice += 0.5;
                    break;
                case "������ �� �����":
                case "������� ������":
                    totalPrice += 1.0;
                    break;
            }
            switch (syrup)
            {
                case "��������":
                case "������� ��������":
                case "������":
                    totalPrice += 0.3;
                    break;
                case "������ ����":
                case "�������":
                    totalPrice += 0.5;
                    break;
            }
            MessageBox.Show($"Total Price: {totalPrice}$", "Order Summary");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            coffee = comboBox1.SelectedItem.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            milk = comboBox2.SelectedItem.ToString();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            syrup = comboBox3.SelectedItem.ToString();
        }
    }
}