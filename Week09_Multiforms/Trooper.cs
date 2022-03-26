﻿/* Trooper Class Definition File
 * Author: Clint MacDonald
 * Date: March 8, 2022
 */
#region
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
#endregion

namespace Week09_MultiForms
{
    public class Trooper
    {

        #region PROPERTIES

        public int Designation { get; set; }
        public String NickName { get; set; }
        public String HomeWorld { get; set; }
        public DateTime Born { get; set; }
        public String Unit { get; set; }
        public Boolean IsDefective { get; set; }
        public Color HairColor { get; set; }
        public Color EyeColor { get; set; }

        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor - by Clint
        /// </summary>
        public Trooper() 
        {
            Designation = 0;
        }


        /// <summary>
        /// This is the input parameter constructor - by Clint
        /// </summary>
        /// <param name="designation"></param>
        /// <param name="nickName"></param>
        /// <param name="homeWorld">The world the Trooper was BORN on.</param>
        /// <param name="born"></param>
        /// <param name="unit"></param>
        /// <param name="isDefective"></param>
        /// <param name="hairColor"></param>
        /// <param name="eyeColor"></param>
        public Trooper(int designation, String nickName, String homeWorld,
            DateTime born, String unit, Boolean isDefective,
            Color hairColor, Color eyeColor)
        {
            // TODO: Add data validation here if needed
            Designation = designation;
            NickName = nickName;
            HomeWorld = homeWorld;
            Born = born;
            Unit = unit;
            IsDefective = isDefective;
            HairColor = hairColor;
            EyeColor = eyeColor;
        }
        #endregion

        #region METHODS

        #region CUSTOM METHODS (instantiated)
        #endregion

        #region STATIC METHODS

        /// <summary>
        /// Temp Method to populate some sample troopers for testing purposes
        /// </summary>
        /// <returns></returns>
        public static List<Trooper> GetSampleTroopers()
        {
            List<Trooper> returnList = new List<Trooper>();

            returnList.Add(new Trooper(1, "Clint", "Tatooine", new DateTime(2022, 05, 16),
                            "Blue", false, Color.Brown, Color.Brown));
            returnList.Add(new Trooper(2, "Rex", "Endor", new DateTime(2062, 08, 11),
                            "Red", false, Color.Black, Color.Blue));
            returnList.Add(new Trooper(3, "Ugly", "Hoth", new DateTime(2053, 11, 22),
                                        "Blue", true, Color.Yellow, Color.Red));

            return returnList;
        }

        public static List<String> GetUniqueUnits(List<Trooper> inputTroopers)
        {
            List<String> returnList = new List<String>();

            foreach (Trooper t in inputTroopers)
            {
                if (!returnList.Contains(t.Unit))
                {
                    returnList.Add(t.Unit);
                }
            }


            return returnList;
        }
        
        public static Trooper FindTrooper(List<Trooper> inputTroopers, int designation)
        {
            return inputTroopers.Find(t => t.Designation == designation);

            /*
            foreach (Trooper t in inputTroopers)
            {
                if (t.Designation == designation)
                    return t;
            }
            return null;
            */
        }

        public static Boolean TrooperExists(List<Trooper> inputTroopers, int designation)
        {
            return inputTroopers.FindAll(t => t.Designation == designation).Count > 0;
        }

        public static List<Trooper> GetUnitTroopers(List<Trooper> inputTroopers, String unit)
        {
            return inputTroopers.FindAll(t => t.Unit == unit);
        }

        public static void FileWrite(List<Trooper> troopers, String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(FileCreateCSV(troopers));
            sw.Close();
        }

        public static List<Trooper> LoadFromCSV(String filename)
        {
            List<Trooper> rl = new List<Trooper>();

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //Local Variables
            String lineContent = string.Empty;
            String[] items = new string[8];
            String[] dateItems = new string[2];
            Trooper t;

            while (!sr.EndOfStream)
            {
                try
                {
                    lineContent = sr.ReadLine();
                    items = lineContent.Split(",");
                    t = new Trooper();
                    t.Designation = Convert.ToInt32(items[0]);
                    t.NickName = items[1];
                    t.Unit = items[2];
                    
                    //date
                    dateItems = items[3].Split("-");
                    t.Born = new DateTime(Convert.ToInt32(dateItems[0]),
                                          Convert.ToInt32(dateItems[1]),
                                          Convert.ToInt32(dateItems[2]) );

                    t.HomeWorld = items[4];
                    t.IsDefective = Convert.ToBoolean(items[5]);
                    t.HairColor = ConvertStringToColour(items[6]);
                    t.EyeColor = ConvertStringToColour(items[7]);
                    rl.Add(t);
                }
                catch { }


            }


            return rl;
        }



        private static String FileCreateCSV(List<Trooper> troopers)
        {
            String rs = String.Empty;

            foreach(Trooper t in troopers)
            {
                rs += t.Designation.ToString() + ","
                    + t.NickName + ","
                    + t.Unit + ","
                    + t.Born.ToString().Substring(0, 10) + ","
                    + t.HomeWorld + ","
                    + t.IsDefective.ToString() + ","
                    + ConvertColourToString(t.HairColor) + ","
                    + ConvertColourToString(t.EyeColor) + "\n";
                
            }

            return rs;
        }

        private static Color ConvertStringToColour(String clr)
        {
            Color rc;

            if(clr.Contains(";"))
            {
                string[] items = new string[3];
                items = clr.Split(";");
                rc = Color.FromArgb(Convert.ToInt32(items[0]),
                                    Convert.ToInt32(items[1]),
                                    Convert.ToInt32(items[2]),
                                    Convert.ToInt32(items[3]));
                                   
                                   

            }
            else
            {
                rc = Color.FromName(clr);
            }

            return rc;
        }

        private static String ConvertColourToString(Color clr)
        {
            return clr.ToString()
                .Replace("Color [", "")
                .Replace("]", "")
                .Replace(" ", "")
                .Replace("A=", "")
                .Replace("R=", "")
                .Replace("G=", "")
                .Replace("B=", "")
                .Replace(",", ";");
        }   

        #endregion

        #endregion
    }
}
