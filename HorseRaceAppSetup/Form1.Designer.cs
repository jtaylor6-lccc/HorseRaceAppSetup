namespace HorseRaceAppSetup
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddHorse = new System.Windows.Forms.Button();
            this.listHorses1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 38);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(165, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Horses";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(196, 294);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(94, 20);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "MaxNumber";
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(48, 286);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(129, 36);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Highest #";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(196, 336);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(90, 20);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "MinNumber";
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(48, 332);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(129, 34);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "Lowest #";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(200, 408);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Name Entry";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(200, 446);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 26);
            this.txtNumber.TabIndex = 6;
            this.txtNumber.Text = "Number Entry";
            // 
            // btnAddHorse
            // 
            this.btnAddHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHorse.Location = new System.Drawing.Point(48, 418);
            this.btnAddHorse.Name = "btnAddHorse";
            this.btnAddHorse.Size = new System.Drawing.Size(129, 31);
            this.btnAddHorse.TabIndex = 7;
            this.btnAddHorse.Text = "Add Horse";
            this.btnAddHorse.UseVisualStyleBackColor = true;
            this.btnAddHorse.Click += new System.EventHandler(this.btnAddHorse_Click);
            // 
            // listHorses1
            // 
            this.listHorses1.BackColor = System.Drawing.SystemColors.Window;
            this.listHorses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listHorses1.Location = new System.Drawing.Point(470, 54);
            this.listHorses1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listHorses1.Name = "listHorses1";
            this.listHorses1.Size = new System.Drawing.Size(189, 394);
            this.listHorses1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 500);
            this.Controls.Add(this.listHorses1);
            this.Controls.Add(this.btnAddHorse);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddHorse;
        private System.Windows.Forms.Label listHorses1;
    }
}

