﻿using RamilPartyTime.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RamilPartyTime
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static RamilDiplomWorkEntities context = new RamilDiplomWorkEntities();
    }
}
