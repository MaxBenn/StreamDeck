// global websocket, used to communicate from/to Stream Deck software
// as well as some info about our plugin, as sent by Stream Deck software 
var websocket = null,
    uuid = null,
    inInfo = null,
    actionInfo = {},
    settingsModel = {
        ApiToken: 0,
        SmartLockId: 0
    };

function connectElgatoStreamDeckSocket(inPort, inUUID, inRegisterEvent, inInfo, inActionInfo) {
    uuid = inUUID;
    actionInfo = JSON.parse(inActionInfo);
    inInfo = JSON.parse(inInfo);
    websocket = new WebSocket('ws://localhost:' + inPort);

    //initialize values
    if (actionInfo.payload.settings.settingsModel) {
        settingsModel.ApiToken = actionInfo.payload.settings.settingsModel.ApiToken;
        settingsModel.SmartLockId = actionInfo.payload.settings.settingsModel.SmartLockId;
    }

    document.getElementById('apiToken').value = settingsModel.ApiToken;
    document.getElementById('smartLockId').value = settingsModel.SmartLockId;

    websocket.onopen = function () {
        var json = { event: inRegisterEvent, uuid: inUUID };
        // register property inspector to Stream Deck
        websocket.send(JSON.stringify(json));

    };

    websocket.onmessage = function (evt) {
        // Received message from Stream Deck
        var jsonObj = JSON.parse(evt.data);
        var sdEvent = jsonObj['event'];
        switch (sdEvent) {
            case "didReceiveSettings":
                if (jsonObj.payload.settings.settingsModel.ApiToken) {
                    settingsModel.ApiToken = jsonObj.payload.settings.settingsModel.ApiToken;
                    document.getElementById('apiToken').value = settingsModel.ApiToken;
                }
                if (jsonObj.payload.settings.settingsModel.SmartLockId) {
                    settingsModel.SmartLockId = jsonObj.payload.settings.settingsModel.SmartLockId;
                    document.getElementById('smartLockId').value = settingsModel.SmartLockId;
                }
                break;
            default:
                break;
        }
    };
}

const setSettings = (value, param) => {
    if (websocket) {
        settingsModel[param] = value;
        var json = {
            "event": "setSettings",
            "context": uuid,
            "payload": {
                "settingsModel": settingsModel
            }
        };
        websocket.send(JSON.stringify(json));
    }
};

