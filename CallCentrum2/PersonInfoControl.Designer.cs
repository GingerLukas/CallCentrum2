
namespace CallCentrum2
{
    partial class PersonInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.@__descFullname = new System.Windows.Forms.Label();
            this._lblFullname = new System.Windows.Forms.Label();
            this.@__descTelephone = new System.Windows.Forms.Label();
            this._lblTelephone = new System.Windows.Forms.Label();
            this.@__descSocial = new System.Windows.Forms.Label();
            this._txtSocial = new System.Windows.Forms.TextBox();
            this._cbHadCovid = new System.Windows.Forms.CheckBox();
            this._datePickerCovid = new System.Windows.Forms.DateTimePicker();
            this._groupVax = new System.Windows.Forms.GroupBox();
            this._datePickerVax = new System.Windows.Forms.DateTimePicker();
            this._comboVaxState = new System.Windows.Forms.ComboBox();
            this._groupVax2 = new System.Windows.Forms.GroupBox();
            this._datePickerVax2 = new System.Windows.Forms.DateTimePicker();
            this._comboVaxState2 = new System.Windows.Forms.ComboBox();
            this.@__descRegion = new System.Windows.Forms.Label();
            this._comboRegion = new System.Windows.Forms.ComboBox();
            this.@__descGender = new System.Windows.Forms.Label();
            this._lblGender = new System.Windows.Forms.Label();
            this.@__descBirthDate = new System.Windows.Forms.Label();
            this._lblBirthDate = new System.Windows.Forms.Label();
            this._groupVax.SuspendLayout();
            this._groupVax2.SuspendLayout();
            this.SuspendLayout();
            // 
            // __descFullname
            // 
            this.@__descFullname.AutoSize = true;
            this.@__descFullname.Location = new System.Drawing.Point(0, 0);
            this.@__descFullname.Name = "__descFullname";
            this.@__descFullname.Size = new System.Drawing.Size(45, 15);
            this.@__descFullname.TabIndex = 0;
            this.@__descFullname.Text = "Jméno:";
            // 
            // _lblFullname
            // 
            this._lblFullname.AutoSize = true;
            this._lblFullname.Location = new System.Drawing.Point(101, 0);
            this._lblFullname.Name = "_lblFullname";
            this._lblFullname.Size = new System.Drawing.Size(38, 15);
            this._lblFullname.TabIndex = 1;
            this._lblFullname.Text = "label1";
            // 
            // __descTelephone
            // 
            this.@__descTelephone.AutoSize = true;
            this.@__descTelephone.Location = new System.Drawing.Point(0, 18);
            this.@__descTelephone.Name = "__descTelephone";
            this.@__descTelephone.Size = new System.Drawing.Size(48, 15);
            this.@__descTelephone.TabIndex = 2;
            this.@__descTelephone.Text = "Telefon:";
            // 
            // _lblTelephone
            // 
            this._lblTelephone.AutoSize = true;
            this._lblTelephone.Location = new System.Drawing.Point(101, 18);
            this._lblTelephone.Name = "_lblTelephone";
            this._lblTelephone.Size = new System.Drawing.Size(38, 15);
            this._lblTelephone.TabIndex = 3;
            this._lblTelephone.Text = "label1";
            // 
            // __descSocial
            // 
            this.@__descSocial.AutoSize = true;
            this.@__descSocial.Location = new System.Drawing.Point(0, 39);
            this.@__descSocial.Name = "__descSocial";
            this.@__descSocial.Size = new System.Drawing.Size(71, 15);
            this.@__descSocial.TabIndex = 4;
            this.@__descSocial.Text = "Rodné číslo:";
            // 
            // _txtSocial
            // 
            this._txtSocial.Location = new System.Drawing.Point(101, 36);
            this._txtSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._txtSocial.Name = "_txtSocial";
            this._txtSocial.Size = new System.Drawing.Size(110, 23);
            this._txtSocial.TabIndex = 5;
            this._txtSocial.TextChanged += new System.EventHandler(this._txtSocial_TextChanged);
            // 
            // _cbHadCovid
            // 
            this._cbHadCovid.AutoSize = true;
            this._cbHadCovid.Location = new System.Drawing.Point(240, 38);
            this._cbHadCovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cbHadCovid.Name = "_cbHadCovid";
            this._cbHadCovid.Size = new System.Drawing.Size(124, 19);
            this._cbHadCovid.TabIndex = 6;
            this._cbHadCovid.Text = "Prodělal COVID-19";
            this._cbHadCovid.UseVisualStyleBackColor = true;
            this._cbHadCovid.CheckedChanged += new System.EventHandler(this._cbHadCovid_CheckedChanged);
            // 
            // _datePickerCovid
            // 
            this._datePickerCovid.Location = new System.Drawing.Point(239, 61);
            this._datePickerCovid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._datePickerCovid.Name = "_datePickerCovid";
            this._datePickerCovid.Size = new System.Drawing.Size(219, 23);
            this._datePickerCovid.TabIndex = 7;
            // 
            // _groupVax
            // 
            this._groupVax.Controls.Add(this._datePickerVax);
            this._groupVax.Controls.Add(this._comboVaxState);
            this._groupVax.Location = new System.Drawing.Point(0, 127);
            this._groupVax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._groupVax.Name = "_groupVax";
            this._groupVax.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._groupVax.Size = new System.Drawing.Size(234, 94);
            this._groupVax.TabIndex = 8;
            this._groupVax.TabStop = false;
            this._groupVax.Text = "První dávka";
            // 
            // _datePickerVax
            // 
            this._datePickerVax.Location = new System.Drawing.Point(6, 46);
            this._datePickerVax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._datePickerVax.Name = "_datePickerVax";
            this._datePickerVax.Size = new System.Drawing.Size(219, 23);
            this._datePickerVax.TabIndex = 1;
            this._datePickerVax.ValueChanged += new System.EventHandler(this._datePickerVax_ValueChanged);
            // 
            // _comboVaxState
            // 
            this._comboVaxState.FormattingEnabled = true;
            this._comboVaxState.Items.AddRange(new object[] {
            "Neobjednán",
            "Objednán",
            "Vakcinován"});
            this._comboVaxState.Location = new System.Drawing.Point(6, 20);
            this._comboVaxState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._comboVaxState.Name = "_comboVaxState";
            this._comboVaxState.Size = new System.Drawing.Size(133, 23);
            this._comboVaxState.TabIndex = 0;
            this._comboVaxState.SelectedIndexChanged += new System.EventHandler(this._comboVaxState_SelectedIndexChanged);
            // 
            // _groupVax2
            // 
            this._groupVax2.Controls.Add(this._datePickerVax2);
            this._groupVax2.Controls.Add(this._comboVaxState2);
            this._groupVax2.Location = new System.Drawing.Point(239, 127);
            this._groupVax2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._groupVax2.Name = "_groupVax2";
            this._groupVax2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._groupVax2.Size = new System.Drawing.Size(232, 94);
            this._groupVax2.TabIndex = 9;
            this._groupVax2.TabStop = false;
            this._groupVax2.Text = "Druhá dávka";
            // 
            // _datePickerVax2
            // 
            this._datePickerVax2.Location = new System.Drawing.Point(5, 45);
            this._datePickerVax2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._datePickerVax2.Name = "_datePickerVax2";
            this._datePickerVax2.Size = new System.Drawing.Size(219, 23);
            this._datePickerVax2.TabIndex = 2;
            this._datePickerVax2.ValueChanged += new System.EventHandler(this._datePickerVax2_ValueChanged);
            // 
            // _comboVaxState2
            // 
            this._comboVaxState2.FormattingEnabled = true;
            this._comboVaxState2.Items.AddRange(new object[] {
            "Neobjednán",
            "Objednán",
            "Vakcinován"});
            this._comboVaxState2.Location = new System.Drawing.Point(5, 20);
            this._comboVaxState2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._comboVaxState2.Name = "_comboVaxState2";
            this._comboVaxState2.Size = new System.Drawing.Size(133, 23);
            this._comboVaxState2.TabIndex = 2;
            this._comboVaxState2.SelectedIndexChanged += new System.EventHandler(this._comboVaxState2_SelectedIndexChanged);
            // 
            // __descRegion
            // 
            this.@__descRegion.AutoSize = true;
            this.@__descRegion.Location = new System.Drawing.Point(240, 3);
            this.@__descRegion.Name = "__descRegion";
            this.@__descRegion.Size = new System.Drawing.Size(30, 15);
            this.@__descRegion.TabIndex = 12;
            this.@__descRegion.Text = "Kraj:";
            // 
            // _comboRegion
            // 
            this._comboRegion.FormattingEnabled = true;
            this._comboRegion.Items.AddRange(new object[] {
            "",
            "Hlavní město Praha",
            "Jihočeský kraj",
            "Jihomoravský kraj",
            "Karlovarský kraj",
            "Kraj Vysočina",
            "Královéhradecký kraj",
            "Liberecký kraj",
            "Moravskoslezský kraj",
            "Olomoucký kraj",
            "Pardubický kraj",
            "Plzeňský kraj",
            "Středočeský kraj",
            "Ústecký kraj",
            "Zlínský kraj"});
            this._comboRegion.Location = new System.Drawing.Point(276, 0);
            this._comboRegion.Name = "_comboRegion";
            this._comboRegion.Size = new System.Drawing.Size(187, 23);
            this._comboRegion.TabIndex = 13;
            this._comboRegion.SelectedIndexChanged += new System.EventHandler(this._comboRegion_SelectedIndexChanged);
            // 
            // __descGender
            // 
            this.@__descGender.AutoSize = true;
            this.@__descGender.Location = new System.Drawing.Point(0, 61);
            this.@__descGender.Name = "__descGender";
            this.@__descGender.Size = new System.Drawing.Size(49, 15);
            this.@__descGender.TabIndex = 14;
            this.@__descGender.Text = "Pohlaví:";
            // 
            // _lblGender
            // 
            this._lblGender.AutoSize = true;
            this._lblGender.Location = new System.Drawing.Point(101, 61);
            this._lblGender.Name = "_lblGender";
            this._lblGender.Size = new System.Drawing.Size(38, 15);
            this._lblGender.TabIndex = 15;
            this._lblGender.Text = "label1";
            // 
            // __descBirthDate
            // 
            this.@__descBirthDate.AutoSize = true;
            this.@__descBirthDate.Location = new System.Drawing.Point(0, 80);
            this.@__descBirthDate.Name = "__descBirthDate";
            this.@__descBirthDate.Size = new System.Drawing.Size(94, 15);
            this.@__descBirthDate.TabIndex = 16;
            this.@__descBirthDate.Text = "Datum narození:";
            // 
            // _lblBirthDate
            // 
            this._lblBirthDate.AutoSize = true;
            this._lblBirthDate.Location = new System.Drawing.Point(101, 80);
            this._lblBirthDate.Name = "_lblBirthDate";
            this._lblBirthDate.Size = new System.Drawing.Size(38, 15);
            this._lblBirthDate.TabIndex = 17;
            this._lblBirthDate.Text = "label1";
            // 
            // PersonInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblBirthDate);
            this.Controls.Add(this.@__descBirthDate);
            this.Controls.Add(this._lblGender);
            this.Controls.Add(this.@__descGender);
            this.Controls.Add(this._comboRegion);
            this.Controls.Add(this.@__descRegion);
            this.Controls.Add(this._groupVax2);
            this.Controls.Add(this._groupVax);
            this.Controls.Add(this._datePickerCovid);
            this.Controls.Add(this._cbHadCovid);
            this.Controls.Add(this._txtSocial);
            this.Controls.Add(this.@__descSocial);
            this.Controls.Add(this._lblTelephone);
            this.Controls.Add(this.@__descTelephone);
            this.Controls.Add(this._lblFullname);
            this.Controls.Add(this.@__descFullname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PersonInfoControl";
            this.Size = new System.Drawing.Size(477, 240);
            this._groupVax.ResumeLayout(false);
            this._groupVax2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label __descFullname;
        private System.Windows.Forms.Label _lblFullname;
        private System.Windows.Forms.Label __descTelephone;
        private System.Windows.Forms.Label _lblTelephone;
        private System.Windows.Forms.Label __desc;
        private System.Windows.Forms.Label __descSocial;
        private System.Windows.Forms.TextBox _txtSocial;
        private System.Windows.Forms.CheckBox _cbHadCovid;
        private System.Windows.Forms.DateTimePicker _datePickerCovid;
        private System.Windows.Forms.GroupBox _groupVax;
        private System.Windows.Forms.ComboBox _comboVaxState;
        private System.Windows.Forms.GroupBox _groupVax2;
        private System.Windows.Forms.DateTimePicker _datePickerVax;
        private System.Windows.Forms.DateTimePicker _datePickerVax2;
        private System.Windows.Forms.ComboBox _comboVaxState2;
        private System.Windows.Forms.Label __descRegion;
        private System.Windows.Forms.ComboBox _comboRegion;
        private System.Windows.Forms.Label __descGender;
        private System.Windows.Forms.Label _lblGender;
        private System.Windows.Forms.Label __descBirthDate;
        private System.Windows.Forms.Label _lblBirthDate;
    }
}
