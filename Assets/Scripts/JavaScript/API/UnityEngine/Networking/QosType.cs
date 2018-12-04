using System;
using ChakraCore.API;
using static JavaScript.Bridge;

namespace JavaScript.API.JSUnityEngine.Networking {
  class JSQosType {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue QosTypePrototype;
      JavaScriptValue QosTypeConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Networking.QosType),
        (args) => { throw new NotImplementedException(); },
        out QosTypePrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .GetProperty("Networking")
        .SetProperty("QosType", QosTypeConstructor);


      // Static Fields

      QosTypeConstructor.SetProperty(
        "Unreliable",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.Unreliable)
      );


      QosTypeConstructor.SetProperty(
        "UnreliableFragmented",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.UnreliableFragmented)
      );


      QosTypeConstructor.SetProperty(
        "UnreliableSequenced",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.UnreliableSequenced)
      );


      QosTypeConstructor.SetProperty(
        "Reliable",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.Reliable)
      );


      QosTypeConstructor.SetProperty(
        "ReliableFragmented",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.ReliableFragmented)
      );


      QosTypeConstructor.SetProperty(
        "ReliableSequenced",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.ReliableSequenced)
      );


      QosTypeConstructor.SetProperty(
        "StateUpdate",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.StateUpdate)
      );


      QosTypeConstructor.SetProperty(
        "ReliableStateUpdate",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.ReliableStateUpdate)
      );


      QosTypeConstructor.SetProperty(
        "AllCostDelivery",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.AllCostDelivery)
      );


      QosTypeConstructor.SetProperty(
        "UnreliableFragmentedSequenced",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.UnreliableFragmentedSequenced)
      );


      QosTypeConstructor.SetProperty(
        "ReliableFragmentedSequenced",
        Bridge.CreateExternalWithPrototype(UnityEngine.Networking.QosType.ReliableFragmentedSequenced)
      );


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors


      // Instance Methods

    }
  }
}
