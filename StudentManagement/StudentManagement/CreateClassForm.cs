using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CreateClassForm : Form
    {
        private ClassManagement Business;
        public CreateClassForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            
        }

        void CreateClassForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var descrip = this.txtDescrip.Text;

            this.Business.AddClass(name, descrip);
            MessageBox.Show("Add new class successfully");
            this.Close();
        }
    }
}
