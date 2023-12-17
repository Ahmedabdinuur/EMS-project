
using EMS.MyDB;


namespace EMS
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            int employeeId = -1;
            if(textBoxempid.Text == "")
            {
                MessageBox.Show("Please Enter A Valid ID!");
                return;
            }
            try
            {
                employeeId = int.Parse(textBoxempid.Text);
            }
            catch
            {
                MessageBox.Show("ID Must be integer!");
                return;
            }
            using (var context = new ContextDB())
            {
                // Check if an employee with the specified ID exists
                var existingEmployee = context.Employes.SingleOrDefault(x => x.EmployeeId == employeeId);

                if (existingEmployee == null)
                {
                    MessageBox.Show("Employee not found with the given ID. Delete operation cannot be performed.");
                }
                else
                {
                    // Employee with the specified ID exists, so delete the employee
                    context.Employes.Remove(existingEmployee);
                    context.SaveChanges();
                    MessageBox.Show("Employee Deleted Successfully!");
                }
            }
            textBoxempid.Text = "";
        }
    }
}
