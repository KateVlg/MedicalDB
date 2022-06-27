using MedicalDB.DBWork;
using MedicalDB.ObjectModel;
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
    public partial class Analysis : Form
    {
        IInsertManager<VisitingMedicalFacilit> InsertManager = new VisitInsertManager();

        public Analysis()
        {
            InitializeComponent();
        }

        public void SetData(List<VisitingMedicalFacilit> data)
        {
            gridVisit.DataSource = null;
            gridVisit.DataSource = data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var contract = db.GetAllData<Contract>(Queries.ContractSelect, new ContractFactory());
            cbContract.DataSource = contract;

            var fm = db.GetAllData<FamilyMember>(Queries.FamilyMemberSelect, new FamilyMemberFactory(),new FamilyMemberFactoryFillProp(Properties.Settings.Default.ConnectionString).FillObject);
            cbFamilyMember.DataSource = fm;

            var data = db.GetAllData(Queries.VisitSelect, new VisitFactory(), new VisitFactoryFillProp(Properties.Settings.Default.ConnectionString).FillObject);
            SetData(data);
        }

        private void tsBDCreaturesTypes_Click(object sender, EventArgs e)
        {

            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var ct = db.GetAllData(Queries.CreaturesTypesSelectAll, new CreaureTypeFactory());

            CreatureTypeDeleteManager deleteManager = new CreatureTypeDeleteManager();
            CreatureTypeUpdateManager updateManager = new CreatureTypeUpdateManager();
            CreatureTypeInsertManager insertManager = new CreatureTypeInsertManager();


            Form2<CreatureType> f = new Form2<CreatureType>();
            f.DeleteManager = deleteManager;
            f.UpdateManager = updateManager;
            f.InsertManager = insertManager;
            f.SetData(ct);
            f.Show();
        }

        private void tsBDAnalysisTypes_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var at = db.GetAllData(Queries.AnalysisTypesSelectAll, new AnalysisTypeFactory());

            AnalysisTypeDeleteManager deleteManager = new AnalysisTypeDeleteManager();
            AnalysisTypeUpdateManager updateManager = new AnalysisTypeUpdateManager();
            AnalysisTypeInsertManager insertManager = new AnalysisTypeInsertManager();

            Form2<AnalysisType> f = new Form2<AnalysisType>();
            f.DeleteManager = deleteManager;
            f.UpdateManager = updateManager;
            f.InsertManager = insertManager;
            f.SetData(at);
            f.Show();
        }

        private void tsBDExaminationsTypes_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var et = db.GetAllData(Queries.ExaminationsTypesSelectAll, new ExaminationTypeFactory());

            ExaminationTypeDeleteManager deleteManager = new ExaminationTypeDeleteManager();
            ExaminationTypeUpdateManager updateManager = new ExaminationTypeUpdateManager();
            ExaminationTypeInsertManager insertManager = new ExaminationTypeInsertManager();

            Form2<ExaminationType> f = new Form2<ExaminationType>();
            f.DeleteManager = deleteManager;
            f.UpdateManager = updateManager;
            f.InsertManager = insertManager;
            f.SetData(et);
            f.Show();
        }

        private void tsBDMedicalFields_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var ct = db.GetAllData(Queries.MedicalFieldsSelectAll, new MedicalFieldFactory());

            MedicalFieldDeleteManager deleteManager = new MedicalFieldDeleteManager();
            MedicalFieldUpdateManager updateManager = new MedicalFieldUpdateManager();
            MedicalFieldInsertManager insertManager = new MedicalFieldInsertManager();

            Form2<MedicalField> f = new Form2<MedicalField>();
            f.DeleteManager = deleteManager;
            f.UpdateManager = updateManager;
            f.InsertManager = insertManager;
            f.SetData(ct);
            f.Show();
        }

        private void tsBDClinics_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var cl = db.GetAllData(Queries.ClinicsSelectAll, new ClinicFactory());

            ClinicDeleteManager deleteManager = new ClinicDeleteManager();
            ClinicUpdateManager updateManager = new ClinicUpdateManager();
            ClinicInsertManager insertManager = new ClinicInsertManager();

            Form2<Clinic> f = new Form2<Clinic>();
            f.DeleteManager = deleteManager;
            f.UpdateManager = updateManager;
            f.InsertManager = insertManager;
            f.SetData(cl);
            f.Show();
        }

        private void tsBDMedicines_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            var cl = db.GetAllData(Queries.MedicinesSelectAll, new MedicinesFactory());

            MedicinesDeleteManager deleteManager = new MedicinesDeleteManager();
            MedicinesUpdateManager updateManager = new MedicinesUpdateManager();
            MedicinesInsertManager insertManager = new MedicinesInsertManager();

            Form2<Medicines> f = new Form2<Medicines>();
            f.DeleteManager = deleteManager;
            f.UpdateManager = updateManager;
            f.InsertManager = insertManager;
            f.SetData(cl);
            f.Show();
        }

        private void tsBDVisitDoctorforMedicalField(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void tsBDAnalysesForPeriod(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void tsBDFamilyMember(object sender, EventArgs e)
        {
            FamilyMemberForm f = new FamilyMemberForm();
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridVisit.CurrentCell == null)
                return;
            VisitingMedicalFacilit obj = gridVisit.CurrentCell.OwningRow.DataBoundItem as VisitingMedicalFacilit;
            if (obj == null)
                return;

            List<VisitingMedicalFacilit> data = gridVisit.DataSource as List<VisitingMedicalFacilit>;

            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            try
            {
                db.DeleteObject(Queries.VisitDelete, obj);

                data.Remove(obj);
                SetData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            List<VisitingMedicalFacilit> data = gridVisit.DataSource as List<VisitingMedicalFacilit>;

            try
            {
                VisitingMedicalFacilit obj = db.InsertObject<VisitingMedicalFacilit>(InsertManager.InsertQuery, InsertManager);
                VisitFactoryFillProp fillProp = new VisitFactoryFillProp(Properties.Settings.Default.ConnectionString);
                fillProp.FillObject(obj);

                data.Add(obj);
                SetData(data);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (gridVisit.CurrentCell == null)
                return;
            VisitingMedicalFacilit visit = gridVisit.CurrentCell.OwningRow.DataBoundItem as VisitingMedicalFacilit;

            if (visit == null)
                return;

            txtSumm.Text = visit.Summ.ToString();
            dtDateAndTime.Value = visit.DateAndTime;
            cbFamilyMember.SelectedItem = visit.familyMember;
            cbContract.SelectedItem = visit.contract;

            
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            ParameterManager pr = new ParameterManager();

            var pars = pr.GetParameters(new List<(string name, object value)>() { (name: "IdVisit", value: visit.Id.Value.ToString())});
            var dt = db.GetReport(Queries.AnalysisSelect, pars.ToArray());

            gridAnalysis.DataSource = dt;

            var pars2 = pr.GetParameters(new List<(string name, object value)>() { (name: "IdVisit", value: visit.Id.Value.ToString()) });
            var dt2 = db.GetReport(Queries.ReportSelect, pars2.ToArray());

            gridReport.DataSource = dt2;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (gridVisit.CurrentCell == null)
                return;
            VisitingMedicalFacilit obj = gridVisit.CurrentCell.OwningRow.DataBoundItem as VisitingMedicalFacilit;
            if (obj == null)
                return;
            double d;
            if (!double.TryParse(txtSumm.Text.Trim(), out d))
            {
                MessageBox.Show("Ошибка в сумме", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            IUpdateManager<VisitingMedicalFacilit> update = new VisitUpdateManager();
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            try
            {
                obj.Summ = d;
                obj.DateAndTime= dtDateAndTime.Value;
                obj.familyMember = cbFamilyMember.SelectedItem as FamilyMember;
                obj.contract= cbContract.SelectedItem as Contract;

                db.UpdateObject<VisitingMedicalFacilit>(update.UpdateQuery, obj, update);

                List<VisitingMedicalFacilit> data = gridVisit.DataSource as List<VisitingMedicalFacilit>;
                SetData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
