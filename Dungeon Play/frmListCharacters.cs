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

    // Class to list and display the currently saved characters.
    public partial class frmListCharacters : Form {

        private List<Character> listCharacters;
        private ListCharacters listAccess = new ListCharacters();

        // Accessor object to the other classes.
        private frmCreateCharacter createAccess = new frmCreateCharacter();
        private Character baseClass = new Character();

        public frmListCharacters() {
            InitializeComponent();
        }

        private void frmListCharacters_Load(object sender, EventArgs e) {

            // Returns the list from the Character class to a list within this class.
            listCharacters = baseClass.GetCharacters();
            lstCharacters.Items.Add(listCharacters);

            // Adds the "key" property, the character's name, to the list box.
            foreach(var list in listCharacters) {
                lstCharacters.Items.Add(list.Name);
            }
        }

        // On the selected list box name, the specific list array index is invoked to display the
        // stats for that specific character chosen.
        private void lstCharacters_SelectedIndexChanged(object sender, EventArgs e) {

            int select = lstCharacters.SelectedIndex;
            int index = select - 1;

            if (index > -1) {
                txtName.Text = listCharacters[index].Name;
                txtRace.Text = listCharacters[index].Race;
                txtClass.Text = listCharacters[index].Role;
                txtStrength.Text = listCharacters[index].Strength.ToString();
                txtSuperStrength.Text = listCharacters[index].SuperStrength.ToString();
                txtIntelligence.Text = listCharacters[index].Intelligence.ToString();
                txtWisdom.Text = listCharacters[index].Wisdom.ToString();
                txtDexterity.Text = listCharacters[index].Dexterity.ToString();
                txtAgility.Text = listCharacters[index].Agility.ToString();
                txtConstitution.Text = listCharacters[index].Constitution.ToString();
                txtCharisma.Text = listCharacters[index].Charisma.ToString();               
            }
        }

        // Closes the MainForm window.
        private void btnMainMenu_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Takes the user back to the frmCreateCharacter class.
        private void btnCreate_Click(object sender, EventArgs e) {
            this.Close();
            createAccess.ShowDialog();
        }

        // Begins the deletion process by first removing the selected character from the list array, then it removes
        // the character from the list box, it reduces the size of the list array to the new number of wanted
        // elements (-1), and then it finally sends that new list array to the ChangeFile method in the 
        // ListCharacters class to renew the file of the new number of characters.
        private void btnDelete_Click(object sender, EventArgs e) {
            listCharacters.Remove(listCharacters[lstCharacters.SelectedIndex - 1]);
            lstCharacters.Items.RemoveAt(lstCharacters.SelectedIndex);          
            listCharacters.TrimExcess();
            listAccess.ChangeFile(listCharacters);
        }
    }
}
