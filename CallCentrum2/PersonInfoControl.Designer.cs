
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
            this._groupVax2 = new System.Windows.Forms.GroupBox();
            this._comboVaxState = new System.Windows.Forms.ComboBox();
            this._datePickerVax = new System.Windows.Forms.DateTimePicker();
            this._comboVaxState2 = new System.Windows.Forms.ComboBox();
            this._datePickerVax2 = new System.Windows.Forms.DateTimePicker();
            this._groupVax.SuspendLayout();
            this._groupVax2.SuspendLayout();
            this.SuspendLayout();
            // 
            // __descFullname
            // 
            this.@__descFullname.AutoSize = true;
            this.@__descFullname.Location = new System.Drawing.Point(0, 0);
            this.@__descFullname.Name = "__descFullname";
            this.@__descFullname.Size = new System.Drawing.Size(55, 20);
            this.@__descFullname.TabIndex = 0;
            this.@__descFullname.Text = "Jméno:";
            // 
            // _lblFullname
            // 
            this._lblFullname.AutoSize = true;
            this._lblFullname.Location = new System.Drawing.Point(62, 0);
            this._lblFullname.Name = "_lblFullname";
            this._lblFullname.Size = new System.Drawing.Size(50, 20);
            this._lblFullname.TabIndex = 1;
            this._lblFullname.Text = "label1";
            // 
            // __descTelephone
            // 
            this.@__descTelephone.AutoSize = true;
            this.@__descTelephone.Location = new System.Drawing.Point(0, 24);
            this.@__descTelephone.Name = "__descTelephone";
            this.@__descTelephone.Size = new System.Drawing.Size(61, 20);
            this.@__descTelephone.TabIndex = 2;
            this.@__descTelephone.Text = "Telefon:";
            // 
            // _lblTelephone
            // 
            this._lblTelephone.AutoSize = true;
            this._lblTelephone.Location = new System.Drawing.Point(67, 24);
            this._lblTelephone.Name = "_lblTelephone";
            this._lblTelephone.Size = new System.Drawing.Size(50, 20);
            this._lblTelephone.TabIndex = 3;
            this._lblTelephone.Text = "label1";
            // 
            // __descSocial
            // 
            this.@__descSocial.AutoSize = true;
            this.@__descSocial.Location = new System.Drawing.Point(0, 48);
            this.@__descSocial.Name = "__descSocial";
            this.@__descSocial.Size = new System.Drawing.Size(89, 20);
            this.@__descSocial.TabIndex = 4;
            this.@__descSocial.Text = "Rodné číslo:";
            // 
            // _txtSocial
            // 
            this._txtSocial.Location = new System.Drawing.Point(95, 48);
            this._txtSocial.Name = "_txtSocial";
            this._txtSocial.Size = new System.Drawing.Size(125, 27);
            this._txtSocial.TabIndex = 5;
            this._txtSocial.TextChanged += new System.EventHandler(this._txtSocial_TextChanged);
            // 
            // _cbHadCovid
            // 
            this._cbHadCovid.AutoSize = true;
            this._cbHadCovid.Location = new System.Drawing.Point(0, 81);
            this._cbHadCovid.Name = "_cbHadCovid";
            this._cbHadCovid.Size = new System.Drawing.Size(156, 24);
            this._cbHadCovid.TabIndex = 6;
            this._cbHadCovid.Text = "Prodělal COVID-19";
            this._cbHadCovid.UseVisualStyleBackColor = true;
            this._cbHadCovid.CheckedChanged += new System.EventHandler(this._cbHadCovid_CheckedChanged);
            // 
            // _datePickerCovid
            // 
            this._datePickerCovid.Location = new System.Drawing.Point(162, 81);
            this._datePickerCovid.Name = "_datePickerCovid";
            this._datePickerCovid.Size = new System.Drawing.Size(250, 27);
            this._datePickerCovid.TabIndex = 7;
            // 
            // _groupVax
            // 
            this._groupVax.Controls.Add(this._datePickerVax);
            this._groupVax.Controls.Add(this._comboVaxState);
            this._groupVax.Location = new System.Drawing.Point(0, 111);
            this._groupVax.Name = "_groupVax";
            this._groupVax.Size = new System.Drawing.Size(267, 125);
            this._groupVax.TabIndex = 8;
            this._groupVax.TabStop = false;
            this._groupVax.Text = "První dávka";
            // 
            // _groupVax2
            // 
            this._groupVax2.Controls.Add(this._datePickerVax2);
            this._groupVax2.Controls.Add(this._comboVaxState2);
            this._groupVax2.Location = new System.Drawing.Point(273, 114);
            this._groupVax2.Name = "_groupVax2";
            this._groupVax2.Size = new System.Drawing.Size(265, 125);
            this._groupVax2.TabIndex = 9;
            this._groupVax2.TabStop = false;
            this._groupVax2.Text = "Druhá dávka";
            // 
            // _comboVaxState
            // 
            this._comboVaxState.FormattingEnabled = true;
            this._comboVaxState.Items.AddRange(new object[] {
            "Neobjednán",
            "Objednán",
            "Vakcinován"});
            this._comboVaxState.Location = new System.Drawing.Point(7, 27);
            this._comboVaxState.Name = "_comboVaxState";
            this._comboVaxState.Size = new System.Drawing.Size(151, 28);
            this._comboVaxState.TabIndex = 0;
            this._comboVaxState.SelectedIndexChanged += new System.EventHandler(this._comboVaxState_SelectedIndexChanged);
            // 
            // _datePickerVax
            // 
            this._datePickerVax.Location = new System.Drawing.Point(7, 62);
            this._datePickerVax.Name = "_datePickerVax";
            this._datePickerVax.Size = new System.Drawing.Size(250, 27);
            this._datePickerVax.TabIndex = 1;
            this._datePickerVax.ValueChanged += new System.EventHandler(this._datePickerVax_ValueChanged);
            // 
            // _comboVaxState2
            // 
            this._comboVaxState2.FormattingEnabled = true;
            this._comboVaxState2.Items.AddRange(new object[] {
            "Neobjednán",
            "Objednán",
            "Vakcinován"});
            this._comboVaxState2.Location = new System.Drawing.Point(6, 26);
            this._comboVaxState2.Name = "_comboVaxState2";
            this._comboVaxState2.Size = new System.Drawing.Size(151, 28);
            this._comboVaxState2.TabIndex = 2;
            this._comboVaxState2.SelectedIndexChanged += new System.EventHandler(this._comboVaxState2_SelectedIndexChanged);
            // 
            // _datePickerVax2
            // 
            this._datePickerVax2.Location = new System.Drawing.Point(6, 60);
            this._datePickerVax2.Name = "_datePickerVax2";
            this._datePickerVax2.Size = new System.Drawing.Size(250, 27);
            this._datePickerVax2.TabIndex = 2;
            this._datePickerVax2.ValueChanged += new System.EventHandler(this._datePickerVax2_ValueChanged);
            // 
            // PersonInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "PersonInfoControl";
            this.Size = new System.Drawing.Size(616, 319);
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
    }
}
