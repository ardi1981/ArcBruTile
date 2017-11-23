namespace BrutileArcGIS.forms
{
    partial class AddStravaForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbActivityTypeWinter = new System.Windows.Forms.RadioButton();
            this.rdbActivityTypeWater = new System.Windows.Forms.RadioButton();
            this.rdbActivityTypeRun = new System.Windows.Forms.RadioButton();
            this.rdbActivityTypeRide = new System.Windows.Forms.RadioButton();
            this.rdbActivityTypeAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbColorRed = new System.Windows.Forms.RadioButton();
            this.rdbColorGray = new System.Windows.Forms.RadioButton();
            this.rdbColorBlue = new System.Windows.Forms.RadioButton();
            this.rdbColorHot = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(27, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(617, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Strava Map:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbActivityTypeWinter);
            this.groupBox3.Controls.Add(this.rdbActivityTypeWater);
            this.groupBox3.Controls.Add(this.rdbActivityTypeRun);
            this.groupBox3.Controls.Add(this.rdbActivityTypeRide);
            this.groupBox3.Controls.Add(this.rdbActivityTypeAll);
            this.groupBox3.Location = new System.Drawing.Point(17, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activity type";
            // 
            // rdbActivityTypeWinter
            // 
            this.rdbActivityTypeWinter.AutoSize = true;
            this.rdbActivityTypeWinter.Location = new System.Drawing.Point(330, 21);
            this.rdbActivityTypeWinter.Name = "rdbActivityTypeWinter";
            this.rdbActivityTypeWinter.Size = new System.Drawing.Size(66, 21);
            this.rdbActivityTypeWinter.TabIndex = 10;
            this.rdbActivityTypeWinter.Tag = "winter";
            this.rdbActivityTypeWinter.Text = "winter";
            this.rdbActivityTypeWinter.UseVisualStyleBackColor = true;
            this.rdbActivityTypeWinter.CheckedChanged += new System.EventHandler(this.rdbActivityTypeChanged);
            // 
            // rdbActivityTypeWater
            // 
            this.rdbActivityTypeWater.AutoSize = true;
            this.rdbActivityTypeWater.Location = new System.Drawing.Point(248, 20);
            this.rdbActivityTypeWater.Name = "rdbActivityTypeWater";
            this.rdbActivityTypeWater.Size = new System.Drawing.Size(63, 21);
            this.rdbActivityTypeWater.TabIndex = 9;
            this.rdbActivityTypeWater.Tag = "water";
            this.rdbActivityTypeWater.Text = "water";
            this.rdbActivityTypeWater.UseVisualStyleBackColor = true;
            this.rdbActivityTypeWater.CheckedChanged += new System.EventHandler(this.rdbActivityTypeChanged);
            // 
            // rdbActivityTypeRun
            // 
            this.rdbActivityTypeRun.AutoSize = true;
            this.rdbActivityTypeRun.Location = new System.Drawing.Point(180, 21);
            this.rdbActivityTypeRun.Name = "rdbActivityTypeRun";
            this.rdbActivityTypeRun.Size = new System.Drawing.Size(50, 21);
            this.rdbActivityTypeRun.TabIndex = 8;
            this.rdbActivityTypeRun.Tag = "run";
            this.rdbActivityTypeRun.Text = "run";
            this.rdbActivityTypeRun.UseVisualStyleBackColor = true;
            this.rdbActivityTypeRun.CheckedChanged += new System.EventHandler(this.rdbActivityTypeChanged);
            // 
            // rdbActivityTypeRide
            // 
            this.rdbActivityTypeRide.AutoSize = true;
            this.rdbActivityTypeRide.Location = new System.Drawing.Point(97, 21);
            this.rdbActivityTypeRide.Name = "rdbActivityTypeRide";
            this.rdbActivityTypeRide.Size = new System.Drawing.Size(53, 21);
            this.rdbActivityTypeRide.TabIndex = 7;
            this.rdbActivityTypeRide.Tag = "ride";
            this.rdbActivityTypeRide.Text = "ride";
            this.rdbActivityTypeRide.UseVisualStyleBackColor = true;
            this.rdbActivityTypeRide.CheckedChanged += new System.EventHandler(this.rdbActivityTypeChanged);
            // 
            // rdbActivityTypeAll
            // 
            this.rdbActivityTypeAll.AutoSize = true;
            this.rdbActivityTypeAll.Checked = true;
            this.rdbActivityTypeAll.Location = new System.Drawing.Point(30, 20);
            this.rdbActivityTypeAll.Name = "rdbActivityTypeAll";
            this.rdbActivityTypeAll.Size = new System.Drawing.Size(43, 21);
            this.rdbActivityTypeAll.TabIndex = 6;
            this.rdbActivityTypeAll.TabStop = true;
            this.rdbActivityTypeAll.Tag = "all";
            this.rdbActivityTypeAll.Text = "all";
            this.rdbActivityTypeAll.UseVisualStyleBackColor = true;
            this.rdbActivityTypeAll.CheckedChanged += new System.EventHandler(this.rdbActivityTypeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbColorRed);
            this.groupBox1.Controls.Add(this.rdbColorGray);
            this.groupBox1.Controls.Add(this.rdbColorBlue);
            this.groupBox1.Controls.Add(this.rdbColorHot);
            this.groupBox1.Location = new System.Drawing.Point(17, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // rdbColorRed
            // 
            this.rdbColorRed.AutoSize = true;
            this.rdbColorRed.Location = new System.Drawing.Point(248, 20);
            this.rdbColorRed.Name = "rdbColorRed";
            this.rdbColorRed.Size = new System.Drawing.Size(50, 21);
            this.rdbColorRed.TabIndex = 9;
            this.rdbColorRed.Tag = "red";
            this.rdbColorRed.Text = "red";
            this.rdbColorRed.UseVisualStyleBackColor = true;
            this.rdbColorRed.CheckedChanged += new System.EventHandler(this.rdbColorChanged);
            // 
            // rdbColorGray
            // 
            this.rdbColorGray.AutoSize = true;
            this.rdbColorGray.Location = new System.Drawing.Point(180, 21);
            this.rdbColorGray.Name = "rdbColorGray";
            this.rdbColorGray.Size = new System.Drawing.Size(57, 21);
            this.rdbColorGray.TabIndex = 8;
            this.rdbColorGray.Tag = "gray";
            this.rdbColorGray.Text = "gray";
            this.rdbColorGray.UseVisualStyleBackColor = true;
            this.rdbColorGray.CheckedChanged += new System.EventHandler(this.rdbColorChanged);
            // 
            // rdbColorBlue
            // 
            this.rdbColorBlue.AutoSize = true;
            this.rdbColorBlue.Location = new System.Drawing.Point(94, 20);
            this.rdbColorBlue.Name = "rdbColorBlue";
            this.rdbColorBlue.Size = new System.Drawing.Size(56, 21);
            this.rdbColorBlue.TabIndex = 7;
            this.rdbColorBlue.Tag = "blue";
            this.rdbColorBlue.Text = "blue";
            this.rdbColorBlue.UseVisualStyleBackColor = true;
            this.rdbColorBlue.CheckedChanged += new System.EventHandler(this.rdbColorChanged);
            // 
            // rdbColorHot
            // 
            this.rdbColorHot.AutoSize = true;
            this.rdbColorHot.Checked = true;
            this.rdbColorHot.Location = new System.Drawing.Point(30, 20);
            this.rdbColorHot.Name = "rdbColorHot";
            this.rdbColorHot.Size = new System.Drawing.Size(49, 21);
            this.rdbColorHot.TabIndex = 6;
            this.rdbColorHot.TabStop = true;
            this.rdbColorHot.Tag = "hot";
            this.rdbColorHot.Text = "hot";
            this.rdbColorHot.UseVisualStyleBackColor = true;
            this.rdbColorHot.CheckedChanged += new System.EventHandler(this.rdbColorChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(533, 241);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(380, 241);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 28);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Add Map";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStravaForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(659, 275);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Name = "AddStravaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Strava 2017 Map";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbColorBlue;
        private System.Windows.Forms.RadioButton rdbColorHot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbActivityTypeWinter;
        private System.Windows.Forms.RadioButton rdbActivityTypeWater;
        private System.Windows.Forms.RadioButton rdbActivityTypeRun;
        private System.Windows.Forms.RadioButton rdbActivityTypeRide;
        private System.Windows.Forms.RadioButton rdbActivityTypeAll;
        private System.Windows.Forms.RadioButton rdbColorRed;
        private System.Windows.Forms.RadioButton rdbColorGray;
    }
}