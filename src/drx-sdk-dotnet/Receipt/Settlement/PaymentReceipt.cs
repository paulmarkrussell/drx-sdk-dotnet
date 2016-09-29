#region copyright
// Copyright 2016 Digital Receipt Exchange Limited
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
#endregion

using Net.Dreceiptx.Receipt.Common;

namespace Net.Dreceiptx.Receipt.Settlement
{
    public class PaymentReceipt
    {
        public int Id { get; set; }
        public PaymentMethodType MethodType { get; set; }
        public double PaymentAmount { get; set; }
        public Currency SettlementCurrency { get; internal set; }
        public PaymentAuthorisation PaymentAuthorisation { get; set; }

        public PaymentReceipt(PaymentMethodType paymentMethodCode, double paymentAmount)
        {
            MethodType = paymentMethodCode;
            PaymentAmount = paymentAmount;
        }

        //TODO: payment amount is non nullable unlike java
        public PaymentReceipt(PaymentMethodType paymentMethodCode, double paymentAmount, Currency settlementCurrency)
            : this(paymentMethodCode, paymentAmount)
        {
            SettlementCurrency = settlementCurrency;
            PaymentAuthorisation = null;
        }

        public bool HasPaymentAuthorisation()
        {
            return PaymentAuthorisation != null;
        }
    }
}