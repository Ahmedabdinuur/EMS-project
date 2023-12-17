using EMS.MyDB;

namespace EMS
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            if(textBoxid.Text == "")
            {
                MessageBox.Show("Please Enter A Valid ID!");
                return;
            }
            int employeeid = -1;
            try
            {
                employeeid = int.Parse(textBoxid.Text);
            }
            catch
            {
                MessageBox.Show("ID Must Be Integer!");
                return;
            }
            using (var context = new ContextDB())
            {
                // Retrieve the employee with the specified ID
                var employee = context.Employes.ToList().Find(x => x.EmployeeId == employeeid);

                if (employee == null)
                {
                    // Employee with the specified ID does not exist
                    MessageBox.Show("Employee not found with the given ID.");
                }
                else
                {
                    // Employee with the specified ID exists, so fill the textboxes with the employee data
                    textBoxempid.Text = employee.EmployeeId.ToString();
                    textBoxname.Text = employee.Name;
                    textBoxaddress.Text = employee.address;
                    textBoxcontact.Text = employee.contact;
                    textBoxrole.Text = employee.role;
                    textBoxsallery.Text = employee.sallery.ToString();
                    textBoxyears.Text = employee.serviceyear.ToString();

                    MessageBox.Show("Employee Data Retrieved Successfully!");
                }
            }

        }
    }
}
