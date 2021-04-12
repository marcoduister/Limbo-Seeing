
namespace Limbo_Seeing.Views
{
    partial class Activiteiten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActiviteitenDataView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd_Slots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eind_tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reseveren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActiviteitenDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiviteitenDataView
            // 
            this.ActiviteitenDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiviteitenDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naam,
            this.Adress,
            this.Tijd_Slots,
            this.Start_tijd,
            this.Eind_tijd,
            this.Reseveren});
            this.ActiviteitenDataView.Enabled = false;
            this.ActiviteitenDataView.Location = new System.Drawing.Point(12, 89);
            this.ActiviteitenDataView.Name = "ActiviteitenDataView";
            this.ActiviteitenDataView.RowHeadersWidth = 51;
            this.ActiviteitenDataView.RowTemplate.Height = 24;
            this.ActiviteitenDataView.Size = new System.Drawing.Size(776, 349);
            this.ActiviteitenDataView.TabIndex = 1;
            this.ActiviteitenDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiviteitenDataView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.MinimumWidth = 6;
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            this.Naam.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 125;
            // 
            // Tijd_Slots
            // 
            this.Tijd_Slots.HeaderText = "Tijd Slots";
            this.Tijd_Slots.MinimumWidth = 6;
            this.Tijd_Slots.Name = "Tijd_Slots";
            this.Tijd_Slots.ReadOnly = true;
            this.Tijd_Slots.Width = 125;
            // 
            // Start_tijd
            // 
            this.Start_tijd.HeaderText = "Start tijd";
            this.Start_tijd.MinimumWidth = 6;
            this.Start_tijd.Name = "Start_tijd";
            this.Start_tijd.ReadOnly = true;
            this.Start_tijd.Width = 125;
            // 
            // Eind_tijd
            // 
            this.Eind_tijd.HeaderText = "Eind tijd";
            this.Eind_tijd.MinimumWidth = 6;
            this.Eind_tijd.Name = "Eind_tijd";
            this.Eind_tijd.ReadOnly = true;
            this.Eind_tijd.Width = 125;
            // 
            // Reseveren
            // 
            this.Reseveren.HeaderText = "Reseveren";
            this.Reseveren.MinimumWidth = 6;
            this.Reseveren.Name = "Reseveren";
            this.Reseveren.ReadOnly = true;
            this.Reseveren.Width = 125;
            // 
            // Activiteiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActiviteitenDataView);
            this.Name = "Activiteiten";
            this.Text = "Activiteiten";
            this.Load += new System.EventHandler(this.Activiteiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActiviteitenDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActiviteitenDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd_Slots;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eind_tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reseveren;
    }
}