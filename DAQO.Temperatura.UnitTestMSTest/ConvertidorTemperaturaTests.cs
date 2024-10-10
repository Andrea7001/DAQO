using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAQO.DAQT.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQO.DAQT.Temperatura.Tests
{
    [TestClass]
    public class ConvertidorTemperaturaTests
    {
        private ConvertidorTemperatura _convertidor;

        [TestInitialize]
        public void Setup()
        {
            _convertidor = new ConvertidorTemperatura();
        }

        [TestMethod]
        public void CelsiusAFahrenheit_DevuelveCorrecto()
        {
             
            double celsius = 0;

            
            double resultado = _convertidor.CelsiusAFahrenheit(celsius);

            
            Assert.AreEqual(32, resultado);
        }

        [TestMethod]
        public void FahrenheitACelsius_DevuelveCorrecto()
        {
            
            double fahrenheit = 32;

            
            double resultado = _convertidor.FahrenheitACelsius(fahrenheit);

             
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void CelsiusAKelvin_DevuelveCorrecto()
        {
             
            double celsius = 0;

            
            double resultado = _convertidor.CelsiusAKelvin(celsius);

             
            Assert.AreEqual(273.15, resultado);
        }

        [TestMethod]
        public void KelvinACelsius_DevuelveCorrecto()
        {
            
            double kelvin = 273.15;

            
            double resultado = _convertidor.KelvinACelsius(kelvin);

             
            Assert.AreEqual(0, resultado);
        }
    }

}