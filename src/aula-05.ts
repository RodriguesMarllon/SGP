interface Estado {
  nome: string;
}

interface Cidade {
  nome: string;
  estado: Estado;
}

interface Endereco {
  nome: string;
  bairro: string;
  cidade: Cidade;
  complemento?: string;
}

const endereco: Endereco = {
  nome: 'endereço de casa',
  bairro: 'Pimentas',
  cidade: {
    nome: 'Guarulhos',
    estado: {
      nome: 'SP',
    },
  },
};

console.log(endereco);
