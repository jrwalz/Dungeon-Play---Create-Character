using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dungeon_Play {

    // This class is specifically for Character Creation
    public partial class frmCreateCharacter : Form {

        // Class objects instantiated to access other classes.
        Character rolled = new Character();
        CreateCharacter create = new CreateCharacter();

        // These Field variables created to give more control over the events.
        private bool grpRaceBoxChecked;
        private bool grpClassBoxChecked;

        public bool GrpRaceBoxChecked {
            get { return this.grpRaceBoxChecked; }
            set { grpRaceBoxChecked = value; }
        }

        public bool GrpClassBoxChecked {
            get { return this.grpClassBoxChecked; }
            set { grpClassBoxChecked = value; }
        }

        // Formalizing Field variables.
        public frmCreateCharacter() {
            InitializeComponent();
            grpClassBoxChecked = false;
            grpRaceBoxChecked = false;          
        }

        //Accessor to the form.
        private void frmCreateCharacter_Load(object sender, EventArgs e) {
            btnAcceptRoll.Enabled = false;
            grpRace.Enabled = false;
            grpClass.Enabled = false;
            btnReroll.Focus();
        }

        // Closes the current form.
        private void btnReturn_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Displays rolled stats with their race modifiers.
        public void DisplayStats(Character rolled) {
            int str = 0; int intel = 0; int con = 0; int wis = 0; int dex = 0; int agi = 0;

            if (rdoBarbarian.Checked == true) {
                con = 1;
                str = 1;
                agi = -1;
                intel = -1;
            } else if (rdoDwarf.Checked == true) {
                con = 1;
                wis = 1;
                dex = -1;
                intel = -1;          
            } else if (rdoElf.Checked == true) {
                dex = 1;
                intel = 1;
                con = -1;
                wis = -1;            
            } else if (rdoHuman.Checked == true) {
                dex = 0;
                intel = 0;
                con = 0;
                str = 0;
                agi = 0;
                wis = 0;             
            }

            txtStrength.Text = (rolled.Strength + str).ToString();
            txtSuperStrength.Text = rolled.SuperStrength.ToString();
            txtIntelligence.Text = (rolled.Intelligence + intel).ToString();
            txtWisdom.Text = (rolled.Wisdom + wis).ToString();
            txtConstitution.Text = (rolled.Constitution + con).ToString();
            txtDexterity.Text = (rolled.Dexterity + dex).ToString();
            txtAgility.Text = (rolled.Agility + agi).ToString();
            txtCharisma.Text = rolled.Charisma.ToString();
            BestOptions(rolled);
           
        }

        // Event button to either roll or re-roll character stats.
        private void btnReroll_Click(object sender, EventArgs e) {
            btnReroll.Text = "Re-Roll Character";
            grpClass.Enabled = false;
            grpRace.Enabled = true;
            lblFrameRace.BackColor = Color.DarkSeaGreen;
            btnAcceptRoll.Enabled = false;
            rolled = create.RollStats();
            DisplayStats(rolled);
        }

        // This is the main Event button for the form.  It changes text depending on where the
        // user is at in the selection process.
        private void btnAcceptRoll_Click(object sender, EventArgs e) {

            // Sets the objects to where they need to be when the user initially uses the button.
            if(GrpRaceBoxChecked == false && GrpClassBoxChecked == false) {
                btnAcceptRoll.Text = "Choose Race";
                lblFrameRace.BackColor = Color.DarkSeaGreen;
                lblFrameRace.Focus();
                txtName.BackColor = Color.AliceBlue;
                btnReroll.Text = "Re-roll Character";
            }

            // This is to test the user's input for the Character's name, test to make sure that stat
            // text is numerical and it creates the new character.
            if(GrpClassBoxChecked == true){             
                bool digitCheck = false;
                bool doubleCheck = false;
                while(digitCheck != true) {
                    doubleCheck = false;
                    if (txtName.Text != null && txtName.Text != "" && txtName.Text != " "){
                        doubleCheck = true;
                    } 
                
                    if( doubleCheck == true ) {
                        digitCheck = !Char.IsDigit(txtName.Text, 0);
                    }

                    // A character's name must be entered before a Save to I used a Visual Basic input form.
                    if ( digitCheck == false || doubleCheck == false) {
                        txtName.Text = Microsoft.VisualBasic.Interaction.InputBox("You must Enter a Name.", "Type in a name", "", 200);
                    }
                }

                Int32.TryParse(txtStrength.Text, out int strength);
                Int32.TryParse(txtSuperStrength.Text, out int superStrength);
                Int32.TryParse(txtIntelligence.Text, out int intelligence);
                Int32.TryParse(txtWisdom.Text, out int wisdom);
                Int32.TryParse(txtConstitution.Text, out int constitution);
                Int32.TryParse(txtDexterity.Text, out int dexterity);
                Int32.TryParse(txtAgility.Text, out int agility);
                Int32.TryParse(txtCharisma.Text, out int charisma);

                rolled = new Character(txtName.Text, txtClass.Text, txtRace.Text, strength, superStrength, intelligence, wisdom, constitution, dexterity, agility, charisma) { };
                rolled.AddCharacter(rolled);
                SaveCharacter(rolled);
                ClearFields();
            }
        }

        // Saves a new character to an Excel file.
        public void SaveCharacter(Character rolled) {

            try{
                using (StreamWriter writer = new StreamWriter("Character.csv", true)){
       
                    writer.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", rolled.Name, rolled.Role, rolled.Race, rolled.Strength, rolled.SuperStrength, rolled.Intelligence, rolled.Wisdom, rolled.Constitution, rolled.Dexterity, rolled.Agility, rolled.Charisma);

                    writer.Close();
                }
            } catch {} 
            
            ClearFields();
        }

        // This assists the user is choosing a well balanced character for their chosen class.
        public void BestOptions(Character ra) {
            double minimum = 12.0;
            double fair = 14.0;
            double great = 16.0;

            // These are the calculations for the race.  For example: the two primary stats for a warrior are
            // strength and constitution, so more weight is given to them in the calculation.
            double warriorAverage = (ra.Strength + (ra.Constitution * .75) + 4.5) / 2.0;
            double clericAverage = (ra.Wisdom + (ra.Constitution * .75) + 4.5) / 2.0;
            double mageAverage = (ra.Intelligence + (((ra.Agility + ra.Dexterity) * .75) + 8) / 2.0) / 2.0;
            double thiefAverage = (ra.Dexterity + (((ra.Agility + ra.Intelligence) * .75) + 8) / 2.0) / 2.0;

            // These adjust the various backcolors depending on the above weighted calculations.  Green is
            // the best and no color at all is the least desired stat.
            if (warriorAverage > minimum && warriorAverage < fair) {
                rdoWarrior.BackColor = Color.LightGray;
            } else if (warriorAverage >= fair && warriorAverage < great) {
                rdoWarrior.BackColor = Color.LightGreen;          
            } else if (warriorAverage >= great) {
                rdoWarrior.BackColor = Color.ForestGreen;
            } else {
                rdoWarrior.BackColor = Color.Turquoise;
            }

            if (mageAverage > minimum && mageAverage < fair) {
                rdoMage.BackColor = Color.LightGray;
            } else if (mageAverage >= fair && mageAverage < great) {
                rdoMage.BackColor = Color.LightGreen;
            } else if (mageAverage >= great) {
                rdoMage.BackColor = Color.ForestGreen;
            } else {
                rdoMage.BackColor = Color.Turquoise;
            }

            if (clericAverage > minimum && clericAverage < fair) {
                rdoCleric.BackColor = Color.LightGray;
            } else if (clericAverage >= fair && clericAverage < great) {
                rdoCleric.BackColor = Color.LightGreen;
            } else if(clericAverage >= great){
                rdoCleric.BackColor = Color.ForestGreen;
            } else {
                rdoCleric.BackColor = Color.Turquoise;
            }

            if (thiefAverage > minimum && thiefAverage < fair) {
                rdoThief.BackColor = Color.LightGray;
            } else if (thiefAverage >= fair && thiefAverage < great) {
                rdoThief.BackColor = Color.LightGreen;
            } else if( thiefAverage >= great) {
                rdoThief.BackColor = Color.ForestGreen;
            } else {
                rdoThief.BackColor = Color.Turquoise;
            }
        }

        // A universal clear everything method.
        public void ClearFields() {
            rdoWarrior.Checked = false;
            rdoMage.Checked = false;
            rdoCleric.Checked = false;
            rdoThief.Checked = false;
            rdoBarbarian.Checked = false;
            rdoWarrior.Checked = false;
            rdoElf.Checked = false;
            rdoDwarf.Checked = false;
            rdoWarrior.BackColor = Color.Transparent;
            rdoMage.BackColor = Color.Transparent;
            rdoCleric.BackColor = Color.Transparent;
            rdoThief.BackColor = Color.Transparent;
            grpRace.Enabled = true;
            grpClass.Enabled = true;
            GrpClassBoxChecked = false;
            GrpRaceBoxChecked = false;
            btnReroll.Enabled = true;
            btnAcceptRoll.Enabled = true;
            lblFrameRace.BackColor = Color.Turquoise;
            lblFrameClass.BackColor = Color.Turquoise;
            grpRace.BackColor = Color.Turquoise;
            grpClass.BackColor = Color.Turquoise;
            btnReroll.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            txtRace.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
            txtStrength.Text = "";
            txtSuperStrength.Text = "";
            txtIntelligence.Text = "";
            txtWisdom.Text = "";
            txtConstitution.Text = "";
            txtDexterity.Text = "";
            txtAgility.Text = "";
            txtCharisma.Text = "";
        }


        // The following are the events for the radio buttons that que other events or actions.
        private void rdoHuman_CheckedChanged(object sender, EventArgs e) {
            txtRace.Text = "Human";
            btnAcceptRoll.Text = "Choose Class";
            btnAcceptRoll.Enabled = false;
            GrpRaceBoxChecked = true;
            DisplayStats(rolled);
        }

        private void rdoElf_CheckedChanged(object sender, EventArgs e) {
            txtRace.Text = "Wood Elf";
            btnAcceptRoll.Text = "Choose Class";
            btnAcceptRoll.Enabled = false;
            GrpRaceBoxChecked = true;
            DisplayStats(rolled);
        }

        private void rdoDwarf_CheckedChanged(object sender, EventArgs e) {
            txtRace.Text = "Dwarf";
            btnAcceptRoll.Text = "Choose Class";
            btnAcceptRoll.Enabled = false;
            GrpRaceBoxChecked = true;
            DisplayStats(rolled);
        }

        private void rdoBarbarian_CheckedChanged(object sender, EventArgs e) {
            txtRace.Text = "Barbarian";
            btnAcceptRoll.Text = "Choose Class";
            btnAcceptRoll.Enabled = false;
            GrpRaceBoxChecked = true;        
            DisplayStats(rolled);
        }

        private void rdoWarrior_CheckedChanged(object sender, EventArgs e) {
            txtClass.Text = "Warrior";
            GrpClassBoxChecked = true;
            btnAcceptRoll.Enabled = true;
            btnAcceptRoll.Text = "Save Character";
        }

        private void rdoMage_CheckedChanged(object sender, EventArgs e) {
            txtClass.Text = "Mage";
            GrpClassBoxChecked = true;
            btnAcceptRoll.Enabled = true;
            btnAcceptRoll.Text = "Save Character";
        }

        private void rdoCleric_CheckedChanged(object sender, EventArgs e) {
            txtClass.Text = "Cleric";
            GrpClassBoxChecked = true;
            btnAcceptRoll.Enabled = true;
            btnAcceptRoll.Text = "Save Character";
        }

        private void rdoThief_CheckedChanged(object sender, EventArgs e) {
            txtClass.Text = "Rogue";
            GrpClassBoxChecked = true;
            btnAcceptRoll.Enabled = true;
            btnAcceptRoll.Text = "Save Character";
        }

        // The following two methods are group boxes to help "sense" the user's input
        // in a more general way.
        private void grpRace_Enter(object sender, EventArgs e) {
            GrpRaceBoxChecked = true;
            btnReroll.Enabled = false;
            grpClass.Enabled = true;
            btnAcceptRoll.Text = "Choose Class: ";
            lblFrameClass.BackColor = Color.DarkSeaGreen;
            lblFrameRace.BackColor = Color.Turquoise;
        }

        // When the last group box is checked, it ques other activities to set up for
        // another rolled character or to save the chosen one.
        private void grpClass_Enter(object sender, EventArgs e) {
            GrpClassBoxChecked = true;
            grpRace.Enabled = false;
            btnReroll.Enabled = true;
            btnAcceptRoll.Text = "Accept Roll:";
            btnAcceptRoll.Focus();
            btnAcceptRoll.Enabled = true;
            rdoWarrior.BackColor = Color.Turquoise;
            rdoMage.BackColor = Color.Turquoise;
            rdoCleric.BackColor = Color.Turquoise;
            rdoThief.BackColor = Color.Turquoise;
            lblFrameRace.BackColor = Color.Turquoise;
            lblFrameClass.BackColor = Color.Turquoise;
            btnAcceptRoll.FlatAppearance.BorderColor = Color.DarkSeaGreen;
        }
    }
}
