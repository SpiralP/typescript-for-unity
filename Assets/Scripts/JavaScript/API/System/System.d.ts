declare namespace System {
  // TODO: Make everywhere that uses System.Type use generics instead, and remove System.Type.
  // See UnityEngine.GameObject#GetComponent for an example.
  type Type = string;

  type Byte = number; // 0-255
  namespace IO {
    type Stream = any;
  }
  type String = string;
  type Int32 = number;
  type UInt32 = number;
  type UInt64 = number;
  type IntPtr = any;
}

declare type byte = System.Byte;
