using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CallCentrum2
{
    public partial class PersonInfoControl : UserControl
    {
        private PersonInfo _personInfo;

        public PersonInfo PersonInfo
        {
            get { return _personInfo; }
            set
            {
                _personInfo = value;
                UpdateUi();
            }
        }

        public PersonInfoControl()
        {
            InitializeComponent();
        }

        private void UpdateUi()
        {
            if (PersonInfo == null)
            {
                _lblFullname.Text = "N/A";
                _lblTelephone.Text = "N/A";
                _txtSocial.Enabled = false;
                _txtSocial.Text = "";
                _datePickerCovid.Enabled = false;
                return;
            }

            _lblFullname.Text = PersonInfo.FullName;
            _lblTelephone.Text = PersonInfo.Telephone;
            _txtSocial.Enabled = true;
            _txtSocial.Text = PersonInfo.SocialSecurityNumber;
            _cbHadCovid.Checked = PersonInfo.HadCovid;
            UpdateHadCovid();
            UpdateVax(_datePickerVax,PersonInfo.FirstDose);
            UpdateVax(_datePickerVax2,PersonInfo.SecondDose);
            _comboVaxState.SelectedIndex = (int)PersonInfo.FirstDose.State;
            _comboVaxState2.SelectedIndex = (int)PersonInfo.SecondDose.State;
        }

        private void UpdateHadCovid()
        {
            _datePickerCovid.Enabled = PersonInfo.HadCovid;
        }

        private void UpdateVax(DateTimePicker picker, Vax vax)
        {
            picker.Value = vax.Time;
            switch (vax.State)
            {
                case EVaxState.Done:
                case EVaxState.None:
                    picker.Enabled = false;
                    break;
                case EVaxState.Registered:
                    picker.Enabled = true;
                    break;
            }
        }

        private void _txtSocial_TextChanged(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                PersonInfo.SocialSecurityNumber = _txtSocial.Text;
            }
        }

        private void _cbHadCovid_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                PersonInfo.HadCovid = _cbHadCovid.Checked;
                UpdateHadCovid();
            }
        }

        private void _comboVaxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                PersonInfo.FirstDose.State = (EVaxState) _comboVaxState.SelectedIndex;
                UpdateVax(_datePickerVax,PersonInfo.FirstDose);
            }
        }

        private void _comboVaxState2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                PersonInfo.SecondDose.State = (EVaxState)_comboVaxState2.SelectedIndex;
                UpdateVax(_datePickerVax2, PersonInfo.SecondDose);
            }
        }

        private void _datePickerVax_ValueChanged(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                PersonInfo.FirstDose.Time = _datePickerVax.Value;
            }
        }

        private void _datePickerVax2_ValueChanged(object sender, EventArgs e)
        {
            if (PersonInfo != null)
            {
                PersonInfo.SecondDose.Time = _datePickerVax2.Value;
            }
        }
    }
}
