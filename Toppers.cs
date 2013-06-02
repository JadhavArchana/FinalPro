﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Collections.ObjectModel;


namespace FinalPro2
{
    [XmlRoot("topsay")]
    public class Toppers
    {
        [XmlArray("topsay")]
        [XmlArrayItem("topper")]
        public ObservableCollection<Topper> Collection { get; set; }
    }
   
}
