
namespace SelectServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfindServers = new System.Windows.Forms.Button();
            this.btnPosSave = new System.Windows.Forms.Button();
            this.statusimg = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnQBsave = new System.Windows.Forms.Button();
            this.imgQb = new System.Windows.Forms.PictureBox();
            this.CboxServers = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusimg)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select a Quickbooks Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxServers);
            this.groupBox1.Controls.Add(this.statusimg);
            this.groupBox1.Controls.Add(this.btnPosSave);
            this.groupBox1.Controls.Add(this.btnfindServers);
            this.groupBox1.Location = new System.Drawing.Point(30, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - Point Of Sale Server";
            // 
            // btnfindServers
            // 
            this.btnfindServers.Location = new System.Drawing.Point(6, 50);
            this.btnfindServers.Name = "btnfindServers";
            this.btnfindServers.Size = new System.Drawing.Size(156, 23);
            this.btnfindServers.TabIndex = 1;
            this.btnfindServers.Text = "Find All Available Servers";
            this.btnfindServers.UseVisualStyleBackColor = true;
            this.btnfindServers.Click += new System.EventHandler(this.btnfindServers_Click);
            // 
            // btnPosSave
            // 
            this.btnPosSave.Enabled = false;
            this.btnPosSave.Location = new System.Drawing.Point(273, 82);
            this.btnPosSave.Name = "btnPosSave";
            this.btnPosSave.Size = new System.Drawing.Size(75, 23);
            this.btnPosSave.TabIndex = 2;
            this.btnPosSave.Text = "Save";
            this.btnPosSave.UseVisualStyleBackColor = true;
            this.btnPosSave.Click += new System.EventHandler(this.btnPosSave_Click);
            // 
            // statusimg
            // 
            this.statusimg.Location = new System.Drawing.Point(6, 76);
            this.statusimg.Name = "statusimg";
            this.statusimg.Size = new System.Drawing.Size(34, 29);
            this.statusimg.TabIndex = 2;
            this.statusimg.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgQb);
            this.groupBox2.Controls.Add(this.btnQBsave);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(30, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - QuickBooks Accountant";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(279, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Select ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(273, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnQBsave
            // 
            this.btnQBsave.Location = new System.Drawing.Point(273, 71);
            this.btnQBsave.Name = "btnQBsave";
            this.btnQBsave.Size = new System.Drawing.Size(75, 23);
            this.btnQBsave.TabIndex = 2;
            this.btnQBsave.Text = "Save";
            this.btnQBsave.UseVisualStyleBackColor = true;
            // 
            // imgQb
            // 
            this.imgQb.Location = new System.Drawing.Point(6, 66);
            this.imgQb.Name = "imgQb";
            this.imgQb.Size = new System.Drawing.Size(34, 29);
            this.imgQb.TabIndex = 3;
            this.imgQb.TabStop = false;
            // 
            // CboxServers
            // 
            this.CboxServers.FormattingEnabled = true;
            this.CboxServers.Location = new System.Drawing.Point(6, 23);
            this.CboxServers.Name = "CboxServers";
            this.CboxServers.Size = new System.Drawing.Size(342, 21);
            this.CboxServers.TabIndex = 3;
            this.CboxServers.Text = "- Select a Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusimg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox statusimg;
        private System.Windows.Forms.Button btnPosSave;
        private System.Windows.Forms.Button btnfindServers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnQBsave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox imgQb;
        private System.Windows.Forms.ComboBox CboxServers;
    }
}

