﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using gui;
using tsconfig.domain;

namespace tsconfig
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DomainController.Instance();
            Application.Run(new SetupFrame());
        }
    }
}
