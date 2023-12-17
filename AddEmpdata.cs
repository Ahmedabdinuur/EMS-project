using EMS.MyDB;

namespace EMS
{
    public partial class AddEmpdata : Form
    {
        public static AddEmpdata empform = new AddEmpdata();
        public AddEmpdata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "" || textBoxcontact.Text == "" || textBoxaddress.Text == "" || textBoxrole.Text == "" || textBoxsallery.Text == "" || textBoxyears.Text == "")
            {
                MessageBox.Show("Please Fill All the feilds in order to Save!");
                return;
            }
            var name = textBoxname.Text;
            var contact = textBoxcontact.Text;
            var address = textBoxaddress.Text;
            var role = textBoxrole.Text;
            double sallery, serviceyear;
            int employeeid = -1;
            try
            {
                employeeid = int.Parse(textBoxempid.Text);
            }
            catch
            {
                MessageBox.Show("ID must be integer");
            }
            try
            {
                sallery = double.Parse(textBoxsallery.Text);
            }
            catch
            {
                MessageBox.Show("Sallery must Be Integer");
                return;
            }
            try
            {
                serviceyear = double.Parse(textBoxyears.Text);
            }
            catch
            {
                MessageBox.Show("Service year must Be Integer");
                return;
            }
            using (var context = new ContextDB())
            {
                // Check if an employee with the specified ID already exists
                var check = context.Employes.ToList().Find(x => x.EmployeeId == employeeid);

                if (check == null)
                {
                    // Employee with the specified ID does not exist, so add a new employee
                    context.Employes.Add(new Model.Employee()
                    {
                        EmployeeId = employeeid,
                        Name = name,
                        address = address,
                        contact = contact,
                        role = role,
                        sallery = sallery,
                        serviceyear = serviceyear
                    });

                    context.SaveChanges();
                    MessageBox.Show("Data Saved Successfully!");
                    textBoxaddress.Text = "";
                    textBoxcontact.Text = "";
                    textBoxname.Text = "";
                    textBoxrole.Text = "";
                    textBoxsallery.Text = "";
                    textBoxyears.Text = "";
                    textBoxempid.Text = "";
                }
                else
                {
                    MessageBox.Show("Employee With Same ID Already Exists!");
                    return;
                }
            }

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "" || textBoxcontact.Text == "" || textBoxaddress.Text == "" || textBoxrole.Text == "" || textBoxsallery.Text == "" || textBoxyears.Text == "")
            {
                MessageBox.Show("Please Fill All the fields in order to Save!");
                return;
            }

            var name = textBoxname.Text;
            var contact = textBoxcontact.Text;
            var address = textBoxaddress.Text;
            var role = textBoxrole.Text;
            double sallery, serviceyear;
            int employeeid = -1;

            try
            {
                employeeid = int.Parse(textBoxempid.Text);
            }
            catch
            {
                MessageBox.Show("ID must be an integer");
                return;
            }

            try
            {
                sallery = double.Parse(textBoxsallery.Text);
            }
            catch
            {
                MessageBox.Show("Salary must be a number");
                return;
            }

            try
            {
                serviceyear = double.Parse(textBoxyears.Text);
            }
            catch
            {
                MessageBox.Show("Service year must be a number");
                return;
            }

            using (var context = new ContextDB())
            {
                // Check if an employee with the specified ID exists
                var existingEmployee = context.Employes.ToList().Find(x => x.EmployeeId == employeeid);

                if (existingEmployee == null)
                {
                    // Employee with the specified ID does not exist
                    MessageBox.Show("Employee not found with the given ID. Update operation cannot be performed.");
                }
                else
                {
                    // Employee with the specified ID exists, so update the existing employee
                    existingEmployee.Name = name;
                    existingEmployee.address = address;
                    existingEmployee.contact = contact;
                    existingEmployee.role = role;
                    existingEmployee.sallery = sallery;
                    existingEmployee.serviceyear = serviceyear;

                    context.SaveChanges();
                    MessageBox.Show("Data Updated Successfully!");
                }

                // Clear the textboxes
                textBoxaddress.Text = "";
                textBoxcontact.Text = "";
                textBoxname.Text = "";
                textBoxrole.Text = "";
                textBoxsallery.Text = "";
                textBoxyears.Text = "";
                textBoxempid.Text = "";
            }

        }
    }
}
