interface Pessoas {
  idade: number;
  nome: string;
}

interface Usuarios {
  pessoa: Pessoas;
  cidade: string;
}

const usuario: Usuarios = {
  cidade: 'Guarulhos',
  pessoa: {
    idade: 19,
    nome: 'Marllon',
  },
};

console.log(usuario);
