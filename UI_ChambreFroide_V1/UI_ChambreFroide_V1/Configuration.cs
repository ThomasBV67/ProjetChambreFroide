﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Ce form sert à la configuration du port série pour la communication avec le module LoRa
    /// </summary>
    public partial class Configuration : Form
    {
        public string m_nom { get; set; }
        public int m_vitesse { get; set; }
        public int m_nbBit { get; set; }
        public Parity m_parite { get; set; }
        public StopBits m_stopBit { get; set; }

        /// <summary>
        /// Constructeur du form de configuration. Les valeurs actuelles du port séries sont appliquées aux variables membres équivalentes.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="baud"></param>
        /// <param name="dataBits"></param>
        /// <param name="parite"></param>
        /// <param name="stpBit"></param>
        public Configuration(String nom, int baud, int dataBits, Parity parite, StopBits stpBit)
        {
            InitializeComponent();

            cb_port.DataSource = SerialPort.GetPortNames();
            cb_vitesse.DataSource = new int[] { 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 256000 };
            cb_nbBits.DataSource = new int[] { 6, 7, 8 };
            cb_par.DataSource = Enum.GetNames(typeof(Parity));
            cb_stop.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            cb_stop.Items.RemoveAt(0);//enleve le none
            cb_stop.Items.RemoveAt(2);//enleve le 1.5
            cb_stop.SelectedIndex = 0;

            cb_port.Text = nom;
            cb_vitesse.Text = Convert.ToString(baud);
            cb_nbBits.Text = Convert.ToString(dataBits);
            cb_par.Text = Convert.ToString(parite);
            cb_stop.Text = Convert.ToString(stpBit);
        }
        
        /// <summary>
        /// Cette fonction met à jour les ports séries disponibles dans le comboBox si ceux présents
        /// dans le comboBox ne sont pas les mêmes que ceux détectés par le système.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MAJPorts(object sender, EventArgs e)
        {
            int index = cb_port.SelectedIndex;
            
            if (cb_port.DataSource != SerialPort.GetPortNames())
            {
                cb_port.DataSource = SerialPort.GetPortNames();
                try
                {
                    cb_port.SelectedIndex = index;
                }
                catch
                {
                    cb_port.Text = "";
                }
            }
        }
        
        /// <summary>
        /// Lorsque le bouton OK est appuyé, les valeurs affichées dans les comboBox sont appliquées aux 
        /// variables membres. Celles-ci sont utilisées par le port série dans les autres forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_appliquer_Click(object sender, EventArgs e)
        {
            m_nom = cb_port.Text;
            m_vitesse = Convert.ToInt32(cb_vitesse.Text);
            m_nbBit = Convert.ToInt32(cb_nbBits.Text);
            m_parite = (Parity)cb_par.SelectedIndex;
            m_stopBit = (StopBits)(cb_stop.SelectedIndex + 1);

        }
    }
}
