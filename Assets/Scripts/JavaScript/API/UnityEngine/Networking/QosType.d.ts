declare namespace UnityEngine {
  namespace Networking {
    enum QosType {
      Unreliable,
      UnreliableFragmented,
      UnreliableSequenced,
      Reliable,
      ReliableFragmented,
      ReliableSequenced,
      StateUpdate,
      ReliableStateUpdate,
      AllCostDelivery,
      UnreliableFragmentedSequenced,
      ReliableFragmentedSequenced,
    }
  }
}
