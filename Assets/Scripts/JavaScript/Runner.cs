using UnityEngine;

namespace JavaScript {
  public class Runner : MonoBehaviour {
    public string code = "";
    public string moduleSpecifier = "";

    void Start() {
      Engine.With(() => {
        if (moduleSpecifier != "") {
          Engine.Import(moduleSpecifier);
        } else if (code != "") {
          Engine.RunScript(code);
        }
      });
    }
  }
}
