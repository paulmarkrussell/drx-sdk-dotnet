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
package net.dreceiptx.receipt.common;

import com.google.gson.annotations.SerializedName;

public enum ContactType {
    @SerializedName("EMAIL")
    EMAIL("EMAIL", "Contact primary email address"),
    @SerializedName("TELEPHONE")
    TELEPHONE("TELEPHONE", "Contact primary telephone address");

    private string _value;

    private string _displayName;

    ContactType(string value, string name) {
        _value = value;
        _displayName = name;
    }

    public string getValue() {
        return _value;
    }

    public string getDisplayName() {
        return _displayName;
    }

    @Override
    public string toString() {
        return _displayName;
    }
}
