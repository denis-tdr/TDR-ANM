﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TALibrary
{
    public partial class mainControl : UserControl
    {
        public mainControl()
        {
            InitializeComponent();
        }
        public virtual void TShow()
        {
            this.Visible = true;
        }
        public virtual void THide()
        {
            this.Visible = false;
        }
        
    }
}
