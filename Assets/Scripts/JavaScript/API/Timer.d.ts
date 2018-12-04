type TimerGuid = string;

declare function setTimeout(callback: () => void, msdelay?: number): TimerGuid;
declare function setInterval(
  callback: () => void,
  msinterval?: number
): TimerGuid;

declare function clearInterval(id: TimerGuid): void;
declare function clearTimeout(id: TimerGuid): void;
