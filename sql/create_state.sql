create table if not exists country(
    id serial primary key,
    name varchar(255)
);

create table if not exists state(
    id serial primary key,
    name varchar(255),
    id_country int
);

create table if not exists city(
    id serial primary key,
    name varchar(255),
    id_state int
);