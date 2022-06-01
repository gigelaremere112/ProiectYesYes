using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Entity.EntityState;

namespace Aplicatie
{
    public partial class AdminForm : Form
    {
        admin model = new admin();
        public AdminForm()
        {
            InitializeComponent();
            //DACA NU MERGE ADAUGA POPULATE DATA GRID VIEW
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        void Clear()
        {
            //DIFERIT SI AICI SANKY
            txtFName.Text = txtLName.Text = txtNrLicense.Text = txtLoc.Text = "";
            addBTN.Text = "ADD";
           // deleteBTN.Enabled = false;
            model.ID = 0;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            //Clear();
            if (MessageBox.Show("Are you sure to delete this record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               using (DBEntities db = new DBEntities())
              {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.admins.Attach(model);
                    db.admins.Remove(model);
                    db.SaveChanges();
                  /*            MessageBox.Show(dgvAdmin.CurrentCell.RowIndex.ToString());
                   int  nr = dgvAdmin.SelectedRows.Count;
                    while(nr != 0)
                    {
                        dgvAdmin.Rows.RemoveAt(dgvAdmin.SelectedRows[0].Index);
                        nr--;
                    }*/
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
     
               }
            //  var t = admin.Tasks.Find((int)PopulateDataGridView.SelectedCells[0].Value);
              //  admin.Tasks.Remove(t);
                //admin.SaveChanges();

                //Refresh();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            model.FirstName = txtFName.Text.Trim();
            model.LastName = txtLName.Text.Trim();
            model.NrLicense = txtNrLicense.Text.Trim();
            model.Locality = txtLoc.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                if(model.ID == 0)//insert
                    db.admins.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();

            PopulateDataGridView();

            MessageBox.Show("Submitted Successfully");
        }

        void PopulateDataGridView()
        {
            dgvAdmin.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
              dgvAdmin.DataSource = db.admins.ToList<admin>();
            }
        }

        private void dgvAdmin_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAdmin.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvAdmin.CurrentRow.Cells["ID"].Value);
                using (DBEntities dB = new DBEntities())
                {
                    model = dB.admins.Where(x=>x.ID == model.ID).FirstOrDefault();
                    txtFName.Text = model.FirstName;
                    txtLName.Text = model.LastName;
                    txtNrLicense.Text = model.NrLicense;
                    txtLoc.Text = model.Locality;
                    
                }
                editBTN.Text = "EDIT";
                deleteBTN.Enabled = true;
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
               /* model.ID = Convert.ToInt32(clientidtbl.Text.Trim());
                model.FirstName = clientnametbl.Text.Trim();
                model.ClentPhone = clientphonetb.Text.Trim();
                model.ClientCountry = clientctrytb.Text.Trim();*/

            //model.ID = Convert.ToInt32(ID.Text.Trim());

            //SI AICI CEVA CU ID
            model.FirstName = txtFName.Text.Trim();
            model.LastName = txtLName.Text.Trim();
            model.NrLicense = txtNrLicense.Text.Trim();
            model.Locality = txtLoc.Text.Trim();
            using (DBEntities db = new DBEntities())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                MessageBox.Show("Client Successfully Updated");
                PopulateDataGridView();

            
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
