namespace ContestProject.Forms
{
    partial class Jury
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
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbContest = new System.Windows.Forms.ComboBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.dgwResult = new System.Windows.Forms.DataGridView();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.txbContest = new System.Windows.Forms.TextBox();
            this.btnRed = new System.Windows.Forms.Button();
            this.txbNewResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(133, 43);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(43, 70);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(184, 33);
            this.cmbUser.TabIndex = 1;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // cmbContest
            // 
            this.cmbContest.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbContest.FormattingEnabled = true;
            this.cmbContest.Location = new System.Drawing.Point(43, 109);
            this.cmbContest.Name = "cmbContest";
            this.cmbContest.Size = new System.Drawing.Size(184, 33);
            this.cmbContest.TabIndex = 1;
            this.cmbContest.SelectedIndexChanged += new System.EventHandler(this.cmbContest_SelectedIndexChanged);
            // 
            // txbResult
            // 
            this.txbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbResult.Location = new System.Drawing.Point(43, 148);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(184, 29);
            this.txbResult.TabIndex = 2;
            // 
            // btnAddResult
            // 
            this.btnAddResult.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddResult.Location = new System.Drawing.Point(60, 208);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(151, 63);
            this.btnAddResult.TabIndex = 3;
            this.btnAddResult.Text = "Добавить результат";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // dgwResult
            // 
            this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResult.Location = new System.Drawing.Point(252, 12);
            this.dgwResult.Name = "dgwResult";
            this.dgwResult.Size = new System.Drawing.Size(824, 402);
            this.dgwResult.TabIndex = 4;
            // 
            // txbFullName
            // 
            this.txbFullName.Location = new System.Drawing.Point(70, 287);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(100, 20);
            this.txbFullName.TabIndex = 5;
            // 
            // txbContest
            // 
            this.txbContest.Location = new System.Drawing.Point(70, 326);
            this.txbContest.Name = "txbContest";
            this.txbContest.Size = new System.Drawing.Size(100, 20);
            this.txbContest.TabIndex = 5;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(70, 405);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 6;
            this.btnRed.Text = "button1";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // txbNewResult
            // 
            this.txbNewResult.Location = new System.Drawing.Point(70, 366);
            this.txbNewResult.Name = "txbNewResult";
            this.txbNewResult.Size = new System.Drawing.Size(100, 20);
            this.txbNewResult.TabIndex = 5;
            this.txbNewResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Jury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.txbNewResult);
            this.Controls.Add(this.txbContest);
            this.Controls.Add(this.txbFullName);
            this.Controls.Add(this.dgwResult);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.cmbContest);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.lblDate);
            this.Name = "Jury";
            this.Text = "Jury";
            this.Load += new System.EventHandler(this.Jury_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbContest;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.DataGridView dgwResult;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.TextBox txbContest;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.TextBox txbNewResult;
    }
}