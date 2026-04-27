CREATE DATABASE projeto_luck_games;
USE projeto_luck_games;


CREATE TABLE cargo (
    id_cargo INT PRIMARY KEY AUTO_INCREMENT,
    nome_cargo VARCHAR(50) NOT NULL UNIQUE
);


CREATE TABLE nivel_acesso (
    id_acesso INT PRIMARY KEY AUTO_INCREMENT,
    nome_nivel ENUM('basico', 'tecnico', 'admin') NOT NULL UNIQUE
);


CREATE TABLE pergunta_seguranca (
    id_pergunta INT PRIMARY KEY AUTO_INCREMENT,
    texto_pergunta VARCHAR(150) NOT NULL
);


CREATE TABLE funcionario (
    id_funcionario INT PRIMARY KEY AUTO_INCREMENT,
    nome_funcionario VARCHAR(100) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    senha VARCHAR(30) NOT NULL,
    resposta_secreta VARCHAR(255) NOT NULL,
    
    fk_id_cargo INT,
    fk_id_acesso INT,
    fk_id_pergunta INT,
    
    FOREIGN KEY (fk_id_cargo) REFERENCES cargo(id_cargo),
    FOREIGN KEY (fk_id_acesso) REFERENCES nivel_acesso(id_acesso),
    FOREIGN KEY (fk_id_pergunta) REFERENCES pergunta_seguranca(id_pergunta)
);


CREATE TABLE cliente(
  id_cliente INT PRIMARY KEY AUTO_INCREMENT,
  nome VARCHAR(100) NOT NULL,
  telefone VARCHAR(20),
  CPF VARCHAR(14) NOT NULL UNIQUE
);

CREATE TABLE aparelho(
  id_aparelho INT PRIMARY KEY AUTO_INCREMENT,
  marca VARCHAR (100) NOT NULL,
  tipo VARCHAR (100) NOT NULL,
  num_serie VARCHAR (100) NOT NULL,
  modelo VARCHAR (100),
  data_entrada DATETIME,
  descricao_problema TEXT,
  fk_id_cliente INT,
  FOREIGN KEY (fk_id_cliente) REFERENCES cliente(id_cliente)
);

CREATE TABLE ordem (
  id_ordem INT PRIMARY KEY AUTO_INCREMENT,
  aprovacao_orcamento VARCHAR (100),
  valor DECIMAL (7, 2),
  data_ordem DATETIME,
  fk_id_cliente INT,
  fk_id_aparelho INT,
  fk_id_funcionario INT,
  FOREIGN KEY (fk_id_cliente) REFERENCES cliente (id_cliente),
  FOREIGN KEY (fk_id_aparelho) REFERENCES aparelho (id_aparelho),
  FOREIGN KEY (fk_id_funcionario) REFERENCES funcionario (id_funcionario)
);

CREATE TABLE produto(
  id_produto INT PRIMARY KEY AUTO_INCREMENT,
  nome_produto VARCHAR (100),
  categoria VARCHAR (50),
  quantidade INT
);

CREATE TABLE item_ordem(
  id_itens_ordem INT PRIMARY KEY AUTO_INCREMENT,
  quantidade INT,
  valor_unitario DECIMAL (6, 2),
  fk_id_ordem INT,
  fk_id_produto INT,
  FOREIGN KEY (fk_id_ordem) REFERENCES ordem (id_ordem),
  FOREIGN KEY (fk_id_produto) REFERENCES produto (id_produto)
);

CREATE TABLE movimentacao(
  id_movimentacao INT PRIMARY KEY AUTO_INCREMENT,
  tipo_movimentacao VARCHAR (50),
  fk_id_produto INT,
  FOREIGN KEY (fk_id_produto) REFERENCES produto (id_produto)
);

INSERT INTO cargo (nome_cargo ) VALUES
("Técnico(a)"),
("Estoquista"),
("Atendente"),
("Proprietário(a)");

INSERT INTO nivel_acesso(nome_nivel) VALUES
(1),
(2),
(3);

INSERT INTO pergunta_seguranca(texto_pergunt) VALUES 
("Qual é o nome da sua primeira escola?"),
("Qual é o nome do seu primeiro pet?"),
("Em que cidade sua mãe nasceu?"); 