using EMS.MyDB;
using System.Data;

namespace EMS
{
    public partial class ShowEmployees : Form
    {
        public static ShowEmployees showemployee = new ShowEmployees();
        public ShowEmployees()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            dt.Columns.Add("Employee ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Contact",typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Role",typeof (string));
            dt.Columns.Add("Sallery", typeof(double));
            dt.Columns.Add("Service Years",typeof(double));

            using (var context = new ContextDB())
            {
                var employees = context.Employes.OrderBy(x => x.EmployeeId).ToList();
                foreach (var employee in employees)
                {
                    dt.Rows.Add(employee.EmployeeId, employee.Name,employee.contact,employee.address,employee.role,employee.sallery,employee.serviceyear);
                }
            }
            dataGridView1.DataSource = dt;
        }
    }
}
