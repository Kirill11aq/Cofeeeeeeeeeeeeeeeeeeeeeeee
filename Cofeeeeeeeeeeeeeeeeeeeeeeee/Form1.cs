namespace Cofeeeeeeeeeeeeeeeeeeeeeeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] words = { "Эспрессо", "Лунго", "Американо", "Ристретто", "Капучино", "Латте", "Флэт уайт" };
            comboBox1.Items.AddRange(words);
            string[] word = { "Коровье", "Козье", "Соевое", "Миндальное", "Кокосовое", "Овсяное", "Молоко из кешью", "Рисовое молоко" };
            comboBox2.Items.AddRange(word);
            string[] slova = { "Клубника", "Соленая карамель", "Ваниль", "Лесной Орех", "Миндаль" };
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
                case "Эспрессо":
                case "Лунго":
                case "Американо":
                case "Ристретто":
                    totalPrice += 2.5;
                    break;
                case "Капучино":
                case "Латте":
                case "Флэт уайт":
                    totalPrice += 3.0;
                    break;
            }
            switch (milk)
            {
                case "Коровье":
                case "Козье":
                case "Соевое":
                case "Миндальное":
                case "Кокосовое":
                case "Овсяное":
                    totalPrice += 0.5;
                    break;
                case "Молоко из кешью":
                case "Рисовое молоко":
                    totalPrice += 1.0;
                    break;
            }
            switch (syrup)
            {
                case "Клубника":
                case "Соленая карамель":
                case "Ваниль":
                    totalPrice += 0.3;
                    break;
                case "Лесной Орех":
                case "Миндаль":
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