
namespace Dungeon_Play {
    partial class frmMainForm {
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
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.rdoEnterTown = new System.Windows.Forms.RadioButton();
            this.rdoExit = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoCreate = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.rdoEnterTown);
            this.grpChoice.Controls.Add(this.rdoExit);
            this.grpChoice.Controls.Add(this.rdoList);
            this.grpChoice.Controls.Add(this.rdoCreate);
            this.grpChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpChoice.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoice.Location = new System.Drawing.Point(73, 134);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Padding = new System.Windows.Forms.Padding(6);
            this.grpChoice.Size = new System.Drawing.Size(172, 288);
            this.grpChoice.TabIndex = 0;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "Please make choice:";
            // 
            // rdoEnterTown
            // 
            this.rdoEnterTown.AutoSize = true;
            this.rdoEnterTown.Location = new System.Drawing.Point(28, 169);
            this.rdoEnterTown.Name = "rdoEnterTown";
            this.rdoEnterTown.Size = new System.Drawing.Size(97, 21);
            this.rdoEnterTown.TabIndex = 3;
            this.rdoEnterTown.TabStop = true;
            this.rdoEnterTown.Text = "Enter Town";
            this.rdoEnterTown.UseVisualStyleBackColor = true;
            // 
            // rdoExit
            // 
            this.rdoExit.AutoSize = true;
            this.rdoExit.Location = new System.Drawing.Point(24, 232);
            this.rdoExit.Name = "rdoExit";
            this.rdoExit.Size = new System.Drawing.Size(50, 21);
            this.rdoExit.TabIndex = 2;
            this.rdoExit.TabStop = true;
            this.rdoExit.Text = "Exit";
            this.rdoExit.UseVisualStyleBackColor = true;
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(24, 106);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(123, 21);
            this.rdoList.TabIndex = 1;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "List Characters";
            this.rdoList.UseVisualStyleBackColor = true;
            // 
            // rdoCreate
            // 
            this.rdoCreate.AutoSize = true;
            this.rdoCreate.Location = new System.Drawing.Point(24, 43);
            this.rdoCreate.Name = "rdoCreate";
            this.rdoCreate.Size = new System.Drawing.Size(134, 21);
            this.rdoCreate.TabIndex = 0;
            this.rdoCreate.TabStop = true;
            this.rdoCreate.Text = "Create Character";
            this.rdoCreate.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.AutoEllipsis = true;
            this.btnContinue.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnContinue.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(101, 450);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(115, 47);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue after Selection";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // picMain
            // 
            this.picMain.BackgroundImage = global::Dungeon_Play.Properties.Resources.dragon_3462724_1280;
            this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMain.Location = new System.Drawing.Point(309, 102);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(900, 500);
            this.picMain.TabIndex = 2;
            this.picMain.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(555, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Welcome to DungeonPlay";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.grpChoice);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.grpChoice.ResumeLayout(false);
            this.grpChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoice;
        private System.Windows.Forms.RadioButton rdoExit;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoCreate;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdoEnterTown;
    }
}

