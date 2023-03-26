using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Play {

    // Main form to initially be executed after program.cs.
    public partial class frmMainForm : Form {
        public frmMainForm() {
            InitializeComponent();
        }

        // Main menu with three choices.  Objects are created to access two other forms.
        private void btnContinue_Click(object sender, EventArgs e) {
            frmCreateCharacter create = new frmCreateCharacter();
            frmListCharacters list = new frmListCharacters();
            if (rdoCreate.Checked) {
                create.ShowDialog();
            } else if (rdoList.Checked) {
                list.ShowDialog();
            } else if (rdoExit.Checked) {
                this.Close();
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e) {

        }
    }
}
