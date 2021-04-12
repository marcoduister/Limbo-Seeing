using Limbo_Seeing.BUS;
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
    public partial class Activiteiten : Form
    {
        ActiviteitenController _Controller = new ActiviteitenController();
        public Activiteiten()
        {
            InitializeComponent();
            
        }

        private void ActiviteitenDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Activiteiten_Load(object sender, EventArgs e)
        {
           

            foreach (var Activiteit in _Controller.GetActiviteitens())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ActiviteitenDataView);
                row.Cells[0].Value = Activiteit.Id;
                row.Cells[1].Value = Activiteit.Naam;
                row.Cells[2].Value = Activiteit.Adress;
                row.Cells[3].Value = Activiteit.Tijdslot_grote + " Minuten";
                row.Cells[4].Value = Activiteit.Start_Activiteit;
                row.Cells[5].Value = Activiteit.Eind_Activiteit;
                DataGridViewButtonCell btn_reseveren = new DataGridViewButtonCell() { Value = "Reseveren" };
                row.Cells[6] = btn_reseveren;
                //row.Cells[5] = Btn_Beoordeling;
                ActiviteitenDataView.Rows.Add(row);
            }
        }
    }
}
