using System.Collections.Generic;

namespace DCS.FiscalDriverBase.Dto
{
    public class TransactionDto
    {

        public int Id { get; set; } = 0;

        public string InvoiceNumber { get; set; } = "";

        public bool IsTaxExempt { get; set; } = false;

        public List<Card> Cards { get; set; } = new List<Card>();

        public decimal NetTotal { get; set; } = 0;

        public decimal DiscountAmount { get; set; } = 0;

        public decimal TaxAmount { get; set; } = 0;

        public decimal TotalToPay { get; set; } = 0;

        public List<Payment> Payments { get; set; } = new List<Payment>();

        public List<Tax> Taxes { get; set; } = new List<Tax>();

        public SystemUser Operator { get; set; } = new SystemUser();

        //public Dictionary<string, string> AnnexData { get; set; } = new Dictionary<string, string>();

        //public bool FillDtoFromPosTransaction(clsPOSXaction posXact,
        //                                      ref string failReasonMessage, 
        //                                      ref string failReasonException
        //                                     )
        //{

        //    bool retVal = false;

        //    failReasonException = "";
        //    failReasonMessage = "";

        //    try
        //    {
        //        //Basics
        //        Id = posXact.ID;
        //        InvoiceNumber = posXact.lXactInvoiceNumber.ToString();
        //        IsTaxExempt = posXact.IsTaxExempt;
        //        if(null != posXact.Operator)
        //        {
        //            Operator = new SystemUser(posXact.Operator.ID,
        //                                      posXact.Operator.FirstName,
        //                                      posXact.Operator.LastName,
        //                                      posXact.Operator.Nick,
        //                                      posXact.Operator.Card
        //                                     );
        //        }
        //        else
        //        {
        //            Operator = new SystemUser();
        //        }

        //        //Products and maths
        //        foreach (clsPOSCard cd in posXact.Cards)
        //        {

        //            var newCard = new Card(cd.CardNumber,
        //                                   cd.AssociatedDeviceID
        //                                  );

        //            foreach (clsPOSLineItem li in cd.LineItems)
        //            {
        //                decimal qty = Convert.ToDecimal(li.Quantity);

        //                //decimal productNet = 0;
        //                var newProd = new Product(li.ID,
        //                                          li.Description,
        //                                          li.UPrice,
        //                                          qty,
        //                                          (li.ProductInfo.Modifiers != null ? li.ProductInfo.Modifiers.SpecialRequest : "")
        //                                         );

        //                //Yes, I know. This MAY NOT be the Net, but bear with me.
        //                //productNet = (newProd.Quantity * newProd.UnitPrice);

        //                foreach (clsPOSProductModifier md in li.ProductInfo.Modifiers)
        //                {

        //                    var newMddr = new Modifier(md.ID,
        //                                               md.Description,
        //                                               md.Price
        //                                              );

        //                    newProd.Modifiers.Add(newMddr);

        //                    //Yes, I know. This MAY NOT be the Net, but bear with me.
        //                    //productNet += (newProd.Quantity * newMddr.UnitPrice);

        //                }

        //                foreach (clsPOSTax tx in li.Taxes)
        //                {

        //                    var newTax = new Tax(tx.ID,
        //                                         (Tax.TaxType) tx.TaxType,
        //                                         tx.TaxRate,
        //                                         tx.TaxName
        //                                        );

        //                    newProd.Taxes.Add(newTax);

        //                    //This makes sure that productNet IS the net for VAT-Type taxes.
        //                    //if (Tax.TaxType.VATType == newTax.Type)
        //                    //{
        //                    //    productNet = (productNet / (1 + (newTax.Rate / 100)));
        //                    //}

        //                    //This accumulates the total tax amount, no matter what type.
        //                    //TaxAmount += (productNet * (newTax.Rate / 100));

        //                }

        //                //Add this product's net value to the transaction net
        //                //NetTotal += productNet;

        //                newCard.Products.Add(newProd);

        //            }

        //            Cards.Add(newCard);

        //        }

        //        //Set totals
        //        NetTotal = posXact.dbXactNetTotal;
        //        TaxAmount = 0;
        //        foreach(clsPOSTax tx in posXact.cTaxes)
        //        {

        //            var transTax = new Tax(tx.ID,
        //                                   (Tax.TaxType)tx.TaxType,
        //                                   tx.TaxRate,
        //                                   tx.TaxName,
        //                                   tx.TaxableBase,
        //                                   tx.TaxAmount
        //                                  );

        //            Taxes.Add(transTax);

        //            //This is zero when the transaction is exempt, as cTaxes comes empty.
        //            TaxAmount += transTax.Amount;

        //        }
        //        DiscountAmount = ((posXact.oDiscount.DiscountApplied) ? posXact.oDiscount.Amount : 0);
        //        TotalToPay = posXact.dbXactTotalToPay;

        //        foreach (clsPOSPayment pm in posXact.Payments)
        //        {

        //            //Prepare a new currency object to reflect the way this split has been paid.
        //            var newCur = new CurrencyType(pm.Paymode.ID,
        //                                          (int)pm.Paymode.PMType, //This is a VBA enum (all VBA enums are 32bit integers), so we shoehorn it into a 32-bit INT
        //                                          pm.Paymode.Description,
        //                                          pm.Paymode.XchgRatio,
        //                                          pm.Paymode.NeedsPIN
        //                                         );

        //            //Prepare a new payment object, set its amounts and currency
        //            var newPmt = new Payment(pm.Amount,
        //                                     pm.Tendered,
        //                                     newCur,
        //                                     pm.AuthorizationReferenceNumber
        //                                    );

        //            Payments.Add(newPmt);

        //        }

        //        ////Annex data
        //        //foreach(string key in posXact.AnnexData.Keys())
        //        //{
        //        //    AnnexData.Add(key, posXact.AnnexData.get_Item(key));
        //        //}

        //        //We're OK.
        //        retVal = true;

        //    }
        //    catch (Exception ex)
        //    {
        //        failReasonException = ex.ToString();
        //        failReasonMessage = ex.Message;
        //    }

        //    return retVal;

        //}
    }
}