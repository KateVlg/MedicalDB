using MedicalDB.DBWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitCmb();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbFamileMember.SelectedIndex < 0 || cbMedicalField.SelectedIndex < 0)
                return;
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            ParameterManager pr = new ParameterManager();

            var pars = pr.GetParameters(new List<(string name, object value)>() { (name: "name", value: cbFamileMember.SelectedItem.ToString()), (name: "medicFieldname", value: cbMedicalField.SelectedItem.ToString())});
            var dt = db.GetReport(Queries.VisitDoctorforMedicalField, pars.ToArray());

            grid.DataSource = dt;
        
        }

        void InitCmb()
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            cbMedicalField.DataSource = db.GetStrings(Queries.ComboBoxMedicalField, "Name");
            cbFamileMember.DataSource = db.GetStrings(Queries.ComboBoxFamilyMember, "FullName");



        }
    }
}
