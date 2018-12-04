declare namespace http {
  function get(
    url: string,
    callback: (err: string | null, data: string | ArrayBuffer | null) => void,
    returnArrayBuffer?: boolean
  );

  function post(
    url: string,
    postData: string,
    callback: (err: string | null, data: string | ArrayBuffer | null) => void,
    returnArrayBuffer?: boolean
  );
}
