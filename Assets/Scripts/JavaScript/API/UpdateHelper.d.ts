type UpdateHookGuid = string;
declare namespace UpdateHelper {
  function addUpdateHook(callback: () => void): UpdateHookGuid;
  function addOneUpdateHook(callback: () => void): void;
  function removeUpdateHook(id: UpdateHookGuid): void;
  function removeAllUpdateHooks(): void;
}
