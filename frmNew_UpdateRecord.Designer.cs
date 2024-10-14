namespace DB_ACT1_046_Pattaguan
{
    partial class frmNew_UpdateRecord
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
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtModel = new TextBox();
            txtID = new TextBox();
            txtYear = new TextBox();
            cbBrand = new ComboBox();
            btnIns = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(63, 50);
            ID.Name = "ID";
            ID.Size = new Size(21, 15);
            ID.TabIndex = 0;
            ID.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 102);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "MODEL:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 215);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "YEAR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 155);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "BRAND:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(93, 102);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(121, 23);
            txtModel.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(93, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 23);
            txtID.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(93, 212);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(121, 23);
            txtYear.TabIndex = 6;
            // 
            // cbBrand
            // 
            cbBrand.AutoCompleteCustomSource.AddRange(new string[] { "Acura", "Aston Martin", "Audi", "Bentley", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Eagle", "Ford", "Geo", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jeep", "Kia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "Mercedes-Benz", "Mercury", "Mitsubishi", "Nissan", "Oldsmobile", "Plymouth", "Pontiac", "Porsche", "Ram", "Saab", "Saturn", "Scion", "Shelby", "Spyker", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" });
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FormattingEnabled = true;
            cbBrand.Items.AddRange(new object[] { "Acura", "Aston Martin", "Audi", "Bentley", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Eagle", "Ford", "Geo", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jeep", "Kia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "Mercedes-Benz", "Mercury", "Mitsubishi", "Nissan", "Oldsmobile", "Plymouth", "Pontiac", "Porsche", "Ram", "Saab", "Saturn", "Scion", "Shelby", "Spyker", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" });
            cbBrand.Location = new Point(93, 155);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.TabIndex = 7;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(46, 292);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(84, 33);
            btnIns.TabIndex = 8;
            btnIns.Text = "Insert";
            btnIns.UseVisualStyleBackColor = true;
            btnIns.Click += btnIns_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 292);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 33);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmNew_UpdateRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnIns);
            Controls.Add(cbBrand);
            Controls.Add(txtYear);
            Controls.Add(txtID);
            Controls.Add(txtModel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Name = "frmNew_UpdateRecord";
            Text = "frmNew_UpdateRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtModel;
        private TextBox txtID;
        private TextBox txtYear;
        private ComboBox cbBrand;
        private Button btnIns;
        private Button btnUpdate;
    }
}