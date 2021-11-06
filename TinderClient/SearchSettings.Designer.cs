namespace TinderClient
{
    partial class SearchSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSettings));
            this.ageMin = new System.Windows.Forms.NumericUpDown();
            this.ageMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.distanceFilter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // ageMin
            // 
            this.ageMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMin.Location = new System.Drawing.Point(75, 9);
            this.ageMin.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageMin.Name = "ageMin";
            this.ageMin.Size = new System.Drawing.Size(65, 22);
            this.ageMin.TabIndex = 0;
            this.ageMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // ageMax
            // 
            this.ageMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageMax.Location = new System.Drawing.Point(75, 37);
            this.ageMax.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.ageMax.Name = "ageMax";
            this.ageMax.Size = new System.Drawing.Size(65, 22);
            this.ageMax.TabIndex = 1;
            this.ageMax.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance";
            // 
            // distanceFilter
            // 
            this.distanceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceFilter.Location = new System.Drawing.Point(75, 65);
            this.distanceFilter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distanceFilter.Name = "distanceFilter";
            this.distanceFilter.Size = new System.Drawing.Size(65, 22);
            this.distanceFilter.TabIndex = 4;
            this.distanceFilter.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "miles";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distanceFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageMax);
            this.Controls.Add(this.ageMin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchSettings";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ageMin;
        private System.Windows.Forms.NumericUpDown ageMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown distanceFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}