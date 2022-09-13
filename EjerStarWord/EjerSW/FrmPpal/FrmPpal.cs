using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesStarWars;
using System.Media; 

namespace FrmPpal
{
    public partial class FrmPpal : Form
    {
        ImperialArmy army;

        public FrmPpal()
        {  
            InitializeComponent();
            army = new(100);
            Trooper trooper = new(Blaster.EC17);

            army.AddTrooper(trooper);
        }
       
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            foreach (var type in Enum.GetNames(typeof(EType)))
            {
                cmbTipo.Items.Add(type);
            }

            foreach (var armament in Enum.GetNames(typeof(Blaster)))
            {
                cmbBlaster.Items.Add(armament);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem is null || cmbBlaster.SelectedItem is null)
            {
                return;
            }

            string typeValue = cmbTipo.SelectedItem.ToString();
            bool isClonValue = ckbClon.Checked;
            Blaster blasterValue;
            Trooper trooper;

            if (typeValue == "Sand")
            {
                blasterValue = Blaster.EC17;
            }
            else if (typeValue == "Assault")
            {
                blasterValue = Blaster.E11;
            }
            else
            {
                blasterValue = Blaster.DLT19;
            }

            //Blaster blasterValue = (Blaster)cmbBlaster.SelectedItem; // Error en tiempo de ejecucion
            
            trooper = new(blasterValue, isClonValue);

            army.AddTrooper(trooper);

            RefrescarEjercito();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem is null || cmbBlaster.SelectedItem is null)
            {
                return;
            }

            string typeValue = cmbTipo.SelectedItem.ToString();
            bool isClonValue = ckbClon.Checked;
            Blaster blasterValue;
            Trooper trooper;

            if (typeValue == "Sand")
            {
                blasterValue = Blaster.EC17;
            }
            else if (typeValue == "Assault")
            {
                blasterValue = Blaster.E11;
            }
            else
            {
                blasterValue = Blaster.DLT19;
            }


            trooper = new(blasterValue);

            army.DeleteTrooper(trooper);
            RefrescarEjercito();
        }
        private void RefrescarEjercito()
        {
            lstEjercito.Items.Clear();
            
            foreach (Trooper troop in army.Troopers)
            {
                lstEjercito.Items.Add(troop.InfoTrooper());
            }
        }
    }
}
