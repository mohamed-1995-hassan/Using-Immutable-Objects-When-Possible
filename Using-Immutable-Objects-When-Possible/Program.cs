
// See https://aka.ms/new-console-template for more information

using Using_Immutable_Objects_When_Possible;

static void ClaimWarranty(SoldArticle soldArticle)
{
    DateTime now = DateTime.Now;
    soldArticle.MoneyBackGuarantee.Claim(now, () => { Console.WriteLine("offer Money back"); });
    soldArticle.ExpressWarranty.Claim(now, () => { Console.WriteLine("offer Money back"); });
}

DateTime sellingDate = new DateTime(2016, 8, 6);
TimeSpan moneyBackSpan = TimeSpan.FromDays(30); 
TimeSpan warrentySpan = TimeSpan.FromDays(365);

IWarranty moneyBack = new TimeLimitedWarranty(sellingDate, moneyBackSpan);
IWarranty warrenty = new LifeTimeWarranty(sellingDate);

IWarranty noMoney = VoidWarranty.Instance;

SoldArticle soldArticle = new SoldArticle(noMoney, warrenty, moneyBack);

ClaimWarranty(soldArticle);
Console.ReadLine();
