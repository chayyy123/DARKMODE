namespace TEST3
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
            btnChangeMode = new Button();
            lblmsg = new Label();
            SuspendLayout();
            // 
            // btnChangeMode
            // 
            btnChangeMode.AutoSize = true;
            btnChangeMode.FlatStyle = FlatStyle.Flat;
            btnChangeMode.Location = new Point(39, 34);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(75, 27);
            btnChangeMode.TabIndex = 0;
            btnChangeMode.Text = "button1";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // lblmsg
            // 
            lblmsg.AutoSize = true;
            lblmsg.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmsg.Location = new Point(336, 182);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new Size(146, 32);
            lblmsg.TabIndex = 1;
            lblmsg.Text = "This is a text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblmsg);
            Controls.Add(btnChangeMode);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeMode;
        private Label lblmsg;
    }
}
