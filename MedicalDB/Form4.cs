using MedicalDB.DBWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalDB
{
    public partial class Form4 : Form
    {
        public Form4()
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
            if (cbFamilyMember.SelectedIndex < 0 || cbAnalysisType.SelectedIndex < 0)
                return;
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            ParameterManager pr = new ParameterManager();

            var pars = pr.GetParameters(new List<(string name, object value)>() { (name: "name", value: cbFamilyMember.SelectedItem.ToString()), (name:"date1", value:dtStart.Value.Date), (name:"date2", value: dtFinish.Value.Date), (name: "analysisTypeName", value: cbAnalysisType.SelectedItem.ToString()) });
            var dt = db.GetReport(Queries.AnalysesForPeriod, pars.ToArray());

            grid.DataSource = dt;

        }

        void InitCmb()
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            cbAnalysisType.DataSource = db.GetStrings(Queries.ComboBoxAnalysisType, "Name");
            cbFamilyMember.DataSource = db.GetStrings(Queries.ComboBoxFamilyMember, "FullName");



        }
    }
}
