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
    public partial class FamilyMemberForm : Form
    {
        IInsertManager<FamilyMember> InsertManager = new FamilyMemberInsertManager();

        public FamilyMemberForm()
        {
            InitializeComponent();
        }

        bool _filling = false;

        public void SetData(List<FamilyMember> data)
        {
            _filling = true;

            grid.DataSource = null;
            grid.DataSource = data;

            _filling = false;
        }

        private void FamilyMemberForm_Load(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            var creatureTypes = db.GetAllData<CreatureType>(Queries.CreaturesTypesSelectAll, new CreaureTypeFactory());

            cbCreatureType.DataSource = creatureTypes;

            
            var data = db.GetAllData(Queries.FamilyMemberSelect, new FamilyMemberFactory(), new FamilyMemberFactoryFillProp(Properties.Settings.Default.ConnectionString).FillObject);
            SetData(data);                     
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.CurrentCell == null)
                return;
            FamilyMember obj = grid.CurrentCell.OwningRow.DataBoundItem as FamilyMember;
            if (obj == null)
                return;

            List<FamilyMember> data = grid.DataSource as List<FamilyMember>;

            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            try
            {
                db.DeleteObject(Queries.FamilyMemberDelete, obj);

                data.Remove(obj);
                SetData(data);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (_filling || e.RowIndex < 0 || e.ColumnIndex < 0)
        //        return;

        //    DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
        //    try
        //    {
        //        T obj = grid.Rows[e.RowIndex].DataBoundItem as T;
        //        db.UpdateObject<T>(UpdateManager.UpdateQuery, obj, UpdateManager);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);

            List<FamilyMember> data = grid.DataSource as List<FamilyMember>;

            try
            {
                FamilyMember obj = db.InsertObject<FamilyMember>(InsertManager.InsertQuery, InsertManager);
                FamilyMemberFactoryFillProp fillProp = new FamilyMemberFactoryFillProp(Properties.Settings.Default.ConnectionString);
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
            if (grid.CurrentCell == null)
                return;
            FamilyMember fm = grid.CurrentCell.OwningRow.DataBoundItem as FamilyMember;

            if (fm == null)
                return;

            tbFIO.Text = fm.FullName;
            dtDateOfBirth.Value = fm.DateOfBirth;
            cbCreatureType.SelectedItem = fm.CreatureVar;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (grid.CurrentCell == null)
                return;
            FamilyMember obj = grid.CurrentCell.OwningRow.DataBoundItem as FamilyMember;
            if (obj == null)
                return;
            IUpdateManager<FamilyMember> update = new FamilyUpdateManager();
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            try
            {
                obj.FullName = tbFIO.Text;
                obj.DateOfBirth = dtDateOfBirth.Value;
                obj.CreatureVar = cbCreatureType.SelectedItem as CreatureType;

                db.UpdateObject<FamilyMember>(update.UpdateQuery, obj, update);

                List<FamilyMember> data = grid.DataSource as List<FamilyMember>;
                SetData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
