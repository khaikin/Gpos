namespace GPos
{
    partial class frmQuantity
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnminus10 = new System.Windows.Forms.Button();
            this.btnplus10 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Enabled = false;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(42, 77);
            this.txtCount.Margin = new System.Windows.Forms.Padding(5);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(69, 36);
            this.txtCount.TabIndex = 0;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Green;
            this.btnPlus.Location = new System.Drawing.Point(137, 50);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 43);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.Location = new System.Drawing.Point(137, 99);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 43);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-1";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(557, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 70);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "עדכן  ";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnminus10
            // 
            this.btnminus10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus10.ForeColor = System.Drawing.Color.Red;
            this.btnminus10.Location = new System.Drawing.Point(231, 99);
            this.btnminus10.Name = "btnminus10";
            this.btnminus10.Size = new System.Drawing.Size(75, 43);
            this.btnminus10.TabIndex = 5;
            this.btnminus10.Text = "-10";
            this.btnminus10.UseVisualStyleBackColor = true;
            this.btnminus10.Click += new System.EventHandler(this.btnminus10_Click);
            // 
            // btnplus10
            // 
            this.btnplus10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus10.ForeColor = System.Drawing.Color.Green;
            this.btnplus10.Location = new System.Drawing.Point(231, 50);
            this.btnplus10.Name = "btnplus10";
            this.btnplus10.Size = new System.Drawing.Size(75, 43);
            this.btnplus10.TabIndex = 4;
            this.btnplus10.Text = "+10";
            this.btnplus10.UseVisualStyleBackColor = true;
            this.btnplus10.Click += new System.EventHandler(this.btnplus10_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(302, 210);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 70);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "הסר פריט";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnminus10);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnplus10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(366, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "עדכון כמות";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnUpdatePrice);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 165);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "עדכון מחיר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "מחיר";
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrice.Location = new System.Drawing.Point(215, 100);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(111, 46);
            this.btnUpdatePrice.TabIndex = 10;
            this.btnUpdatePrice.Text = "שנה";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(80, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 36);
            this.txtPrice.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuantity";
            this.Text = "frmQuantity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnminus10;
        private System.Windows.Forms.Button btnplus10;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}