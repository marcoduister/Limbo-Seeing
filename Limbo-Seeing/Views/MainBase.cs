using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Limbo_Seeing.BUS;
using Limbo_Seeing.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.ToolTips;

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

        private void MainBase_Load(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            //gMapControl.Position = new GMap.NET.PointLatLng(50.864278, 5.831776);
            
            gMapControl.Position = new GMap.NET.PointLatLng(-25.969562, 32.585789);
            gMapControl.ShowCenter = false;


            //GMapOverlay markersOverlay = new GMapOverlay("markers");

            //GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-25.969562, 32.585789),
            //  GMarkerGoogleType.green);

            //markersOverlay.Markers.Add(marker);
            //gMapControl.Overlays.Add(markersOverlay);

            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            //List<PointLatLng> points = new List<PointLatLng>();
            //points.Add(new PointLatLng(-25.969562, 32.585789));
            //points.Add(new PointLatLng(-25.966205, 32.588171));
            //points.Add(new PointLatLng(-25.968134, 32.591647));
            //points.Add(new PointLatLng(-25.971684, 32.589759));
            //GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            //polygon.Stroke = new Pen(Color.Red, 1);
            //gMapControl.Overlays.Add(polyOverlay);
            //polyOverlay.Polygons.Add(polygon);

            PointLatLng point = new PointLatLng(-25.969562, 32.585789);
            double radius = 0.001;
            int segments = 100;

            List<PointLatLng> gpollist = new List<PointLatLng>();

            double seg = Math.PI * 2 / segments;

            for (int i = 0; i < segments; i++)
            {
                double theta = seg * i;
                double a = point.Lat + Math.Cos(theta) * radius;
                double b = point.Lng + Math.Sin(theta) * radius;

                PointLatLng gpoi = new PointLatLng(a, b);

                gpollist.Add(gpoi);
            }
            GMapPolygon gpol = new GMapPolygon(gpollist, "pol");
            gpol.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            gpol.Stroke = new Pen(Color.Red, 1);
            gMapControl.Overlays.Add(polyOverlay);
            polyOverlay.Polygons.Add(gpol);
        }
    }
}
