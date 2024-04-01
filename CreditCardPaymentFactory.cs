using System;
using System.Security.Cryptography.X509Certificates;

namespace OrderManagementSystem;

/* Zaimplementuj interfejs IOrderFactory, który będzie zawierał metodę CreateOrder().
 * Stwórz dwie klasy implementujące nowy interfejs: CreditCardPaymentFactory i BLIKPaymentFactory.
 * CreditCardPaymentFactory ma tworzyć zamówienia z płatnością kartą kredytową, a BLIKPaymentFactory z płatnością przez BLIK.
 */
public class CreditCardPaymentFactory : IPaymentFactory
{
    public string PaymentOperator => throw new NotImplementedException();

    public int Amount => throw new NotImplementedException();
}
