using Limbo_Seeing.BUS;
using Limbo_Seeing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limbo_Seeing.Views
{
    public partial class ActiviteitenBeheer : Form
    {
        ActiviteitenController _Controller = new ActiviteitenController();

        public ActiviteitenBeheer()
        {
            InitializeComponent();

            StartTime.Format = EindTime.Format = DateTimePickerFormat.Time;
            StartTime.ShowUpDown = EindTime.ShowUpDown = true;
        }

        private void ActiviteitenBeheer_Load(object sender, EventArgs e)
        {
            foreach (var Activiteit in _Controller.GetAllActiviteitenByUserID())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ActiviteitenDataView);
                row.Cells[0].Value = Activiteit.Id;
                row.Cells[1].Value = Activiteit.Naam;
                row.Cells[2].Value = Activiteit.Adress;
                row.Cells[3].Value = Activiteit.Aantal;
                row.Cells[4].Value = Activiteit.Tijdslot_grote + " Minuten";
                row.Cells[5].Value = Activiteit.Start_Activiteit;
                row.Cells[6].Value = Activiteit.Eind_Activiteit;
                ActiviteitenDataView.Rows.Add(row);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActiviteitenDataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Guid Activiteit_id = Guid.Parse(ActiviteitenDataView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Activiteit activiteit = _Controller.GetActiviteitbyGuid(Activiteit_id);
            Activtieten_guid.Text = activiteit.Id.ToString();
            Naam_TextBox.Text = activiteit.Naam;
            Adress_TextBox.Text = activiteit.Adress;
            Aantal_Num.Value = activiteit.Aantal;
            Tijdslot_grote_Num.Value = activiteit.Tijdslot_grote;
            Activiteit_Datum_DateTimePicker.Value = activiteit.Start_Activiteit;
            StartTime.Value = activiteit.Start_Activiteit;
            EindTime.Value = activiteit.Eind_Activiteit;


        }


        private void EindTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
