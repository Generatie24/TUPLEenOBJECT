
using ClassLibraryTest;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> list = new List<int>() {1,2,3,5,8 };
            //Nums nums = new Nums();
            //nums = nums.GetNums(list);
            //listBox1.Items.Clear();
            //listBox1.Items.Add(nums.FirstNumber.ToString());
            //listBox1.Items.Add(nums.SecondNumber.ToString());



            List<int> list = new List<int>() { 1, 2, 3, 5, 8 };
            Nums nums = new Nums();
            var (first, last) = nums.GetNums2(list);
            listBox1.Items.Clear();
            listBox1.Items.Add(first.ToString());
            listBox1.Items.Add(last.ToString());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            List<string> namen = new List<string>() { "Harriyet2", "Zak", "Salvatore", "Hasan", "Ziko2","Eveliene", "Harriyet","Ziko","Santiago" };
            List<string> list = services.FirstLetter(namen);
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
