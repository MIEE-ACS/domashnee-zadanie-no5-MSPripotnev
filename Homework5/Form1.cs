using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class EmployersForm : Form
    {
        List<Employee> employers;
        List<Employee> Employers
        {
            get
            {
                return employers;
            }
            set
            {
                employers = value;
                EmployersLV.Items.Clear();
                foreach (Employee el in Employers)
                    EmployersLV.Items.Add(el.ID.ToString(), 0);
                EmployersLV.Sort();
                EmployersPG.SelectedObject = null;
            }
        }
        public EmployersForm()
        {
            InitializeComponent();
            Employers = new List<Employee>();
            BasicFounders();
        }

        private void BasicFounders()
        {
            Employee Ivan1 = new Employee(1, 1000F, "Ivan", "Knyaz", "Moscow");
            Employee Ivan4 = new Employee(4, 250F, "Ivan \"Grozniy\"", "Tsar", "Rus");
            Employee Petr1 = new Employee(2, 1703.21F, "Petr", "Emperor", "Russian Empire");
            Employee Lenin = new Employee(3, 1917.24F, "Vladimir", "Chairman", "USSR");
            Employee Stalin = new Employee(5, 500.45F, "Joseph", "Vozd", "USSR");
            Employee Breznev = new Employee(10, 50000.25F, "Leonid", "Secretary-general", "USSR");
            Employee Gorbachev = new Employee(11, 90000.49999F, "Mikhail", "Perzident", "USSR");
            Employee Eltsin = new Employee(12, 100000.499999F, "Boris", "Prezident", "Russia");

            Employee Ivan = new Employee(100, 5);
            Employee Ivan_copy = new Employee(101,  default);
            Employee Ivan_copy_copy = new Employee(102, default);
            Employee Ivan_copy_copy_copy = new Employee(103, default);
            Ivan_copy.Department = "Mars";
            Ivan_copy_copy.Post = "Engineer";

            Employee Max = new Employee(201, 10, "Max", "Hero", "Parmecia");
            Employee Bowie = new Employee(202, 10, "Bowie", "Hero", "Granzeal");
            Employee Chaz = new Employee(203, 5, "Chaz", "Guardian", "Algo");

            Employers.Add(Ivan1);
            Employers.Add(Ivan4);
            Employers.Add(Petr1);
            Employers.Add(Lenin);
            Employers.Add(Stalin);
            Employers.Add(Breznev);
            Employers.Add(Gorbachev);
            Employers.Add(Eltsin);
            Employers.Add(Ivan);
            Employers.Add(Ivan_copy);
            Employers.Add(Ivan_copy_copy);
            Employers.Add(Ivan_copy_copy_copy);
            Employers.Add(Max);
            Employers.Add(Bowie);
            Employers.Add(Chaz);
            Employers = Employers;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee(
                    (int)(Employers.Find(p => p.ID == idNUD.Value) == null ? idNUD.Value : throw new Exception("Сотрудник с таким идентификационным номером уже есть в базе данных!")),
                    (float)salaryNUD.Value,
                    NameTB.Text == "" ? null : NameTB.Text,
                    PostTB.Text == "" ? null : PostTB.Text,
                    DepartmentTB.Text == "" ? null : DepartmentTB.Text
                );
                Employers.Add(employee);
                Employers = Employers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployersLV.SelectedItems.Count == 0) return;
            foreach (ListViewItem el in EmployersLV.SelectedItems)
                Employers.RemoveAll(p => p.ID.ToString() == el.Text);
            Employers = Employers;
        }

        private void ChangeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployersLV.SelectedItems.Count < 1) return;
            if (EmployersLV.SelectedItems.Count > 1)
                MessageBox.Show("Пожалуйста, выберите только одного сотрудника!");
            EmployersPG.SelectedObject = Employers.Find(p => 
                p.ID.ToString() == EmployersLV.SelectedItems.Cast<ListViewItem>().ToArray()[0].Text);
        }

        private void MoreInfoButton_Click(object sender, EventArgs e)
        {
            if (EmployersLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одного сотрудника!");
                return;
            }    
            foreach (ListViewItem lvi in EmployersLV.SelectedItems)
                MessageBox.Show(Employers.Find(p => p.ID.ToString() == lvi.Text).ToString(), "ID: " + lvi.Text);
        }
    }
}
