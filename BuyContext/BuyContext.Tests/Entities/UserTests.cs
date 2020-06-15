using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuyContext.Domain.Entities;

namespace BuyContext.Tests.Entities
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_usuario_sem_nome_o_mesmo_nao_deve_ser_valido()
        {
            var user = new User("", "1234");
            Assert.AreEqual(user.Valid, false);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_usuario_sem_senha_o_mesmo_nao_deve_ser_valido()
        {
            var user = new User("lucas", null);
            Assert.AreEqual(user.Valid, false);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_usuario_com_os_dados_preenchidos_o_mesmo_deve_ser_valido()
        {
            var user = new User("lucas", "1234");
            Assert.AreEqual(user.Valid, true);
        }
    }
}