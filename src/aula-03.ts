interface Pessoa {
  idade: number;
  nome: string;
  isMaiorIdade: boolean;
}

const pessoa: Pessoa = {
  idade: 543,
  nome: 'joão',
  isMaiorIdade: true,
};

console.log(pessoa);
