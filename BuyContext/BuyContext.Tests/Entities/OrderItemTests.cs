using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuyContext.Domain.Entities;

namespace BuyContext.Tests.Entities
{
    [TestClass]
    public class OrderItemTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pedido_sem_produto_o_mesmo_nao_deve_ser_valido()
        {
            var orderItem = new OrderItem(null, 2);
            Assert.AreEqual(orderItem.Valid, false);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pedido_sem_quantidade_o_mesmo_nao_deve_ser_valido()
        {
            var product = new Product("Açai", 5, 2);
            var orderItem = new OrderItem(product, 0);
            Assert.AreEqual(orderItem.Valid, false);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pedido_com_os_campos_preenchidos_o_mesmo_deve_ser_valido()
        {
            var product = new Product("Açai", 5, 2);
            var orderItem = new OrderItem(product, 2);
            Assert.AreEqual(orderItem.Valid, true);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pedido_com_preco_de_8_reais_e_quantidade_2_o_total_deve_retornar_16()
        {
            var product = new Product("Açai", 5, 3);
            var orderItem = new OrderItem(product, 2);
            Assert.AreEqual(orderItem.Total(), 16);
        }



    }
}