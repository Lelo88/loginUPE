using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;
using BLL;
using DAL;

namespace UsuarioTests
{
    [TestClass]
    public class UsuarioBLLTests
    {
        [TestMethod]
        public void Loguearse_UsuarioValido_DeberiaRetornarTrue()
        {
            // Arrange
            var mockDal = new Mock<InterfaceUsuario>();
            var dt = new DataTable();
            dt.Columns.Add("usuario");
            dt.Columns.Add("clave");
            dt.Rows.Add("admin", "admin");

            mockDal.Setup(d => d.IniciarSesion("admin", "admin")).Returns(dt);

            var usuarioBll = new BLL.Usuario(mockDal.Object);

            // Act
            bool result = usuarioBll.Loguearse("admin", "admin");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Loguearse_UsuarioInvalido_DeberiaRetornarFalse()
        {
            // Arrange
            var mockDal = new Mock<InterfaceUsuario>();
            var dt = new DataTable();
            dt.Columns.Add("usuario");
            dt.Columns.Add("clave");
            // No agregamos filas: DataTable vacío

            mockDal.Setup(d => d.IniciarSesion("usuarioInvalido", "contrasenaInvalida")).Returns(dt);

            var usuarioBll = new BLL.Usuario(mockDal.Object);

            // Act
            bool result = usuarioBll.Loguearse("usuarioInvalido", "contrasenaInvalida");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Loguearse_ClaveIncorrecta_DeberiaRetornarFalse()
        {
            // Arrange
            var mockDal = new Mock<InterfaceUsuario>();
            var dt = new DataTable();
            dt.Columns.Add("usuario");
            dt.Columns.Add("clave");
            dt.Rows.Add("admin", "otraClave");

            mockDal.Setup(d => d.IniciarSesion("admin", "admin")).Returns(dt);

            var usuarioBll = new BLL.Usuario(mockDal.Object);

            // Act
            bool result = usuarioBll.Loguearse("admin", "admin");

            // Assert
            Assert.IsFalse(result);
        }

    }
}
