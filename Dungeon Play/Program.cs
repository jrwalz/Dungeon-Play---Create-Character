/* Student:  Jerry Ray Walz Jr.
 * Class: CIS 162AD
 * Section: 21889
 * Assignment: Final Project, Dungeon Play
 * Submission Date: 12/15/2021
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Play {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Character files must be uploaded for the master List before any other program execution.
            ListCharacters openFile = new ListCharacters();
            openFile.CharacterFile();

            Application.Run(new frmMainForm());
        }
    }
}
