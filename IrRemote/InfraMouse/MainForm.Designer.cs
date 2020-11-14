namespace InfraMouse
{
    partial class MainForm
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
            this.ComPortsList = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portOutput = new System.Windows.Forms.ListBox();
            this.actions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortsList
            // 
            this.ComPortsList.FormattingEnabled = true;
            this.ComPortsList.Location = new System.Drawing.Point(31, 28);
            this.ComPortsList.Name = "ComPortsList";
            this.ComPortsList.Size = new System.Drawing.Size(121, 21);
            this.ComPortsList.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(173, 26);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portOutput
            // 
            this.portOutput.FormattingEnabled = true;
            this.portOutput.Location = new System.Drawing.Point(31, 55);
            this.portOutput.Name = "portOutput";
            this.portOutput.Size = new System.Drawing.Size(217, 173);
            this.portOutput.TabIndex = 2;
            this.portOutput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.portOutput_MouseDoubleClick);
            // 
            // actions
            // 
            this.actions.Controls.Add(this.tabPage1);
            this.actions.Controls.Add(this.tabPage2);
            this.actions.Location = new System.Drawing.Point(272, 26);
            this.actions.Name = "actions";
            this.actions.SelectedIndex = 0;
            this.actions.Size = new System.Drawing.Size(454, 213);
            this.actions.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(446, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.portOutput);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ComPortsList);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComPortsList;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox portOutput;
        private System.Windows.Forms.TabControl actions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

