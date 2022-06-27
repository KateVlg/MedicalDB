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
    public partial class Form2<T> : Form where T:class, IId
    {

        bool _filling = false;
        public Form2()
        {
            InitializeComponent();
        }
        public IDeleteManager<T> DeleteManager { get; set; }
        public IUpdateManager<T> UpdateManager { get; set; }
        public IInsertManager<T> InsertManager { get; set; }

        public void SetData(List<T> data)
        {
            _filling = true;

            grid.DataSource = null;
            grid.DataSource = data;

            _filling = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (grid.CurrentCell == null)
                return;
            T obj = grid.CurrentCell.OwningRow.DataBoundItem as T;
            if (obj == null)
                return;

            List<T> data = grid.DataSource as List<T>;

            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            try
            {
                db.DeleteObject(DeleteManager.DeleteQuery, obj);

                data.Remove(obj);
                SetData(data);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_filling || e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            try
            {
                T obj = grid.Rows[e.RowIndex].DataBoundItem as T;
                db.UpdateObject<T>(UpdateManager.UpdateQuery, obj, UpdateManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DbWorker db = new DbWorker(Properties.Settings.Default.ConnectionString);
            
            List<T> data = grid.DataSource as List<T>;

            try
            {
                T obj = db.InsertObject<T>(InsertManager.InsertQuery, InsertManager);

                data.Add(obj);
                SetData(data);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
