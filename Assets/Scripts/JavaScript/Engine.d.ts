declare var engine: UnityEngine.Component;
declare var root: UnityEngine.GameObject;
declare var bindings: {
  get<T>(name: string): T;
};

declare var importModule: (specifier: string) => Object;
declare var importScripts: (...specifiers: Array<string>) => void;
