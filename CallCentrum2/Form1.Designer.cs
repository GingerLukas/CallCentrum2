
namespace CallCentrum2
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
            this.personInfoControl1 = new CallCentrum2.PersonInfoControl();
            this._groupPerson = new System.Windows.Forms.GroupBox();
            this._btnCall = new System.Windows.Forms.Button();
            this._btnNextPerson = new System.Windows.Forms.Button();
            this._fileDialog = new System.Windows.Forms.OpenFileDialog();
            this._btnLoadCsv = new System.Windows.Forms.Button();
            this._lblQueueCount = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._lblDoneCount = new System.Windows.Forms.Label();
            this._groupPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfoControl1
            // 
            this.personInfoControl1.Location = new System.Drawing.Point(5, 20);
            this.personInfoControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personInfoControl1.Name = "personInfoControl1";
            this.personInfoControl1.PersonInfo = null;
            this.personInfoControl1.Size = new System.Drawing.Size(472, 270);
            this.personInfoControl1.TabIndex = 0;
            // 
            // _groupPerson
            // 
            this._groupPerson.Controls.Add(this._btnCall);
            this._groupPerson.Controls.Add(this.personInfoControl1);
            this._groupPerson.Location = new System.Drawing.Point(10, 9);
            this._groupPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._groupPerson.Name = "_groupPerson";
            this._groupPerson.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._groupPerson.Size = new System.Drawing.Size(482, 320);
            this._groupPerson.TabIndex = 1;
            this._groupPerson.TabStop = false;
            this._groupPerson.Text = "Pacient";
            // 
            // _btnCall
            // 
            this._btnCall.Location = new System.Drawing.Point(2, 294);
            this._btnCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnCall.Name = "_btnCall";
            this._btnCall.Size = new System.Drawing.Size(82, 22);
            this._btnCall.TabIndex = 2;
            this._btnCall.Text = "Zavolat";
            this._btnCall.UseVisualStyleBackColor = true;
            this._btnCall.Click += new System.EventHandler(this._btnCall_Click);
            // 
            // _btnNextPerson
            // 
            this._btnNextPerson.Location = new System.Drawing.Point(607, 205);
            this._btnNextPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnNextPerson.Name = "_btnNextPerson";
            this._btnNextPerson.Size = new System.Drawing.Size(82, 22);
            this._btnNextPerson.TabIndex = 1;
            this._btnNextPerson.Text = "Další";
            this._btnNextPerson.UseVisualStyleBackColor = true;
            this._btnNextPerson.Click += new System.EventHandler(this._btnNextPerson_Click);
            // 
            // _fileDialog
            // 
            this._fileDialog.Filter = "CSV (*.csv)|";
            // 
            // _btnLoadCsv
            // 
            this._btnLoadCsv.Location = new System.Drawing.Point(607, 307);
            this._btnLoadCsv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnLoadCsv.Name = "_btnLoadCsv";
            this._btnLoadCsv.Size = new System.Drawing.Size(82, 22);
            this._btnLoadCsv.TabIndex = 2;
            this._btnLoadCsv.Text = "Načíst";
            this._btnLoadCsv.UseVisualStyleBackColor = true;
            this._btnLoadCsv.Click += new System.EventHandler(this._btnLoadCsv_Click);
            // 
            // _lblQueueCount
            // 
            this._lblQueueCount.AutoSize = true;
            this._lblQueueCount.Location = new System.Drawing.Point(607, 284);
            this._lblQueueCount.Name = "_lblQueueCount";
            this._lblQueueCount.Size = new System.Drawing.Size(38, 15);
            this._lblQueueCount.TabIndex = 3;
            this._lblQueueCount.Text = "label1";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(520, 307);
            this._btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(82, 22);
            this._btnSave.TabIndex = 4;
            this._btnSave.Text = "Uložit";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _lblDoneCount
            // 
            this._lblDoneCount.AutoSize = true;
            this._lblDoneCount.Location = new System.Drawing.Point(520, 284);
            this._lblDoneCount.Name = "_lblDoneCount";
            this._lblDoneCount.Size = new System.Drawing.Size(38, 15);
            this._lblDoneCount.TabIndex = 5;
            this._lblDoneCount.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this._lblDoneCount);
            this.Controls.Add(this._btnNextPerson);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._lblQueueCount);
            this.Controls.Add(this._btnLoadCsv);
            this.Controls.Add(this._groupPerson);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this._groupPerson.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonInfoControl personInfoControl1;
        private System.Windows.Forms.GroupBox _groupPerson;
        private System.Windows.Forms.Button _btnCall;
        private System.Windows.Forms.Button _btnNextPerson;
        private System.Windows.Forms.OpenFileDialog _fileDialog;
        private System.Windows.Forms.Button _btnLoadCsv;
        private System.Windows.Forms.Label _lblQueueCount;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label _lblDoneCount;
    }
}

