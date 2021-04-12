
namespace Limbo_Seeing.Views
{
    partial class ActiviteitenBeheer
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
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.ActiviteitenDataView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd_Slots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eind_tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam_TextBox = new System.Windows.Forms.TextBox();
            this.Adress_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aantal_Num = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Tijdslot_grote_Num = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Activiteit_Datum_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EindTime = new System.Windows.Forms.DateTimePicker();
            this.Activtieten_guid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActiviteitenDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aantal_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tijdslot_grote_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(31, 364);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(71, 48);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(211, 364);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(71, 48);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(120, 364);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(71, 48);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(300, 364);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(71, 48);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(390, 424);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(343, 17);
            this.labelNote.TabIndex = 11;
            this.labelNote.Text = "Note: - Double click on a row to view or Delete record";
            // 
            // ActiviteitenDataView
            // 
            this.ActiviteitenDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiviteitenDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naam,
            this.Adress,
            this.Aantal,
            this.Tijd_Slots,
            this.Start_tijd,
            this.Eind_tijd});
            this.ActiviteitenDataView.Location = new System.Drawing.Point(393, 12);
            this.ActiviteitenDataView.Name = "ActiviteitenDataView";
            this.ActiviteitenDataView.ReadOnly = true;
            this.ActiviteitenDataView.RowHeadersWidth = 51;
            this.ActiviteitenDataView.RowTemplate.Height = 24;
            this.ActiviteitenDataView.Size = new System.Drawing.Size(457, 400);
            this.ActiviteitenDataView.TabIndex = 12;
            this.ActiviteitenDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiviteitenDataView_CellContentClick_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.MinimumWidth = 6;
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            this.Naam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Naam.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Adress.Width = 125;
            // 
            // Aantal
            // 
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.MinimumWidth = 6;
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            this.Aantal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Aantal.Width = 125;
            // 
            // Tijd_Slots
            // 
            this.Tijd_Slots.HeaderText = "Tijd Slots";
            this.Tijd_Slots.MinimumWidth = 6;
            this.Tijd_Slots.Name = "Tijd_Slots";
            this.Tijd_Slots.ReadOnly = true;
            this.Tijd_Slots.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tijd_Slots.Width = 125;
            // 
            // Start_tijd
            // 
            this.Start_tijd.HeaderText = "Start tijd";
            this.Start_tijd.MinimumWidth = 6;
            this.Start_tijd.Name = "Start_tijd";
            this.Start_tijd.ReadOnly = true;
            this.Start_tijd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Start_tijd.Width = 125;
            // 
            // Eind_tijd
            // 
            this.Eind_tijd.HeaderText = "Eind tijd";
            this.Eind_tijd.MinimumWidth = 6;
            this.Eind_tijd.Name = "Eind_tijd";
            this.Eind_tijd.ReadOnly = true;
            this.Eind_tijd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eind_tijd.Width = 125;
            // 
            // Naam_TextBox
            // 
            this.Naam_TextBox.Location = new System.Drawing.Point(168, 32);
            this.Naam_TextBox.Name = "Naam_TextBox";
            this.Naam_TextBox.Size = new System.Drawing.Size(200, 22);
            this.Naam_TextBox.TabIndex = 13;
            // 
            // Adress_TextBox
            // 
            this.Adress_TextBox.Location = new System.Drawing.Point(168, 77);
            this.Adress_TextBox.Name = "Adress_TextBox";
            this.Adress_TextBox.Size = new System.Drawing.Size(200, 22);
            this.Adress_TextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activtieten Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Activtieten Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aantal Per tijdslot:";
            // 
            // Aantal_Num
            // 
            this.Aantal_Num.Location = new System.Drawing.Point(168, 124);
            this.Aantal_Num.Name = "Aantal_Num";
            this.Aantal_Num.Size = new System.Drawing.Size(200, 22);
            this.Aantal_Num.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tijdslot Grote:";
            // 
            // Tijdslot_grote_Num
            // 
            this.Tijdslot_grote_Num.Location = new System.Drawing.Point(168, 166);
            this.Tijdslot_grote_Num.Name = "Tijdslot_grote_Num";
            this.Tijdslot_grote_Num.Size = new System.Drawing.Size(200, 22);
            this.Tijdslot_grote_Num.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Activiteit Begin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Activiteit eind:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Activiteit Datum:";
            // 
            // Activiteit_Datum_DateTimePicker
            // 
            this.Activiteit_Datum_DateTimePicker.CustomFormat = "";
            this.Activiteit_Datum_DateTimePicker.Location = new System.Drawing.Point(168, 207);
            this.Activiteit_Datum_DateTimePicker.Name = "Activiteit_Datum_DateTimePicker";
            this.Activiteit_Datum_DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.Activiteit_Datum_DateTimePicker.TabIndex = 25;
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "True";
            this.StartTime.Location = new System.Drawing.Point(168, 249);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(200, 22);
            this.StartTime.TabIndex = 26;
            this.StartTime.Value = new System.DateTime(2021, 4, 12, 22, 0, 41, 0);
            // 
            // EindTime
            // 
            this.EindTime.CustomFormat = "True";
            this.EindTime.Location = new System.Drawing.Point(168, 293);
            this.EindTime.Name = "EindTime";
            this.EindTime.Size = new System.Drawing.Size(200, 22);
            this.EindTime.TabIndex = 27;
            this.EindTime.Value = new System.DateTime(2021, 4, 12, 22, 0, 41, 0);
            this.EindTime.ValueChanged += new System.EventHandler(this.EindTime_ValueChanged);
            // 
            // Activtieten_guid
            // 
            this.Activtieten_guid.Location = new System.Drawing.Point(750, 421);
            this.Activtieten_guid.Name = "Activtieten_guid";
            this.Activtieten_guid.Size = new System.Drawing.Size(100, 22);
            this.Activtieten_guid.TabIndex = 28;
            this.Activtieten_guid.Visible = false;
            // 
            // ActiviteitenBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.Activtieten_guid);
            this.Controls.Add(this.EindTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.Activiteit_Datum_DateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tijdslot_grote_Num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Aantal_Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adress_TextBox);
            this.Controls.Add(this.Naam_TextBox);
            this.Controls.Add(this.ActiviteitenDataView);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Name = "ActiviteitenBeheer";
            this.Text = "ActiviteitenBeheer";
            this.Load += new System.EventHandler(this.ActiviteitenBeheer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActiviteitenDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aantal_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tijdslot_grote_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.DataGridView ActiviteitenDataView;
        private System.Windows.Forms.TextBox Naam_TextBox;
        private System.Windows.Forms.TextBox Adress_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Aantal_Num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Tijdslot_grote_Num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Activiteit_Datum_DateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd_Slots;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eind_tijd;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DateTimePicker EindTime;
        private System.Windows.Forms.TextBox Activtieten_guid;
    }
}