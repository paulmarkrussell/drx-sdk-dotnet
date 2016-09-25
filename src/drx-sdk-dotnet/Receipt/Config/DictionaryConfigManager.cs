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
package net.dreceiptx.receipt.config;

import java.util.Dictionary;
import java.util.Hashtable;

/**
 * Simple Dictionary Based ConfigManager
 */
public class DictionaryConfigManager implements ConfigManager {
    private Dictionary<String, String> _config = new Hashtable<>();

    Override
    public String getConfigValue(String key) {
        return _config.get(key);
    }

    Override
    public void setConfigValue(String key, String value) {
        _config.put(key, value);
    }

    Override
    public boolean exists(String key) {
        return _config.get(key) != null;
    }

    Override
    public void setConfigValue(String key, String value, boolean commit) {
        this.setConfigValue(key, value);
    }
}