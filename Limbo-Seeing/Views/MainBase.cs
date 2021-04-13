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
    public partial class MainBase : Form
    {
        private GebruikerController _GebruikerController = new GebruikerController();
        
        public MainBase()
        {
            InitializeComponent();
        }

        private void btn_uitloggen_Click(object sender, EventArgs e)
        {
            _GebruikerController.Uitloggen();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            MessageBox.Show("account gegevens bij werken komt in een lateren Fase en is momenteel niet opgenomen in Requirements");
        }

        private void btn_Activiteiten_Click(object sender, EventArgs e)
        {
            Activiteiten ActiviteitForm = new Activiteiten();
            ActiviteitForm.ShowDialog();
            ActiviteitForm.Dispose();
        }

        private void btn_Mijn_Reseveringen_Click(object sender, EventArgs e)
        {
            MijnReseveringen MijnReseveringenForm = new MijnReseveringen();
            MijnReseveringenForm.ShowDialog();
            MijnReseveringenForm.Dispose();
        }
    }
}
