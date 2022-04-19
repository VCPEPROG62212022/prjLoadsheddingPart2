
namespace prjLoadsheddingPart2
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
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cbmStage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redOutput = new System.Windows.Forms.RichTextBox();
            this.btnSelectArea = new System.Windows.Forms.Button();
            this.btnSelectStage = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(30, 26);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(196, 23);
            this.cmbArea.TabIndex = 0;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            this.cmbArea.SelectedValueChanged += new System.EventHandler(this.cmbArea_SelectedValueChanged);
            // 
            // cbmStage
            // 
            this.cbmStage.FormattingEnabled = true;
            this.cbmStage.Location = new System.Drawing.Point(271, 26);
            this.cbmStage.Name = "cbmStage";
            this.cbmStage.Size = new System.Drawing.Size(196, 23);
            this.cbmStage.TabIndex = 1;
            this.cbmStage.SelectedValueChanged += new System.EventHandler(this.cbmStage_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stage";
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(30, 96);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(437, 247);
            this.redOutput.TabIndex = 4;
            this.redOutput.Text = "";
            // 
            // btnSelectArea
            // 
            this.btnSelectArea.Location = new System.Drawing.Point(83, 55);
            this.btnSelectArea.Name = "btnSelectArea";
            this.btnSelectArea.Size = new System.Drawing.Size(75, 23);
            this.btnSelectArea.TabIndex = 5;
            this.btnSelectArea.Text = "Select area";
            this.btnSelectArea.UseVisualStyleBackColor = true;
            this.btnSelectArea.Click += new System.EventHandler(this.btnSelectArea_Click);
            // 
            // btnSelectStage
            // 
            this.btnSelectStage.Location = new System.Drawing.Point(334, 55);
            this.btnSelectStage.Name = "btnSelectStage";
            this.btnSelectStage.Size = new System.Drawing.Size(75, 23);
            this.btnSelectStage.TabIndex = 6;
            this.btnSelectStage.Text = "Select Stage";
            this.btnSelectStage.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(226, 350);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset all";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.redOutput);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cmbArea);
            this.panel1.Controls.Add(this.btnSelectStage);
            this.panel1.Controls.Add(this.cbmStage);
            this.panel1.Controls.Add(this.btnSelectArea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 406);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 419);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Loadshedding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cbmStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox redOutput;
        private System.Windows.Forms.Button btnSelectArea;
        private System.Windows.Forms.Button btnSelectStage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
    }
}

