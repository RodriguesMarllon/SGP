const funcaoCallback = (valor: number): void => {
  console.log('Deu Bom ' + valor);
};

const funcaoTeste2 = (valor1: number, valor2: number, callback: (n: number) => void): string => {
  if (valor1 > valor2) {
    callback(valor1);
  }
  return '';
};

funcaoTeste2(54, 23, funcaoCallback);
funcaoTeste2(54, 13, (x: number) => {
  console.log('outra função ' + x);
});
