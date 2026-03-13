namespace Lab4
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
            numUpDown = new NumericUpDown();
            txtA = new TextBox();
            txtB = new TextBox();
            btn1 = new Button();
            lstArray = new ListBox();
            dgv1 = new DataGridView();
            btn2 = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // numUpDown
            // 
            numUpDown.Location = new Point(121, 38);
            numUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDown.Name = "numUpDown";
            numUpDown.Size = new Size(120, 23);
            numUpDown.TabIndex = 0;
            numUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtA
            // 
            txtA.Location = new Point(141, 88);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(141, 117);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 117);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 23);
            btn1.TabIndex = 3;
            btn1.Text = "Розрахувати";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lstArray
            // 
            lstArray.FormattingEnabled = true;
            lstArray.Location = new Point(12, 161);
            lstArray.Name = "lstArray";
            lstArray.Size = new Size(229, 184);
            lstArray.TabIndex = 4;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(466, 42);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(270, 178);
            dgv1.TabIndex = 5;
            // 
            // btn2
            // 
            btn2.Location = new Point(570, 258);
            btn2.Name = "btn2";
            btn2.Size = new Size(87, 23);
            btn2.TabIndex = 6;
            btn2.Text = "Згенерувати";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 42);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(103, 15);
            lbl1.TabIndex = 7;
            lbl1.Text = "Довжина масиву:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 88);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(114, 15);
            lbl2.TabIndex = 8;
            lbl2.Text = "Діапазон від А до B:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(81, 9);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(70, 15);
            lbl3.TabIndex = 9;
            lbl3.Text = "Завдання 1:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(570, 9);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(70, 15);
            lbl4.TabIndex = 10;
            lbl4.Text = "Завдання 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btn2);
            Controls.Add(dgv1);
            Controls.Add(lstArray);
            Controls.Add(btn1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(numUpDown);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numUpDown;
        private TextBox txtA;
        private TextBox txtB;
        private Button btn1;
        private ListBox lstArray;
        private DataGridView dgv1;
        private Button btn2;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
    }
}
