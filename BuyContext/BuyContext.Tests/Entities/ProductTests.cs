using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuyContext.Domain.Entities;

namespace BuyContext.Tests.Entities
{
    [TestClass]
    public class ProductTests
    {

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_produto_de_5_reais_e_item_adicional_de_3_reais_a_soma_deve_ser_8()
        {
            var product = new Product("Sorvete", 5, 3);

            Assert.AreEqual(product.Price, 8);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_produto_sem_item_adicional_o_preco_deve_retornar_o_mesmo()
        {
            var product = new Product("Açai", 10, 0);

            Assert.AreEqual(product.Price, 10);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_produto_sem_nome_o_mesmo_deve_ser_invalido()
        {
            var product = new Product(null, 5, 3);

            Assert.AreEqual(product.Valid, false);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_produto_com_preço_igual_a_zero_o_mesmo_deve_ser_invalido()
        {
            var product = new Product("Sorvete", 0, 3);

            Assert.AreEqual(product.Valid, false);
        }

    }
}