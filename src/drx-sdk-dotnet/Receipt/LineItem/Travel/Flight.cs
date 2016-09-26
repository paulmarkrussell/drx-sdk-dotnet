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
package net.dreceiptx.receipt.lineitem.travel;

import net.dreceiptx.receipt.ecom.AVPType;
import net.dreceiptx.receipt.lineitem.TradeItemDescriptionInformation;
import net.dreceiptx.receipt.lineitem.TransactionalTradeItemType;
import net.dreceiptx.receipt.lineitem.LineItem;
import java.util.Date;

public class Flight extends LineItem {
    public static final string LineItemTypeValue = "TRAVEL0002";

    public Flight(FlightType flightType, string airline, string shortItinerary, string longItinerary, int quantity, double price) {
        super(airline, shortItinerary, longItinerary, quantity, price);
        this.setTradeItemGroupIdentificationCode(flightType.code());
        this.addTradeItemIdentification(LineItem.LineItemTypeIdentifier, Flight.LineItemTypeValue);
    }

    public Flight(TradeItemDescriptionInformation tradeItemDescriptionInformation, int quantity, double price) {
        super(tradeItemDescriptionInformation, quantity, price);
        this._transactionalTradeItemType = TransactionalTradeItemType.MANUAL;
        this.addTradeItemIdentification(LineItem.LineItemTypeIdentifier, Flight.LineItemTypeValue);
    }
    
    public string getAirline(){
        return this.getBrandName();
    }
    
    public string getItinerary(){
        return this.getName();
    }
    
    public string getItineraryDescription(){
        return this.getDescription();
    }

    public FlightType getFlightType(){
        return (FlightType)this.getLineItemType(FlightType.class, FlightType.DEFAULT);
    }

    public void setPassengerName(string passengerName){
        this._AVPList.add(AVPType.PASSENGER_NAME.Code(), passengerName);
    }

    public string getPassengerName(){
        return this._AVPList.get(AVPType.PASSENGER_NAME.Code()).getValue();
    }
    
    public Date getDepartureDate(){
        return this.getDespatchDate();
    }
    
    public void setDepartureDate(Date departureDate){
        this.setDespatchDate(departureDate);
    }
    
    public void setTicketNumber(string ticketNumber){
        this._serialNumber = ticketNumber;
    }
    
    public string getTicketNumber(){
        return this._serialNumber;
    }
}