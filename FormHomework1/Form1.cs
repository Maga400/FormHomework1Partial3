namespace FormHomework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 1;
        int x = 0;
        int y = 0;

        int width = 0;
        int height = 0;
        int secondX = 0;
        int secondY = 0;
        string text = "";
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            x = e.Location.X;
            y = e.Location.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            int X = this.Location.X;
            int Y = this.Location.Y;
            Label Label = new Label();
            Label.Location = new Point(x, y);
            Label.Size = new Size(e.X - x, e.Y - y);
            Label.BackColor = Color.Black;
            Label.ForeColor = Color.Gold;
            Label.Text = count.ToString();
            text = Label.Text;

            if (Label.Size.Width < 10 && Label.Size.Height < 10)
            {
                MessageBox.Show("Kvadration olcusu 10-un 10-a olmalidir");
            }

            else
            {
                count++;
                width = e.X - x;
                height = e.Y - y;
                secondX = e.Location.X;
                secondY = e.Location.Y;
                Controls.Add(Label);
                Label.MouseClick += label_MouseClick;
                Label.MouseDoubleClick += label_MouseDoubleClick;

            }

        }
        Label label = new Label();
        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                label.Location = new Point(0, 0);
                label.Size = new Size(1000, 100);
                label.Text = $"{text} -ci kvadratin 1-ci noqtesinin kordinati--->X:{x}  Y:{y} " +
                    $"kvadratin 2-ci noqtesinin kordinati--->X:{secondX}  Y:{secondY}\n" +
                    $"Kvadration uzunlugu: {height} Kvadratin eni: {width}";
                Controls.Add(label);
            }
        }

        private void label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label.Text = "";
            }
        }

    }
}