namespace GarageManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            txtHP = new TextBox();
            txtModel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstGarage = new ListBox();
            lblTotalHP = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtHP);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Machine";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(238, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add to Garage";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtHP
            // 
            txtHP.Location = new Point(302, 26);
            txtHP.Name = "txtHP";
            txtHP.Size = new Size(125, 27);
            txtHP.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(67, 26);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 29);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Horsepower:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Model:";
            label1.Click += label1_Click;
            // 
            // lstGarage
            // 
            lstGarage.FormattingEnabled = true;
            lstGarage.Location = new Point(12, 135);
            lstGarage.Name = "lstGarage";
            lstGarage.Size = new Size(471, 164);
            lstGarage.TabIndex = 1;
            // 
            // lblTotalHP
            // 
            lblTotalHP.AutoSize = true;
            lblTotalHP.Location = new Point(12, 302);
            lblTotalHP.Name = "lblTotalHP";
            lblTotalHP.Size = new Size(132, 20);
            lblTotalHP.TabIndex = 2;
            lblTotalHP.Text = "Total Garage HP: 0";
            lblTotalHP.Click += lblTotalHP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalHP);
            Controls.Add(lstGarage);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnAdd;
        private TextBox txtHP;
        private TextBox txtModel;
        private Label label2;
        private ListBox lstGarage;
        private Label lblTotalHP;
    }
}
