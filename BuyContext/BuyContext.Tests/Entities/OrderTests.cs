using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuyContext.Domain.Entities;
using BuyContext.Domain.Enums;

namespace BuyContext.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_sem_produto_o_mesmo_nao_deve_ser_gerado()
        {
            var order = new Order();
            order.AddItem(null, 2);
            Assert.AreEqual(order.Items.Count, 0);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pedido_com_quantidade_igual_a_zero_o_mesmo_nao_deve_ser_gerado()
        {
            var order = new Order();
            var product = new Product("sorvete", 5, EAdditionalItem.Granulado);
            order.AddItem(product, 0);
            Assert.AreEqual(order.Items.Count, 0);
        }



    }

}