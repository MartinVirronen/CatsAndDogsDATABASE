namespace CatsAndDogsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pets = new System.Windows.Forms.Label();
            this.listPets = new System.Windows.Forms.ListBox();
            this.PetNames = new System.Windows.Forms.Label();
            this.listPetNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Pets
            // 
            this.Pets.AutoSize = true;
            this.Pets.Location = new System.Drawing.Point(54, 64);
            this.Pets.Name = "Pets";
            this.Pets.Size = new System.Drawing.Size(28, 13);
            this.Pets.TabIndex = 0;
            this.Pets.Text = "Pets";
            // 
            // listPets
            // 
            this.listPets.FormattingEnabled = true;
            this.listPets.Location = new System.Drawing.Point(57, 114);
            this.listPets.Name = "listPets";
            this.listPets.Size = new System.Drawing.Size(148, 147);
            this.listPets.TabIndex = 1;
            this.listPets.SelectedIndexChanged += new System.EventHandler(this.listPets_SelectedIndexChanged);
            // 
            // PetNames
            // 
            this.PetNames.AutoSize = true;
            this.PetNames.Location = new System.Drawing.Point(315, 64);
            this.PetNames.Name = "PetNames";
            this.PetNames.Size = new System.Drawing.Size(59, 13);
            this.PetNames.TabIndex = 2;
            this.PetNames.Text = "Pet Names";
            // 
            // listPetNames
            // 
            this.listPetNames.FormattingEnabled = true;
            this.listPetNames.Location = new System.Drawing.Point(318, 114);
            this.listPetNames.Name = "listPetNames";
            this.listPetNames.Size = new System.Drawing.Size(123, 147);
            this.listPetNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPetNames);
            this.Controls.Add(this.PetNames);
            this.Controls.Add(this.listPets);
            this.Controls.Add(this.Pets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pets;
        private System.Windows.Forms.ListBox listPets;
        private System.Windows.Forms.Label PetNames;
        private System.Windows.Forms.ListBox listPetNames;
    }
}

