﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_CSC_289_Capstone_Project
{
    public partial class SecretaryPanel : Form
    {
        int account_id;
        public SecretaryPanel(int id)
        {
            InitializeComponent();
            account_id = id;
        }
    }
}
