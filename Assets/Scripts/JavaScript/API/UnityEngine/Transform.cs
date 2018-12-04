using ChakraCore.API;

namespace JavaScript.API.JSUnityEngine {
  class JSTransform {
    public static void Register(JavaScriptContext context) {
      JavaScriptValue TransformPrototype;
      JavaScriptValue TransformConstructor = Bridge.CreateConstructor(
        typeof(UnityEngine.Transform),
        (args) => { throw new System.NotImplementedException(); },
        out TransformPrototype
      );
      JavaScriptValue
        .GlobalObject
        .GetProperty("UnityEngine")
        .SetProperty("Transform", TransformConstructor);


      // Static Fields


      // Static Property Accessors


      // Static Methods


      // Instance Fields


      // Instance Property Accessors

      Bridge.DefineGetterSetter(
        TransformPrototype,
        "position",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.position)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.position = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "localPosition",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.localPosition)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.localPosition = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "eulerAngles",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.eulerAngles)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.eulerAngles = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "localEulerAngles",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.localEulerAngles)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.localEulerAngles = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "right",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.right)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.right = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "up",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.up)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.up = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "forward",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.forward)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.forward = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "rotation",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.rotation)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.rotation = Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "localRotation",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.localRotation)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.localRotation = Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "localScale",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.localScale)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.localScale = Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped; })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "parent",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.parent)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.parent = Bridge.GetExternal<UnityEngine.Transform>(args[1]); })
      );


      Bridge.DefineGetter(
        TransformPrototype,
        "worldToLocalMatrix",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.worldToLocalMatrix))
      );


      Bridge.DefineGetter(
        TransformPrototype,
        "localToWorldMatrix",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.localToWorldMatrix))
      );


      Bridge.DefineGetter(
        TransformPrototype,
        "root",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.root))
      );


      Bridge.DefineGetter(
        TransformPrototype,
        "childCount",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => JavaScriptValue.FromInt32(o.childCount))
      );


      Bridge.DefineGetter(
        TransformPrototype,
        "lossyScale",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.lossyScale))
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "hasChanged",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => JavaScriptValue.FromBoolean(o.hasChanged)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.hasChanged = args[1].ToBoolean(); })
      );


      Bridge.DefineGetterSetter(
        TransformPrototype,
        "hierarchyCapacity",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => JavaScriptValue.FromInt32(o.hierarchyCapacity)),
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => { o.hierarchyCapacity = args[1].ToInt32(); })
      );


      Bridge.DefineGetter(
        TransformPrototype,
        "hierarchyCount",
        Bridge.WithExternal<UnityEngine.Transform>((o, args) => JavaScriptValue.FromInt32(o.hierarchyCount))
      );


      // Instance Methods

      TransformPrototype.SetProperty(
        "SetParent",
        Bridge.CreateFunction(
          "SetParent",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.SetParent(Bridge.GetExternal<UnityEngine.Transform>(args[1])))
        )
      );


      TransformPrototype.SetProperty(
        "SetParent",
        Bridge.CreateFunction(
          "SetParent",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.SetParent(Bridge.GetExternal<UnityEngine.Transform>(args[1]), args[2].ToBoolean()))
        )
      );


      TransformPrototype.SetProperty(
        "SetPositionAndRotation",
        Bridge.CreateFunction(
          "SetPositionAndRotation",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.SetPositionAndRotation(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Quaternion>(args[2]).wrapped))
        )
      );


      TransformPrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Translate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Space>(args[2])))
        )
      );


      TransformPrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Translate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      TransformPrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Translate((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.Space>(args[4])))
        )
      );


      TransformPrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Translate((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      TransformPrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Translate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Transform>(args[2])))
        )
      );


      TransformPrototype.SetProperty(
        "Translate",
        Bridge.CreateFunction(
          "Translate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Translate((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.Transform>(args[4])))
        )
      );


      TransformPrototype.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Rotate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetExternal<UnityEngine.Space>(args[2])))
        )
      );


      TransformPrototype.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Rotate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      TransformPrototype.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Rotate((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble(), Bridge.GetExternal<UnityEngine.Space>(args[4])))
        )
      );


      TransformPrototype.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Rotate((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble()))
        )
      );


      TransformPrototype.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Rotate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble(), Bridge.GetExternal<UnityEngine.Space>(args[3])))
        )
      );


      TransformPrototype.SetProperty(
        "Rotate",
        Bridge.CreateFunction(
          "Rotate",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.Rotate(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, (float) args[2].ToDouble()))
        )
      );


      TransformPrototype.SetProperty(
        "RotateAround",
        Bridge.CreateFunction(
          "RotateAround",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.RotateAround(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped, (float) args[3].ToDouble()))
        )
      );


      TransformPrototype.SetProperty(
        "LookAt",
        Bridge.CreateFunction(
          "LookAt",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.LookAt(Bridge.GetExternal<UnityEngine.Transform>(args[1]), Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      TransformPrototype.SetProperty(
        "LookAt",
        Bridge.CreateFunction(
          "LookAt",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.LookAt(Bridge.GetExternal<UnityEngine.Transform>(args[1])))
        )
      );


      TransformPrototype.SetProperty(
        "LookAt",
        Bridge.CreateFunction(
          "LookAt",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.LookAt(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped, Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[2]).wrapped))
        )
      );


      TransformPrototype.SetProperty(
        "LookAt",
        Bridge.CreateFunction(
          "LookAt",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.LookAt(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped))
        )
      );


      TransformPrototype.SetProperty(
        "TransformDirection",
        Bridge.CreateFunction(
          "TransformDirection",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.TransformDirection(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      TransformPrototype.SetProperty(
        "TransformDirection",
        Bridge.CreateFunction(
          "TransformDirection",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.TransformDirection((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble())))
        )
      );


      TransformPrototype.SetProperty(
        "InverseTransformDirection",
        Bridge.CreateFunction(
          "InverseTransformDirection",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.InverseTransformDirection(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      TransformPrototype.SetProperty(
        "InverseTransformDirection",
        Bridge.CreateFunction(
          "InverseTransformDirection",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.InverseTransformDirection((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble())))
        )
      );


      TransformPrototype.SetProperty(
        "TransformVector",
        Bridge.CreateFunction(
          "TransformVector",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.TransformVector(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      TransformPrototype.SetProperty(
        "TransformVector",
        Bridge.CreateFunction(
          "TransformVector",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.TransformVector((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble())))
        )
      );


      TransformPrototype.SetProperty(
        "InverseTransformVector",
        Bridge.CreateFunction(
          "InverseTransformVector",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.InverseTransformVector(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      TransformPrototype.SetProperty(
        "InverseTransformVector",
        Bridge.CreateFunction(
          "InverseTransformVector",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.InverseTransformVector((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble())))
        )
      );


      TransformPrototype.SetProperty(
        "TransformPoint",
        Bridge.CreateFunction(
          "TransformPoint",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.TransformPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      TransformPrototype.SetProperty(
        "TransformPoint",
        Bridge.CreateFunction(
          "TransformPoint",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.TransformPoint((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble())))
        )
      );


      TransformPrototype.SetProperty(
        "InverseTransformPoint",
        Bridge.CreateFunction(
          "InverseTransformPoint",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.InverseTransformPoint(Bridge.GetBoxedExternal<UnityEngine.Vector3>(args[1]).wrapped)))
        )
      );


      TransformPrototype.SetProperty(
        "InverseTransformPoint",
        Bridge.CreateFunction(
          "InverseTransformPoint",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.InverseTransformPoint((float) args[1].ToDouble(), (float) args[2].ToDouble(), (float) args[3].ToDouble())))
        )
      );


      TransformPrototype.SetProperty(
        "DetachChildren",
        Bridge.CreateFunction(
          "DetachChildren",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.DetachChildren())
        )
      );


      TransformPrototype.SetProperty(
        "SetAsFirstSibling",
        Bridge.CreateFunction(
          "SetAsFirstSibling",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.SetAsFirstSibling())
        )
      );


      TransformPrototype.SetProperty(
        "SetAsLastSibling",
        Bridge.CreateFunction(
          "SetAsLastSibling",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.SetAsLastSibling())
        )
      );


      TransformPrototype.SetProperty(
        "SetSiblingIndex",
        Bridge.CreateFunction(
          "SetSiblingIndex",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => o.SetSiblingIndex(args[1].ToInt32()))
        )
      );


      TransformPrototype.SetProperty(
        "GetSiblingIndex",
        Bridge.CreateFunction(
          "GetSiblingIndex",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => JavaScriptValue.FromInt32(o.GetSiblingIndex()))
        )
      );


      TransformPrototype.SetProperty(
        "Find",
        Bridge.CreateFunction(
          "Find",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.Find(args[1].ToString())))
        )
      );


      TransformPrototype.SetProperty(
        "IsChildOf",
        Bridge.CreateFunction(
          "IsChildOf",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => JavaScriptValue.FromBoolean(o.IsChildOf(Bridge.GetExternal<UnityEngine.Transform>(args[1]))))
        )
      );


      TransformPrototype.SetProperty(
        "GetEnumerator",
        Bridge.CreateFunction(
          "GetEnumerator",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.GetEnumerator()))
        )
      );

      TransformPrototype.SetProperty(
        JavaScriptValue.GlobalObject.GetProperty("Symbol").GetProperty("iterator").GetPropertyIdFromSymbol(),
        Bridge.GetPrototype("System.Collections.IEnumerable").GetProperty(
          JavaScriptValue.GlobalObject.GetProperty("Symbol").GetProperty("iterator").GetPropertyIdFromSymbol()
        )
      );


      TransformPrototype.SetProperty(
        "GetChild",
        Bridge.CreateFunction(
          "GetChild",
          Bridge.WithExternal<UnityEngine.Transform>((o, args) => Bridge.CreateExternalWithPrototype(o.GetChild(args[1].ToInt32())))
        )
      );


    }
  }
}
