
namespace Dungeon_Play {
    partial class frmListCharacters {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCreateCharacter = new System.Windows.Forms.Label();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.txtCharisma = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtDexterity = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.txtWisdom = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSuperStrength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreateCharacter
            // 
            this.lblCreateCharacter.AutoSize = true;
            this.lblCreateCharacter.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCharacter.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCreateCharacter.Location = new System.Drawing.Point(435, 25);
            this.lblCreateCharacter.Name = "lblCreateCharacter";
            this.lblCreateCharacter.Size = new System.Drawing.Size(347, 37);
            this.lblCreateCharacter.TabIndex = 17;
            this.lblCreateCharacter.Text = "List Characters Screen";
            // 
            // lstCharacters
            // 
            this.lstCharacters.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 17;
            this.lstCharacters.Location = new System.Drawing.Point(67, 120);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(201, 344);
            this.lstCharacters.TabIndex = 18;
            this.lstCharacters.SelectedIndexChanged += new System.EventHandler(this.lstCharacters_SelectedIndexChanged);
            // 
            // txtCharisma
            // 
            this.txtCharisma.Location = new System.Drawing.Point(439, 442);
            this.txtCharisma.Name = "txtCharisma";
            this.txtCharisma.Size = new System.Drawing.Size(68, 22);
            this.txtCharisma.TabIndex = 35;
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(439, 396);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.Size = new System.Drawing.Size(68, 22);
            this.txtAgility.TabIndex = 34;
            // 
            // txtDexterity
            // 
            this.txtDexterity.Location = new System.Drawing.Point(439, 350);
            this.txtDexterity.Name = "txtDexterity";
            this.txtDexterity.Size = new System.Drawing.Size(68, 22);
            this.txtDexterity.TabIndex = 33;
            // 
            // txtConstitution
            // 
            this.txtConstitution.Location = new System.Drawing.Point(439, 304);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(68, 22);
            this.txtConstitution.TabIndex = 32;
            // 
            // txtWisdom
            // 
            this.txtWisdom.Location = new System.Drawing.Point(439, 258);
            this.txtWisdom.Name = "txtWisdom";
            this.txtWisdom.Size = new System.Drawing.Size(68, 22);
            this.txtWisdom.TabIndex = 31;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(439, 212);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(68, 22);
            this.txtIntelligence.TabIndex = 30;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(439, 166);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(68, 22);
            this.txtStrength.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(439, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 22);
            this.txtName.TabIndex = 27;
            // 
            // lblCharisma
            // 
            this.lblCharisma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCharisma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCharisma.Location = new System.Drawing.Point(323, 442);
            this.lblCharisma.Margin = new System.Windows.Forms.Padding(2);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(95, 25);
            this.lblCharisma.TabIndex = 26;
            this.lblCharisma.Text = "Charisma:";
            this.lblCharisma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAgility
            // 
            this.lblAgility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgility.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAgility.Location = new System.Drawing.Point(323, 396);
            this.lblAgility.Margin = new System.Windows.Forms.Padding(2);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(95, 25);
            this.lblAgility.TabIndex = 25;
            this.lblAgility.Text = "Agility:";
            this.lblAgility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDexterity
            // 
            this.lblDexterity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDexterity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDexterity.Location = new System.Drawing.Point(323, 350);
            this.lblDexterity.Margin = new System.Windows.Forms.Padding(2);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(95, 25);
            this.lblDexterity.TabIndex = 24;
            this.lblDexterity.Text = "Dexterity:";
            this.lblDexterity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConstitution
            // 
            this.lblConstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConstitution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblConstitution.Location = new System.Drawing.Point(323, 304);
            this.lblConstitution.Margin = new System.Windows.Forms.Padding(2);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(95, 25);
            this.lblConstitution.TabIndex = 23;
            this.lblConstitution.Text = "Constitution:";
            this.lblConstitution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWisdom
            // 
            this.lblWisdom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWisdom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWisdom.Location = new System.Drawing.Point(323, 258);
            this.lblWisdom.Margin = new System.Windows.Forms.Padding(2);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(95, 25);
            this.lblWisdom.TabIndex = 22;
            this.lblWisdom.Text = "Wisdom:";
            this.lblWisdom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIntelligence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblIntelligence.Location = new System.Drawing.Point(323, 212);
            this.lblIntelligence.Margin = new System.Windows.Forms.Padding(2);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(95, 25);
            this.lblIntelligence.TabIndex = 21;
            this.lblIntelligence.Text = "Intelligence:";
            this.lblIntelligence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStrength
            // 
            this.lblStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStrength.Location = new System.Drawing.Point(323, 166);
            this.lblStrength.Margin = new System.Windows.Forms.Padding(2);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(95, 25);
            this.lblStrength.TabIndex = 20;
            this.lblStrength.Text = "Strength:";
            this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Location = new System.Drawing.Point(323, 120);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 25);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(668, 169);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(135, 22);
            this.txtRace.TabIndex = 38;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(829, 169);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(135, 22);
            this.txtClass.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(668, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Race:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(829, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Class:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.Location = new System.Drawing.Point(443, 565);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 45);
            this.btnCreate.TabIndex = 41;
            this.btnCreate.Text = "Create Character";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMainMenu.Location = new System.Drawing.Point(288, 565);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(100, 45);
            this.btnMainMenu.TabIndex = 40;
            this.btnMainMenu.Text = "Return to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(133, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 45);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete Character";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSuperStrength
            // 
            this.txtSuperStrength.Location = new System.Drawing.Point(527, 166);
            this.txtSuperStrength.Name = "txtSuperStrength";
            this.txtSuperStrength.Size = new System.Drawing.Size(68, 22);
            this.txtSuperStrength.TabIndex = 29;
            // 
            // frmListCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.txtSuperStrength);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharisma);
            this.Controls.Add(this.txtAgility);
            this.Controls.Add(this.txtDexterity);
            this.Controls.Add(this.txtConstitution);
            this.Controls.Add(this.txtWisdom);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCharisma);
            this.Controls.Add(this.lblAgility);
            this.Controls.Add(this.lblDexterity);
            this.Controls.Add(this.lblConstitution);
            this.Controls.Add(this.lblWisdom);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.lblCreateCharacter);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListCharacters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListCharacters";
            this.Load += new System.EventHandler(this.frmListCharacters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateCharacter;
        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.TextBox txtCharisma;
        private System.Windows.Forms.TextBox txtAgility;
        private System.Windows.Forms.TextBox txtDexterity;
        private System.Windows.Forms.TextBox txtConstitution;
        private System.Windows.Forms.TextBox txtWisdom;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSuperStrength;
    }
}