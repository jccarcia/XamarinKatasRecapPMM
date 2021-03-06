﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Img { get; set; }
    }

    public class ListaElementos
    {
        public List<Persona> _persona { get; set; }

        public ListaElementos()
        {
            _persona = new List<Persona>();
            LoadElements();
        }

        public void LoadElements()
        {
            _persona.Add(new Persona { Edad = 35, Nombre = "Chema", Img = "chema.jpg" });
            _persona.Add(new Persona { Edad = 22, Nombre = "Cueto" });
            _persona.Add(new Persona { Edad = 23, Nombre = "Juanki" });
            _persona.Add(new Persona { Edad = 56, Nombre = "Jose Luis" });
            _persona.Add(new Persona { Edad = 22, Nombre = "Juanca", Img = "D:/Visual studio/repos/XamarinKatasRecapPMM/XamarinFormsKatas/XamarinFormsKatas/Katas_UI/Kata_d/juanca.png" });
        }
    }
}
