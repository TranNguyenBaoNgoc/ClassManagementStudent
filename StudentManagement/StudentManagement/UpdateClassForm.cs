﻿using System;
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
    public partial class UpdateClassForm : Form
    {
        private int ClassId;
        private ClassManagement Business;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.ClassId = id;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var oldClass = this.Business.GetClass(this.ClassId);
            this.txtName.Text = oldClass.NAME;
            this.txtDescrip.Text = oldClass.DESCRIPTION;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var descrip = this.txtDescrip.Text;
            this.Business.EditClass(this.ClassId, name, descrip);
            MessageBox.Show("Update class succesfully");
        }
    }
}
