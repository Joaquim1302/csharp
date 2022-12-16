CREATE TABLE compras (id_compras int not null primary key,
    id_cliente int,
    produto nvarchar(50),
    quantidade int,
    preco_unidade int,
    atualizacao datetime,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE)