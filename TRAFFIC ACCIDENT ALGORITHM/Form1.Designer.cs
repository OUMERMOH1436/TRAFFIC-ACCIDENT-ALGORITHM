
namespace TRAFFIC_ACCIDENT_ALGORITHM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.split80 = new System.Windows.Forms.Button();
            this.split90 = new System.Windows.Forms.Button();
            this.likelihood = new System.Windows.Forms.Button();
            this.prob = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1233, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOAD TRAFFIC DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(1105, 1);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(129, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear Analysis";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // split80
            // 
            this.split80.AccessibleName = "80-20";
            this.split80.Location = new System.Drawing.Point(368, 1);
            this.split80.Name = "split80";
            this.split80.Size = new System.Drawing.Size(148, 23);
            this.split80.TabIndex = 3;
            this.split80.Text = "SPLIT data BY 80/20%";
            this.split80.UseVisualStyleBackColor = true;
            this.split80.Click += new System.EventHandler(this.split80_Click);
            // 
            // split90
            // 
            this.split90.AccessibleName = "90-10";
            this.split90.Location = new System.Drawing.Point(368, 25);
            this.split90.Name = "split90";
            this.split90.Size = new System.Drawing.Size(148, 23);
            this.split90.TabIndex = 4;
            this.split90.Text = "SPLIT data BY 90/10%";
            this.split90.UseVisualStyleBackColor = true;
            this.split90.Click += new System.EventHandler(this.split90_Click);
            // 
            // likelihood
            // 
            this.likelihood.Location = new System.Drawing.Point(543, 1);
            this.likelihood.Name = "likelihood";
            this.likelihood.Size = new System.Drawing.Size(204, 23);
            this.likelihood.TabIndex = 5;
            this.likelihood.Text = "GENERATE LIKELIHOOD TABLE";
            this.likelihood.UseVisualStyleBackColor = true;
            this.likelihood.Click += new System.EventHandler(this.likelihood_Click);
            // 
            // prob
            // 
            this.prob.Location = new System.Drawing.Point(543, 25);
            this.prob.Name = "prob";
            this.prob.Size = new System.Drawing.Size(204, 23);
            this.prob.TabIndex = 6;
            this.prob.Text = "CALCULATE THE TEST DATA";
            this.prob.UseVisualStyleBackColor = true;
            this.prob.Click += new System.EventHandler(this.prob_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "LOAD TRAINING DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "LOAD TEST DATA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "LOAD CLASS LABEL PROBABLITY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(776, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "LOAD ATTRIBUTE PROBABLITY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prob);
            this.Controls.Add(this.likelihood);
            this.Controls.Add(this.split90);
            this.Controls.Add(this.split80);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button split80;
        private System.Windows.Forms.Button split90;
        private System.Windows.Forms.Button likelihood;
        private System.Windows.Forms.Button prob;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

