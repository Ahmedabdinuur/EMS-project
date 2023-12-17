namespace EMS
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var showemployee = new DeleteEmployee();
            panelapp.Controls.Clear();
            showemployee.TopLevel = false;
            panelapp.Controls.Add(showemployee);
            showemployee.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelapp.Controls.Clear();
            AddEmpdata.empform.TopLevel = false;
            panelapp.Controls.Add(AddEmpdata.empform);
            AddEmpdata.empform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var showemployee = new ShowEmployees();
            panelapp.Controls.Clear();
            showemployee.TopLevel = false;
            panelapp.Controls.Add(showemployee);
            showemployee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var showemployee = new SearchEmployee();
            panelapp.Controls.Clear();
            showemployee.TopLevel = false;
            panelapp.Controls.Add(showemployee);
            showemployee.Show();
        }
        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}