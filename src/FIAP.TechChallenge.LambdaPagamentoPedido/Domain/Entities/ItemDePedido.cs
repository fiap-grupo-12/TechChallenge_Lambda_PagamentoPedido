using Amazon.DynamoDBv2.DataModel;
using System.Diagnostics.CodeAnalysis;

namespace FIAP.TechChallenge.LambdaPagamentoPedido.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class ItemDePedido
    {
        [DynamoDBProperty("id")]
        public int Id { get; set; }

        [DynamoDBProperty("nome")]
        public string Nome { get; set; }

        [DynamoDBProperty("valor")]
        public double Valor { get; set; }

        [DynamoDBProperty("quantidade")]
        public int Quantidade { get; set; }
    }

}
