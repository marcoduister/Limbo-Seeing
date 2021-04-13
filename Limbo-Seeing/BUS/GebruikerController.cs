﻿using Limbo_Seeing.DAL;
using Limbo_Seeing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limbo_Seeing.BUS
{
    class GebruikerController
    {
         Limbo_SeeingContext DBContext = new Limbo_SeeingContext();

        public bool Login(string Email, string Wachtwoord)
        {
            bool login = Valideergebruiker(new Gebruiker { Email = Email, Wachtwoord = Wachtwoord });

            if (login)
            {
                
            }

            return login;
        }

        internal void Uitloggen()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name != "StartBase")
                {
                    fm.Close();
                    //Properties.Settings.Default.Gebruiker.Clear();
                }
            }
        }

        internal string Registration(string Voornaam, string Achternaam, int Geslacht, DateTime GeboorteDatum, string Email, string Wachtwoord, string WachtwoordConfirm)
        {
            if (CheckGebruikerByEmail(Email))
            {
                return "dit email is al in gebruikt contacteer een Beheerder!! of Gebruik anderen Email";
            }
            else
            {
                if (Wachtwoord == WachtwoordConfirm)
                {
                    if (Wachtwoord.Length >= 8)
                    {
                        int IsupperCounter = 0;

                        for (int i = 0; i < Wachtwoord.Length; i++)
                        {
                            if (char.IsUpper(Wachtwoord[i])) IsupperCounter++;
                        }
                        if (IsupperCounter >= 1)
                        {
                            if (Wachtwoord.Any(char.IsDigit))
                            {
                                Gebruiker gebruiker = new Gebruiker();
                                if (Geslacht == 0)
                                    gebruiker.Geslacht = Enums.Geslachten.Man;
                                else
                                    gebruiker.Geslacht = Enums.Geslachten.Vrouw;
                                gebruiker.Email = Email;
                                gebruiker.Wachtwoord = Wachtwoord;
                                gebruiker.Voornaam = Voornaam;
                                gebruiker.Achternaam = Achternaam;
                                gebruiker.Geboortendatum = GeboorteDatum;
                                DBContext.Gebruikers.Add(gebruiker);
                                DBContext.SaveChanges();
                                return "de Gebruiker is aan gemaakt ga naar login pagina";
                            }
                            else
                            {
                                return "Wachtwoord moet minimaal 1 Nummer bevaten";
                            }
                        }
                        else
                        {
                            return "Wachtwoord moet minimaal 1 Hooftletter bevaten";
                        }

                    }
                    else
                    {
                        return "Wachtwoord is niet lang genoeg";
                    }

                }
                else
                {
                    return "Conferm wachtwoord klopt niet!!";
                }
            }

        }

        internal string Update(string NewEmail, string NewName, string NewLastName, DateTime NewBirthDate)
        {
            Guid UserId = Guid.Parse(Properties.Settings.Default.UserId);
            Gebruiker CurentUserData = GetUserdata(UserId);

            CurentUserData.Email = NewEmail;
            CurentUserData.Voornaam = NewName;
            CurentUserData.Achternaam = NewLastName;
            CurentUserData.Geboortendatum = NewBirthDate;
            CurentUserData.UpdatedOn = DateTime.Now;

            DBContext.Gebruikers.Add(CurentUserData);
            DBContext.Entry(CurentUserData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DBContext.SaveChanges();

            return "gegevens opgeslagen";
        }
        public bool Valideergebruiker(Gebruiker gebruiker)
        {
            return DBContext.Gebruikers.Any(e => e.Email == gebruiker.Email && e.Wachtwoord == gebruiker.Wachtwoord);
        }

        internal bool CheckGebruikerByEmail(string Gebruiker)
        {
            return DBContext.Gebruikers.Any(e => e.Email == Gebruiker);
        }

        internal Gebruiker GetUserId(string Email)
        {
            return DBContext.Gebruikers.First(e => e.Email == Email);
        }

        internal Gebruiker GetUserdata(Guid UserId)
        {
            return DBContext.Gebruikers.First(e => e.Id == UserId);
        }
    }
}
