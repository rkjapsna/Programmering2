using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Programmering2
{
    public partial class Form1 : Form
    {
        //displayar "status" till itemen som är selectad
        private Label StatusLable;

        // constructor
        public Form1()
        {
            InitializeComponent();
            StatusLable = new Label
            {
                Location = new System.Drawing.Point(20, 100), // Adjust the location as needed
                Size = new System.Drawing.Size(200, 20), // Adjust the size as needed
                Text = "Status:"
            };
            this.Controls.Add(StatusLable);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValue.Text))
                return;
            listWork.Items.Add(txtValue.Text);
            txtValue.Clear();
            txtValue.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listWork.Items.Count > 0)
                listWork.Items.RemoveAt(listWork.SelectedIndex);
        }

        private void listWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWork.SelectedItem is Human selectedHuman)
            {
                lblValue.Text = selectedHuman.GetName();
                if (selectedHuman is Professor)
                {
                    StatusLable.Text = "Status: Professor";
                }
                else if (selectedHuman is Teacher)
                {
                    StatusLable.Text = "Status: Teacher";
                }
                else
                {
                    StatusLable.Text = "Status: Unknown";
                }
            }
            else
            {
                lblValue.Text = listWork.Text;
                StatusLable.Text = "Status: Unknown";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Human> list = new List<Human>
            {
                new Professor("PR1", "Donald Trump", 89),
                new Teacher("TE1", "Barack Obama", 52)
            };
            listWork.DataSource = list;
            listWork.DisplayMember = "ToString";
        }
    }
}