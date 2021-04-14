﻿using Limbo_Seeing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.DAL
{
    class DataSeeder
    {
        Limbo_SeeingContext DBContext = new Limbo_SeeingContext();
        public void Seeder()
        {
            if (!DBContext.Sensoren.Any())
            {
                List<Sensors> sensors = new List<Sensors>();
                sensors.Add(new Sensors { Id = new Guid("d834b5c5-847f-4362-aeb3-024ffedf6143"), Locatie = "50.863010, 5.830117", Battery = 100, SensorType = Enums.SensorType.infra });
                sensors.Add(new Sensors { Id = new Guid("daa5c6ee-03ce-427d-9ffe-18471b72c085"), Locatie = "50.862838, 5.831321", Battery = 90, SensorType = Enums.SensorType.Motion });
                sensors.Add(new Sensors { Id = new Guid("5cbf789e-f4f0-4211-91ec-7adc4b9e3e31"), Locatie = "50.863655, 5.831986", Battery = 80, SensorType = Enums.SensorType.Motion });
                sensors.Add(new Sensors { Id = new Guid("d00e3a2d-8654-41c7-bace-b3345d339348"), Locatie = "50.862122, 5.831943", Battery = 80, SensorType = Enums.SensorType.infra });
                sensors.Add(new Sensors { Id = new Guid("dd46a79c-4208-4148-963d-b5445db52d75"), Locatie = "50.861915, 5.830874", Battery = 90, SensorType = Enums.SensorType.Motion });
                sensors.Add(new Sensors { Id = new Guid("e2f54b40-f061-464b-8ecf-f4fb15992280"), Locatie = "50.859624, 5.823397", Battery = 10, SensorType = Enums.SensorType.infra });
                sensors.Add(new Sensors { Id = new Guid("a9190c0c-df5f-44b5-bccb-e17ac5d77288"), Locatie = "50.864529, 5.825565", Battery = 10, SensorType = Enums.SensorType.infra });
                DBContext.Sensoren.AddRange(sensors);
                DBContext.SaveChanges();
                
            }
            if (!DBContext.Sensors_Acties.Any())
            {
                List<Sensors_Acties> sensors = new List<Sensors_Acties>();
                for (int i = 0; i < 5; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("d834b5c5-847f-4362-aeb3-024ffedf6143"), Soort_beweging = Enums.Beweging.Wandelaar, Snelheid = 10, Tijd = DateTime.Now, Aantal_bewegingen = 2 });
                }
                for (int i = 0; i < 10; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("daa5c6ee-03ce-427d-9ffe-18471b72c085"), Soort_beweging = Enums.Beweging.Wandelaar, Snelheid = 10, Tijd = DateTime.Now, Aantal_bewegingen = 2 });
                }
                for (int i = 0; i < 51; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("5cbf789e-f4f0-4211-91ec-7adc4b9e3e31"), Soort_beweging = Enums.Beweging.Wandelaar, Snelheid = 12, Tijd = DateTime.Now, Aantal_bewegingen = 2 });
                }
                for (int i = 0; i < 2; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("d00e3a2d-8654-41c7-bace-b3345d339348"), Soort_beweging = Enums.Beweging.Wandelaar, Snelheid = 8, Tijd = DateTime.Now, Aantal_bewegingen = 2 });
                }
                for (int i = 0; i < 10; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("dd46a79c-4208-4148-963d-b5445db52d75"), Soort_beweging = Enums.Beweging.Fietser, Snelheid = 10, Tijd = DateTime.Now, Aantal_bewegingen = 5 });
                }
                for (int i = 0; i < 8; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("e2f54b40-f061-464b-8ecf-f4fb15992280"), Soort_beweging = Enums.Beweging.Fietser, Snelheid = 5, Tijd = DateTime.Now, Aantal_bewegingen = 5 });
                }
                for (int i = 0; i < 7; i++)
                {
                    sensors.Add(new Sensors_Acties { Id = Guid.NewGuid(), Sensor_Id = new Guid("a9190c0c-df5f-44b5-bccb-e17ac5d77288"), Soort_beweging = Enums.Beweging.Fietser, Snelheid = 1, Tijd = DateTime.Now, Aantal_bewegingen = 5 });
                }
                DBContext.Sensors_Acties.AddRange(sensors);
                DBContext.SaveChanges();
            }
        }
    }
}