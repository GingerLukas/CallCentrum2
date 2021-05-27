using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Přístě prosím trošku zabavnější zadání, covidu mám dost, dík xdd

namespace CallCentrum2
{
    public partial class Form1 : Form
    {
        private string _fileName = null;
        private Queue<PersonInfo> _queue = new Queue<PersonInfo>();
        private List<PersonInfo> _done = new List<PersonInfo>();
        public Form1()
        {
            InitializeComponent();

            UpdateUi();
        }

        private void UpdateUi()
        {
            _lblQueueCount.Text = _queue.Count.ToString();
            _lblDoneCount.Text = _done.Count.ToString();
            _groupPerson.Enabled = personInfoControl1.PersonInfo != null;
        }

        private PersonInfo TryGetNext()
        {
            if (_queue == null || _queue.Count == 0)
            {
                return null;
            }

            return _queue.Dequeue();
        }

        private void _btnLoadCsv_Click(object sender, EventArgs e)
        {
            if (_fileDialog.ShowDialog() == DialogResult.OK)
            {
                _queue = new Queue<PersonInfo>(CsvParser.Parse(File.ReadAllLines(_fileName=_fileDialog.FileName), strings =>
                {
                    if (strings.Length != 3)
                    {
                        return null;
                    }
                    return new PersonInfo() {Name = strings[0], Surname = strings[1], Telephone = strings[2]};
                }, info => info.Surname));
            }

            UpdateUi();
        }

        private void _btnNextPerson_Click(object sender, EventArgs e)
        {
            personInfoControl1.PersonInfo = TryGetNext();
            UpdateUi();
        }

        private void _btnCall_Click(object sender, EventArgs e)
        {
            PersonInfo info = personInfoControl1.PersonInfo;
            if(info == null) return;

            var result = MessageBox.Show("Dovolal/a jste se?", info.Telephone, MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    _done.Add(info);
                    break;
                case DialogResult.No:
                    info.Counter++;
                    if (info.Counter<2)
                    {
                        _queue.Enqueue(info);
                    }

                    personInfoControl1.PersonInfo = TryGetNext();
                    break;
                case DialogResult.Cancel:

                    break;
            }

            UpdateUi();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_fileName != null)
            {
                File.WriteAllLines(_fileName, _queue.Select(x => $"{x.Name},{x.Surname},{x.Telephone}"), Encoding.UTF8);
            }
            File.AppendAllLines("output.csv", _done.Select(x => x.ToString(',')),Encoding.UTF8);
        }
    }
}
