namespace catchTheCar
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            redCar = new Label();
            yellowCar = new Label();
            finishLabel = new Label();
            baslatButton = new Button();
            tmr = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(49, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1069, 32);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(49, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1081, 32);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(49, 431);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1069, 32);
            label3.TabIndex = 2;
            // 
            // redCar
            // 
            redCar.BackColor = Color.Red;
            redCar.Location = new Point(49, 100);
            redCar.Margin = new Padding(4, 0, 4, 0);
            redCar.Name = "redCar";
            redCar.Size = new Size(90, 88);
            redCar.TabIndex = 3;
            // 
            // yellowCar
            // 
            yellowCar.BackColor = Color.Yellow;
            yellowCar.Location = new Point(49, 311);
            yellowCar.Margin = new Padding(4, 0, 4, 0);
            yellowCar.Name = "yellowCar";
            yellowCar.Size = new Size(90, 88);
            yellowCar.TabIndex = 4;
            // 
            // finishLabel
            // 
            finishLabel.BackColor = SystemColors.ControlDarkDark;
            finishLabel.Location = new Point(1116, 36);
            finishLabel.Margin = new Padding(4, 0, 4, 0);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(26, 427);
            finishLabel.TabIndex = 5;
            // 
            // baslatButton
            // 
            baslatButton.Location = new Point(929, 525);
            baslatButton.Name = "baslatButton";
            baslatButton.Size = new Size(174, 45);
            baslatButton.TabIndex = 6;
            baslatButton.Text = "Başlat";
            baslatButton.UseVisualStyleBackColor = true;
            baslatButton.Click += baslatButton_Click;
            // 
            // tmr
            // 
            tmr.Enabled = true;
            tmr.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 630);
            Controls.Add(baslatButton);
            Controls.Add(finishLabel);
            Controls.Add(yellowCar);
            Controls.Add(redCar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label redCar;
        private Label yellowCar;
        private Label finishLabel;
        private Button baslatButton;
        private System.Windows.Forms.Timer tmr;
    }
}