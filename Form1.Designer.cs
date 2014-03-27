namespace RandomSelectionTool
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
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(260, 60);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add to Windows Explorer";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(12, 78);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(260, 60);
            this.button_Remove.TabIndex = 1;
            this.button_Remove.Text = "Remove (Uninstall)";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Name = "Form1";
            this.Text = "RandomSelectionTool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
    }
}

