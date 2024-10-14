namespace DB_ACT1_046_Pattaguan
{
    partial class frmDeleteRecord
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
            Model = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            cbCars = new ComboBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.Location = new Point(98, 78);
            Model.Name = "Model";
            Model.Size = new Size(44, 15);
            Model.TabIndex = 0;
            Model.Text = "Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 173);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Brand:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(145, 75);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(160, 23);
            txtModel.TabIndex = 2;
            // 
            // cbCars
            // 
            cbCars.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCars.FormattingEnabled = true;
            cbCars.Items.AddRange(new object[] { "Acura", "Aston Martin", "Audi", "Bentley", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Eagle", "Ford", "Geo", "GMC", "Honda", "Hummer", "Hyundai", "Infiniti", "Isuzu", "Jeep", "Kia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "Mercedes-Benz", "Mercury", "Mitsubishi", "Nissan", "Oldsmobile", "Plymouth", "Pontiac", "Porsche", "Ram", "Saab", "Saturn", "Scion", "Shelby", "Spyker", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" });
            cbCars.Location = new Point(145, 170);
            cbCars.Name = "cbCars";
            cbCars.Size = new Size(160, 23);
            cbCars.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(98, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmDeleteRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(btnDelete);
            Controls.Add(cbCars);
            Controls.Add(txtModel);
            Controls.Add(label2);
            Controls.Add(Model);
            Name = "frmDeleteRecord";
            Text = "frmDeleteRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Model;
        private Label label2;
        private TextBox txtModel;
        private ComboBox cbCars;
        private Button btnDelete;
    }
}