using System;
using System.Collections.Generic;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
	[TestClass]
	public class MisTests
	{
		[TestMethod]
		public void ValidarListaDeLlamadas()
		{
			//Arrange
			Correo c = new Correo();

			//Act
			//-- No hay, pregunto directo si es no es nula. Si no lo es, true, pasa test, si no false.

			//Assert
			Assert.IsNotNull(c.Paquetes);
		}

		[TestMethod]
		[ExpectedException(typeof(TrackingIdRepetidoException))]
		public void ValidarTrackingID()
		{
			Correo c = new Correo();
			Paquete p = new Paquete("Avenida Siempre Viva 123", "Homero123");
			Paquete p2 = new Paquete("Avenida Siempre Viva 1234", "Homero123");
			c = c + p;
			c = c + p2;
		}
	}
}
