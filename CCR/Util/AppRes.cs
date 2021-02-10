//    CCR is static code analyzer
//    Copyright(C) 2021  CCR.ltd

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<https://www.gnu.org/licenses/>.


/* AppRes provides a simple class to use for initilizating CCR direcrotries
 * and accessing App.Config variables.
 *  
 */

using System;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;


namespace CCR.Util
{
    public class AppRes
    {
        public static string paradata = ConfigurationManager.AppSettings["paradata"];
        public static string userProfile = ConfigurationManager.AppSettings["userProfile"];
        public static string scanDir = ConfigurationManager.AppSettings["scanDir"];
        public static string deployFiles = ConfigurationManager.AppSettings["deployFiles"];
        public static string cssFile = ConfigurationManager.AppSettings["cssFile"];
        public static string logfilename = ConfigurationManager.AppSettings["logname"];
        public static string testDb = ConfigurationManager.AppSettings["testDb"];

        public static void InitDirs()
        {
            
                //check for required dirs and files
                if (!Directory.Exists("res"))
                {
                    Directory.CreateDirectory("res");
                }

                if (!File.Exists(paradata))
                {
                    //try and resolve
                    try
                    {
                        string[] sa = Regex.Split(paradata, "res/");
                        string filePath = Environment.CurrentDirectory + deployFiles + "\\" + sa[1];
                        if (File.Exists(filePath))
                        {
                            //copy over
                            File.Copy(filePath, paradata);
                        }
                        else
                        {
                            //throw error
                            throw new Exception("deploy file for paradata not found...");
                        }
                    }
                    catch (Exception ex)
                    {
                        string msg = "Missing paradata file resource." +
                            " Parascan will be unable to scan code." + ex.Message;
                        //MessageBox.Show(msg,
                        // "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Logger.log(msg);
                    }


                }



                //check for required dirs
                if (!Directory.Exists("rep"))
                {
                    Directory.CreateDirectory("rep");
                }

                if (!File.Exists(cssFile))
                {
                    //try and resolve
                    try
                    {
                        string[] sa = Regex.Split(cssFile, "rep/");
                        string filePath = Environment.CurrentDirectory + deployFiles + "\\" + sa[1];
                        if (File.Exists(filePath))
                        {
                            //copy over
                            File.Copy(filePath, cssFile);
                        }
                        else
                        {
                            //throw error
                            throw new Exception("deploy file for css not found...");
                        }
                    }
                    catch (Exception ex)
                    {
                        //string msg = "Missing paradata file resource." +
                        //    " Parascan will be unable to scan code." + ex.Message;
                        //MessageBox.Show(msg,
                        // "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Logger.log(ex.Message);
                    }
                }


                //check for required dirs
                if (!Directory.Exists("sca"))
                {
                    Directory.CreateDirectory("sca");
                }


        }
    }
}
