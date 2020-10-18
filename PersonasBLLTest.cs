using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro_Detalle.BLL;
using Registro_Detalle.Models;
using System;


namespace Registro_Detalle
{
    [TestClass]
    public class PersonasBLLTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Personas p = new Personas();
            bool paso = false;
            p.PersonaId = 0;
            p.Nombre = "Jose Alberto";
            p.Fecha = DateTime.Now;
            p.Cedula = "40225550022";
            p.Direccion = "Calle Duarte #50";
            p.Telefono = "8099637885";
            p.Balance = 0;
            paso = PersonasBLL.Guardar(p);
            Assert.AreEqual(paso, true);
        }
    }
}
