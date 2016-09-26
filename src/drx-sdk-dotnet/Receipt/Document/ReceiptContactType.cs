/*
 * Copyright 2016 Digital Receipt Exchange Limited
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package net.dreceiptx.receipt.document;

import com.google.gson.annotations.SerializedName;

public enum ReceiptContactType {
    @SerializedName("SA")
    SALES_ADMINISTRATION("SA", "Sales administration"),
    @SerializedName("DL")
    DELIVERY_CONTACT("DL", "Delivery contact"),
    @SerializedName("CR")
    CUSTOMER_RELATIONS("CR", "Customer relations"),
    @SerializedName("PD")
    PURCHASING_CONTACT("PD", "Purchasing Contact"),
    @SerializedName("GR")
    RECIPIENT_CONTACT("GR", "Recipient contact");

    private String _value;

    private String _displayName;

    ReceiptContactType(String value, String name) {
        this._value = value;
        this._displayName = name;
    }

    public String getValue() {
        return this._value;
    }

    public String getDisplayName() {
        return this._displayName;
    }

    @Override
    public String toString() {
        return this._displayName;
    }
}