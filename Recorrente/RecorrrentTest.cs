using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recorrente.Domain.Orders;
using RestSharp;

namespace Recorrente
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task Request()
        {
            var order = new Order
            {
                MerchantOrderId = "123",
                Customer = new Customer { Name = "Vinicius A. S. Silva" },
                Payment = new Payment
                {
                    Provider = "Simulado",
                    Type = "CreditCard",
                    Amount = 10000,
                    Installments = 1,
                    CreditCard = new CreditCard
                    {
                        CardNumber = "4551870000000181",
                        Holder = "Nome do Portador",
                        ExpirationDate = "12/2021",
                        SecurityCode = "123",
                        Brand = "Visa"
                    },
                    RecurrentPayment = new RecurrentPayment
                    {
                        AuthorizeNow = true,
                        EndDate = "2019-12-31",
                        Interval = "Monthly"
                    }
                }

            };

            var client = new RestClient("https://apisandbox.braspag.com.br");
            var request = new RestRequest("/v2/sales", Method.POST);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("MerchantId", "10e651a8-2ce5-4f0a-897b-8e9f0580ed60");
            request.AddHeader("MerchantKey", "XFYELFRBDRZVVXTRWVNQMQDBJLARFDKWUDATNTQP");

            request.AddJsonBody(order);

            var response = await client.ExecuteTaskAsync(request);
        }
    }
}
