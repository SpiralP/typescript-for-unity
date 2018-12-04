interface InspectOptions {
  showHidden?: boolean;
  depth?: number | null;
  colors?: boolean;
  customInspect?: boolean;
  showProxy?: boolean;
  maxArrayLength?: number | null;
  breakLength?: number;
  compact?: boolean;
}
declare const inspect: {
  (
    object: any,
    showHidden?: boolean,
    depth?: number | null,
    color?: boolean
  ): string;
  (object: any, options: InspectOptions): string;
  colors: {
    [color: string]: [number, number] | undefined;
  };
  styles: {
    [style: string]: string | undefined;
  };
  defaultOptions: InspectOptions;
  custom: symbol;
};
