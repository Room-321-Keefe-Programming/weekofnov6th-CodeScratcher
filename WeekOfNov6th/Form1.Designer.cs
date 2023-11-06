namespace WeekOfNov6th
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
            this.lblTemperatureConverter = new System.Windows.Forms.Label();
            this.lblMoneyConvert = new System.Windows.Forms.Label();
            this.rdoTempConverter1 = new System.Windows.Forms.RadioButton();
            this.rdoTempConverter2 = new System.Windows.Forms.RadioButton();
            this.grpTempConverter = new System.Windows.Forms.GroupBox();
            this.cmbMoneyConverter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblDistanceConverter = new System.Windows.Forms.Label();
            this.chkMeterToInch = new System.Windows.Forms.CheckBox();
            this.chkMileToKilo = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chkInchToMeter = new System.Windows.Forms.CheckBox();
            this.chkKiloToMiles = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatureConverter
            // 
            this.lblTemperatureConverter.AutoSize = true;
            this.lblTemperatureConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureConverter.Location = new System.Drawing.Point(42, 68);
            this.lblTemperatureConverter.Name = "lblTemperatureConverter";
            this.lblTemperatureConverter.Size = new System.Drawing.Size(236, 26);
            this.lblTemperatureConverter.TabIndex = 0;
            this.lblTemperatureConverter.Text = "Temperature Converter";
            // 
            // lblMoneyConvert
            // 
            this.lblMoneyConvert.AutoSize = true;
            this.lblMoneyConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyConvert.Location = new System.Drawing.Point(42, 142);
            this.lblMoneyConvert.Name = "lblMoneyConvert";
            this.lblMoneyConvert.Size = new System.Drawing.Size(178, 26);
            this.lblMoneyConvert.TabIndex = 1;
            this.lblMoneyConvert.Text = "Money Converter";
            // 
            // rdoTempConverter1
            // 
            this.rdoTempConverter1.AutoSize = true;
            this.rdoTempConverter1.Location = new System.Drawing.Point(18, 31);
            this.rdoTempConverter1.Name = "rdoTempConverter1";
            this.rdoTempConverter1.Size = new System.Drawing.Size(196, 28);
            this.rdoTempConverter1.TabIndex = 2;
            this.rdoTempConverter1.TabStop = true;
            this.rdoTempConverter1.Text = "Celsuis - Fahrenheit";
            this.rdoTempConverter1.UseVisualStyleBackColor = true;
            // 
            // rdoTempConverter2
            // 
            this.rdoTempConverter2.AutoSize = true;
            this.rdoTempConverter2.Location = new System.Drawing.Point(234, 31);
            this.rdoTempConverter2.Name = "rdoTempConverter2";
            this.rdoTempConverter2.Size = new System.Drawing.Size(196, 28);
            this.rdoTempConverter2.TabIndex = 3;
            this.rdoTempConverter2.TabStop = true;
            this.rdoTempConverter2.Text = "Fahrenheit - Celsius";
            this.rdoTempConverter2.UseVisualStyleBackColor = true;
            // 
            // grpTempConverter
            // 
            this.grpTempConverter.Controls.Add(this.rdoTempConverter1);
            this.grpTempConverter.Controls.Add(this.rdoTempConverter2);
            this.grpTempConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempConverter.Location = new System.Drawing.Point(321, 38);
            this.grpTempConverter.Name = "grpTempConverter";
            this.grpTempConverter.Size = new System.Drawing.Size(458, 77);
            this.grpTempConverter.TabIndex = 4;
            this.grpTempConverter.TabStop = false;
            this.grpTempConverter.Tag = "";
            this.grpTempConverter.Text = "Convert";
            // 
            // cmbMoneyConverter
            // 
            this.cmbMoneyConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneyConverter.FormattingEnabled = true;
            this.cmbMoneyConverter.Location = new System.Drawing.Point(321, 142);
            this.cmbMoneyConverter.Name = "cmbMoneyConverter";
            this.cmbMoneyConverter.Size = new System.Drawing.Size(121, 32);
            this.cmbMoneyConverter.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(846, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(47, 478);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(964, 148);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(846, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(321, 411);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(169, 29);
            this.txtInput2.TabIndex = 9;
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(47, 411);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(173, 29);
            this.txtInput1.TabIndex = 10;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.Location = new System.Drawing.Point(43, 372);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(61, 24);
            this.lblInput1.TabIndex = 11;
            this.lblInput1.Text = "Input1";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput2.Location = new System.Drawing.Point(317, 372);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(61, 24);
            this.lblInput2.TabIndex = 12;
            this.lblInput2.Text = "Input2";
            // 
            // lblDistanceConverter
            // 
            this.lblDistanceConverter.AutoSize = true;
            this.lblDistanceConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceConverter.Location = new System.Drawing.Point(42, 243);
            this.lblDistanceConverter.Name = "lblDistanceConverter";
            this.lblDistanceConverter.Size = new System.Drawing.Size(196, 25);
            this.lblDistanceConverter.TabIndex = 13;
            this.lblDistanceConverter.Tag = "";
            this.lblDistanceConverter.Text = "Distance Converter";
            // 
            // chkMeterToInch
            // 
            this.chkMeterToInch.AutoSize = true;
            this.chkMeterToInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeterToInch.Location = new System.Drawing.Point(569, 240);
            this.chkMeterToInch.Name = "chkMeterToInch";
            this.chkMeterToInch.Size = new System.Drawing.Size(167, 28);
            this.chkMeterToInch.TabIndex = 14;
            this.chkMeterToInch.Text = "Meters to Inches";
            this.chkMeterToInch.UseVisualStyleBackColor = true;
            // 
            // chkMileToKilo
            // 
            this.chkMileToKilo.AutoSize = true;
            this.chkMileToKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMileToKilo.Location = new System.Drawing.Point(321, 240);
            this.chkMileToKilo.Name = "chkMileToKilo";
            this.chkMileToKilo.Size = new System.Drawing.Size(186, 28);
            this.chkMileToKilo.TabIndex = 15;
            this.chkMileToKilo.Tag = "";
            this.chkMileToKilo.Text = "Miles to Kilometers";
            this.chkMileToKilo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(846, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkInchToMeter
            // 
            this.chkInchToMeter.AutoSize = true;
            this.chkInchToMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInchToMeter.Location = new System.Drawing.Point(569, 290);
            this.chkInchToMeter.Name = "chkInchToMeter";
            this.chkInchToMeter.Size = new System.Drawing.Size(167, 28);
            this.chkInchToMeter.TabIndex = 17;
            this.chkInchToMeter.Text = "Inches to Meters";
            this.chkInchToMeter.UseVisualStyleBackColor = true;
            // 
            // chkKiloToMiles
            // 
            this.chkKiloToMiles.AutoSize = true;
            this.chkKiloToMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKiloToMiles.Location = new System.Drawing.Point(321, 290);
            this.chkKiloToMiles.Name = "chkKiloToMiles";
            this.chkKiloToMiles.Size = new System.Drawing.Size(186, 28);
            this.chkKiloToMiles.TabIndex = 18;
            this.chkKiloToMiles.Text = "Kilometers to Miles";
            this.chkKiloToMiles.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(846, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 648);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chkKiloToMiles);
            this.Controls.Add(this.chkInchToMeter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkMileToKilo);
            this.Controls.Add(this.chkMeterToInch);
            this.Controls.Add(this.lblDistanceConverter);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMoneyConverter);
            this.Controls.Add(this.grpTempConverter);
            this.Controls.Add(this.lblMoneyConvert);
            this.Controls.Add(this.lblTemperatureConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTempConverter.ResumeLayout(false);
            this.grpTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatureConverter;
        private System.Windows.Forms.Label lblMoneyConvert;
        private System.Windows.Forms.RadioButton rdoTempConverter1;
        private System.Windows.Forms.RadioButton rdoTempConverter2;
        private System.Windows.Forms.GroupBox grpTempConverter;
        private System.Windows.Forms.ComboBox cmbMoneyConverter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblDistanceConverter;
        private System.Windows.Forms.CheckBox chkMeterToInch;
        private System.Windows.Forms.CheckBox chkMileToKilo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkInchToMeter;
        private System.Windows.Forms.CheckBox chkKiloToMiles;
        private System.Windows.Forms.Button button4;
    }
}

