
namespace Limbo_Seeing.Views
{
    partial class MainBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_uitloggen = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Activiteiten = new System.Windows.Forms.Button();
            this.btn_Mijn_Reseveringen = new System.Windows.Forms.Button();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome bij Limbo-Seeing";
            // 
            // btn_uitloggen
            // 
            this.btn_uitloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uitloggen.Location = new System.Drawing.Point(298, 13);
            this.btn_uitloggen.Name = "btn_uitloggen";
            this.btn_uitloggen.Size = new System.Drawing.Size(118, 33);
            this.btn_uitloggen.TabIndex = 3;
            this.btn_uitloggen.Text = "Uitloggen";
            this.btn_uitloggen.UseVisualStyleBackColor = true;
            this.btn_uitloggen.Click += new System.EventHandler(this.btn_uitloggen_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Location = new System.Drawing.Point(422, 13);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(118, 33);
            this.btn_Account.TabIndex = 6;
            this.btn_Account.Text = "Account";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Activiteiten
            // 
            this.btn_Activiteiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activiteiten.Location = new System.Drawing.Point(598, 13);
            this.btn_Activiteiten.Name = "btn_Activiteiten";
            this.btn_Activiteiten.Size = new System.Drawing.Size(190, 33);
            this.btn_Activiteiten.TabIndex = 7;
            this.btn_Activiteiten.Text = "Activiteiten";
            this.btn_Activiteiten.UseVisualStyleBackColor = true;
            this.btn_Activiteiten.Click += new System.EventHandler(this.btn_Activiteiten_Click);
            // 
            // btn_Mijn_Reseveringen
            // 
            this.btn_Mijn_Reseveringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mijn_Reseveringen.Location = new System.Drawing.Point(598, 52);
            this.btn_Mijn_Reseveringen.Name = "btn_Mijn_Reseveringen";
            this.btn_Mijn_Reseveringen.Size = new System.Drawing.Size(190, 33);
            this.btn_Mijn_Reseveringen.TabIndex = 8;
            this.btn_Mijn_Reseveringen.Text = "Mijn Reseveringen";
            this.btn_Mijn_Reseveringen.UseVisualStyleBackColor = true;
            this.btn_Mijn_Reseveringen.Click += new System.EventHandler(this.btn_Mijn_Reseveringen_Click);
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl.CanDragMap = false;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemory = 5;
            this.gMapControl.Location = new System.Drawing.Point(18, 71);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 20;
            this.gMapControl.MinZoom = 1;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(548, 367);
            this.gMapControl.TabIndex = 9;
            this.gMapControl.Zoom = 15D;
            // 
            // MainBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.btn_Mijn_Reseveringen);
            this.Controls.Add(this.btn_Activiteiten);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_uitloggen);
            this.Name = "MainBase";
            this.Text = "MainBase";
            this.Load += new System.EventHandler(this.MainBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_uitloggen;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_Activiteiten;
        private System.Windows.Forms.Button btn_Mijn_Reseveringen;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}