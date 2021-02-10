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


/* Logger provides a simple class to write logs for CCR
 * and accessing App.Config variables.
 *  
 */

using System;
using System.IO;
using System.Text;

namespace CCR.Util
{
    public class Logger
    {
        public static void log(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now + ": " + msg);
            if (File.Exists(AppRes.logfilename))
            {
                File.AppendAllText(AppRes.logfilename, sb.ToString());

            }
            else
            {
                File.WriteAllText(AppRes.logfilename, sb.ToString()); ;
            }

        }
    }
}
