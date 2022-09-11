using System;
using System.Runtime.CompilerServices;
using System.Text; 

namespace EntidadesStarWars
{
    public class Trooper
    {
        private Blaster armament;
        private string description;
        private bool isClon;
        private EType type;

        public Trooper(Blaster armament)
        {
            if(this.Type is not EType.Explorer)
            {
                this.armament = armament;
            }
            else
            {
                this.armament = Blaster.DLT19;
            }

            if (this.Type is not EType.Sand)
            {
                this.isClon = false;
            }
            else
            {
                this.isClon = true;
            }
            
        }

        public Trooper(Blaster armament, bool isClon)
        {
            if (this.Type is not EType.Explorer)
            {
                this.armament = armament;
            }
            else
            {
                this.armament = Blaster.DLT19;
            }

            if (this.Type is not EType.Sand)
            {
                this.isClon = isClon;
            }
            else
            {
                this.isClon = true;
            }

        }

        public Blaster Armament { get => armament; }
        public bool IsClon { get => isClon; set => isClon = value; }
        public EType Type { get => type; set => type = value; }

        public string InfoTrooper()
        {
            string isClon = this.isClon ? "SI" : "NO";

            return $"{LoadDescription(this.Type)}, armado con {this.Armament}, {isClon} es clon.";
        }

        public string LoadDescription(EType type)
        {
            return type switch
            {
                EType.Sand => "Soldado de asalto de terrenos desérticos",
                EType.Assault => "Comando para misiones de infiltracion",
                EType.Explorer => "Soldado de exploracion",
                _ => "ERROR. Tipo invalido",
            };
        }

    }
}
