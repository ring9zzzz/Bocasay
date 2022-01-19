"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.baseComponent = void 0;
var baseComponent = /** @class */ (function () {
    function baseComponent() {
    }
    baseComponent.prototype.getVariableName = function (name) {
        return name.toString().match(/[.](\w+)/)[1];
    };
    return baseComponent;
}());
exports.baseComponent = baseComponent;
//# sourceMappingURL=base.js.map