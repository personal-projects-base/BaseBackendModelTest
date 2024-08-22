create table if not exists product(
    id serial primary key,
    name varchar(255),
    preco numeric(18,2),
    datacriacao timestamp
);