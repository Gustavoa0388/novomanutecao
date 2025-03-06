using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ManutencaoOrtobio.Models;

namespace ManutencaoOrtobio.Forms
{
    public partial class MaintenanceScheduleForm : Form
    {
        private List<Maquina> _maquinas;

        public MaintenanceScheduleForm()
        {
            InitializeComponent();
            _maquinas = Maquina.LoadMachines();
            LoadMaintenanceSchedule(); // Removed 'this' to avoid ambiguity
        }

        private void LoadMaintenanceSchedule()
        {
            dataGridViewMaintenanceSchedule.Rows.Clear();
            foreach (var maquina in _maquinas)
            {
                dataGridViewMaintenanceSchedule.Rows.Add(maquina.Id, maquina.Code, maquina.LastPreventiveMaintenanceDate);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewMaintenanceSchedule.SelectedRows[0];
            var id = (int)selectedRow.Cells[0].Value;
            var maquina = _maquinas.FirstOrDefault(m => m.Id == id);
            if (maquina != null)
            {
                maquina.LastPreventiveMaintenanceDate = dateTimePickerMaintenanceDate.Value;
                Maquina.SaveMachines(_maquinas);
                LoadMaintenanceSchedule(); // Removed 'this' to avoid ambiguity
            }
        }
    }
}