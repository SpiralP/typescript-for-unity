using System.Text;
using ChakraCore.API;

namespace JavaScript.API {
  class File {
    public static void Register(JavaScriptContext context) {
      var file = JavaScriptValue.CreateObject();
      JavaScriptValue.GlobalObject.SetProperty(
        "file",
        file
      );

      file.SetProperty(
        "readAllText",
        Bridge.CreateFunction((args) => {
          string path = args[1].ToString();

          string encodingString = "";
          if (args.Length > 2) {
            encodingString = args[2].ToString();
          }

          Encoding encoding;
          switch (encodingString) {
            case "utf-8":
            case "utf8":
            default:
              encoding = Encoding.UTF8;
              break;
          }

          return JavaScriptValue.FromString(
            System.IO.File.ReadAllText(path, encoding)
          );
        })
      );
    }
  }
}
